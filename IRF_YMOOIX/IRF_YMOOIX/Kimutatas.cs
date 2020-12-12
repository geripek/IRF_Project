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
            gombok3.Text = "Alaphelyzet";
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

        private void gombok1_Click(object sender, EventArgs e)
        {
            
            
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
    }
}
