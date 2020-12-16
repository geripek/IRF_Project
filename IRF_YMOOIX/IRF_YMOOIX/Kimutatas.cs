using IRF_YMOOIX.Osztalyok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_YMOOIX
{
    public partial class Kimutatas : Form
    {
        List<Adatok> adat = new List<Adatok>();
        List<Orszagok> orsz = new List<Orszagok>();

        public int i = 0; //országok száma 
        public int j = 1; //timerhez, alaphelyzethez
        public int b = 1; //timerhez, folytatáshoz

        public Kimutatas()
        {
            InitializeComponent();

            LoadData();
            LoadNames();

            //Szöveg
            
            szovegek1.Text = "Keressen rá az országra! " +
                "(beír egy betűt és kiadja az országokat, amikben benne van, " +
                "de különbséget tesz a nagy- és kisbetűk között)";

            szovegek2.Text = "Kattintson az Indít gombra\naz automata váltásért!";

            szovegek3.Visible = false; //diagramon az ország timer alatt
            szovegek3.BackColor = Color.White;

            //Gombok

            gombok1.Text = "Indít";

            gombok2.Text = "Stop";
            gombok2.Visible = false;
            gombok2.BackColor = Color.Red;

            gombok3.Text = "Alaphelyzet";
            gombok3.Visible = false;
                        
            gombok5.Text = "Folytatás";
            gombok5.Visible = false;
            gombok5.BackColor = Color.Green;

            gombok4.Text = "Vissza";

            //Első ország adatai
            
            var kezdo = from x in orsz
                        select x;
            listBox1.DisplayMember = "nev";
            listBox1.DataSource = kezdo.ToList();
        }

        private void LoadData()
        {
            adat.Clear();

            using (StreamReader sr = new StreamReader("adatok.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    Adatok a = new Adatok();
                    a.orszag = line[0];
                    a.ev = int.Parse(line[1]);
                    a.nepesseg = long.Parse(line[2]);

                    adat.Add(a);
                }

            }
        }

        private void LoadNames()
        {
            orsz.Clear();

            using (StreamReader sr = new StreamReader("orszagok.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    Orszagok o = new Orszagok();
                    o.nev = line[0];
                    i++;

                    orsz.Add(o);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OrszagKeres();
        }

        void OrszagKeres()
        {
            var o = from x in orsz
                    where x.nev.Contains(textBox1.Text)
                    select x;

            listBox1.DisplayMember = "nev";
            listBox1.DataSource = o.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szovegek3.Visible = false;
            var ev = from x in adat
                     where x.orszag == ((Orszagok)listBox1.SelectedItem).nev
                     select new
                     {
                         Év = x.ev,
                         Népesség = x.nepesseg,
                     };

            dataGridView1.DataSource = ev.ToList();
            Diagram();
        }

        public void Diagram()
        {
            chart1.DataSource = dataGridView1.DataSource;
            chart1.Series[0] = new Series();
            chart1.Series[0].XValueMember = dataGridView1.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dataGridView1.Columns[1].DataPropertyName;
            chart1.Series[0].BorderWidth = 4;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.IsStartedFromZero = false;

            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].ChartType = SeriesChartType.Column;
        }

        private void gombok4_Click(object sender, EventArgs e) //Vissza
        {
            Close();
        }

        private void gombok1_Click(object sender, EventArgs e) //Indít
        {
            int a = 0;
            szovegek3.Visible = true;
            listBox1.SelectedItem = orsz[a].nev;
            var tim = from x in adat
                      where x.orszag == orsz[a].nev
                      select new
                      {
                          Év = x.ev,
                          Népesség = x.nepesseg,
                      };
            dataGridView1.DataSource = tim.ToList();
            Diagram();
            szovegek3.Text = orsz[a].nev;
            automata1.Start();
            gombok2.Visible = true;
            gombok3.Visible = true;   
        }

        private void automata1_Tick(object sender, EventArgs e) //első timer - Indít
        {
            szovegek3.Visible = true;

            if (j<i)
            {
                listBox1.SelectedItem = orsz[j].nev;
                var a = from x in adat
                        where x.orszag == orsz[j].nev
                        select new
                        {
                            Év = x.ev,
                            Népesség = x.nepesseg,
                        };
                dataGridView1.DataSource = a.ToList();
                Diagram();
                szovegek3.Text = orsz[j].nev;
                j++;
                b++;
            }
            else
            {
                automata1.Stop();
            }
        }

        private void gombok2_Click(object sender, EventArgs e) //Stop
        {
            automata1.Stop();
            automata2.Stop();
            gombok5.Visible = true;
        }

        private void gombok3_Click(object sender, EventArgs e) //Alaphelyzet
        {
            szovegek3.Visible = true;
            j = 0;
            listBox1.SelectedItem = orsz[j].nev;
            var alap = from x in adat
                       where x.orszag == orsz[j].nev
                       select new
                       {
                           Év = x.ev,
                           Népesség = x.nepesseg,
                       };
            dataGridView1.DataSource = alap.ToList();
            Diagram();
            szovegek3.Text = orsz[j].nev;
            automata1.Stop();
            automata2.Stop();
            gombok2.Visible = false;
            gombok3.Visible = false;
            gombok5.Visible = false;
        }

        private void gombok5_Click(object sender, EventArgs e) //Folytatás
        {
            int a = b;
            szovegek3.Visible = true;
            listBox1.SelectedItem = orsz[a].nev;
            var tim = from x in adat
                      where x.orszag == orsz[a].nev
                      select new
                      {
                          Év = x.ev,
                          Népesség = x.nepesseg,
                      };
            dataGridView1.DataSource = tim.ToList();
            Diagram();
            szovegek3.Text = orsz[a].nev;
            automata2.Start();
        }      
   
        private void automata2_Tick(object sender, EventArgs e) //második timer - Folytatás
        {

            szovegek3.Visible = true;

            if (b < i)
            {
                listBox1.SelectedItem = orsz[b].nev;
                var tim1 = from x in adat
                           where x.orszag == orsz[b].nev
                           select new
                           {
                               Év = x.ev,
                               Népesség = x.nepesseg,
                           };
                dataGridView1.DataSource = tim1.ToList();
                Diagram();
                szovegek3.Text = orsz[b].nev;
                b++;
            }
            else
            {
                automata2.Stop();
            }
        }
    }
}
