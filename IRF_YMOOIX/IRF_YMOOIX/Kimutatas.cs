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
                    string[] line = sr.ReadLine().Split(",");
                    Orszagok o = new Orszagok();
                    o.nev = line[0];
                    i++;

                    orsz.Add(o);
                }
            }
        }
    }
}
