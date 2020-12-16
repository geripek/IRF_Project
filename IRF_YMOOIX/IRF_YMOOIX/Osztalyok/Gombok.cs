using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IRF_YMOOIX.Osztalyok
{
    class Gombok: Button
    {
        public Gombok()
        {
            Height = 35;
            Width = 85;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            BackColor = Color.Orange;
        }
    }
}
