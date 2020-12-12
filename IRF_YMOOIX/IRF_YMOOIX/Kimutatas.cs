using IRF_YMOOIX.Osztalyok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public int j = 0; //timerhez

        public Kimutatas()
        {
            InitializeComponent();

            LoadData();
            LoadNames();

            szovegek1.Text = "Keressen rá az országra! " +
                "(beír egy betűt és kiadja az országokat, amikben benne van, de különbséget tesz a nagy- és kisbetűk között)";
            szovegek2.Text = "Kattinstson az Indít gombra\naz automata váltásért!";

            gombok1.Text = "Indít";
            gombok2.Text = "Stop";
            gombok2.Visible = false;
            gombok3.Text = "Alaphelyzet";
            gombok3.Visible = false;
            gombok4.Text = "Vissza";
            szovegek3.Visible = false;
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
            timer11.Start();
            gombok2.Visible = true;
            gombok3.Visible = true;   
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
            chart1.DataSource = dataGridView1.DataSource;
            chart1.Series[0].BorderWidth = 4;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.IsStartedFromZero = false;


            chart1.Series[0].ChartType = SeriesChartType.Line;
        }

        private void gombok4_Click(object sender, EventArgs e) //Vissza
        {
            Close();
        }

        private void gombok2_Click(object sender, EventArgs e) //Stop
        {
            timer11.Stop();
        }

        private void gombok3_Click(object sender, EventArgs e) //Alaphelyzet
        {
            szovegek3.Visible = true;
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
            timer11.Stop();
            gombok2.Visible = false;
            gombok3.Visible = false;
        }
    }
}
