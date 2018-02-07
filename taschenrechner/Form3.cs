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
    public partial class Form3 : Form
    {
        double a;
        double b;
        double c;


        public Form3()
        {
            InitializeComponent();
        }

        private void btna_Click(object sender, EventArgs e)
        {
            
            if (txtbb.Text == "" || txtbc.Text == "")
            { }
            
            else
            {
                b = Convert.ToDouble(txtbb.Text);
                c = Convert.ToDouble(txtbc.Text);
                a = Math.Sqrt((c * c) - (b * b));
                txtba.Text = a.ToString();

            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            
            if (txtba.Text == "" || txtbc.Text == "")
            { }
            
            
            else
            {
                a = Convert.ToDouble(txtba.Text);
                c = Convert.ToDouble(txtbc.Text);
                b = Math.Sqrt((c * c) - (a * a));
                txtbb.Text = b.ToString();
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            
            if (txtbb.Text == "" || txtba.Text == "")
            { }
           
            
            else
            {
                b = Convert.ToDouble(txtbb.Text);
                a = Convert.ToDouble(txtba.Text);
                c = Math.Sqrt((a * a) + (b * b));
                txtbc.Text = c.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtba.Text = "";
            txtbb.Text = "";
            txtbc.Text = "";

        }
    }
}
