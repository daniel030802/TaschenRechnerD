using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taschenrechner
{
    public partial class Form2 : Form
    {
        double eingabe;
        double ergebnis;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            if (txtbZahl.Text == "")
            {

            }
            else
            {
                eingabe = Convert.ToDouble(txtbZahl.Text);
                ergebnis = Math.Sqrt(eingabe);
                lblErgebnis.Text = ergebnis.ToString();
            }

        }
    }
}
