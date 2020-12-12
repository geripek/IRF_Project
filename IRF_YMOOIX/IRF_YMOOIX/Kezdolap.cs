using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_YMOOIX
{
    public partial class Kezdolap : Form
    {
        public Kezdolap()
        {
            InitializeComponent();
            label1.Text = "A Tovább gombra kattintva eljut a következő lapra,\namin az európai országok 2008-2019 közötti népességváltozását láthatja majd évekre bontva és diagrammon!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kimutatas k = new Kimutatas();
            k.Show();
        }
    }
}
