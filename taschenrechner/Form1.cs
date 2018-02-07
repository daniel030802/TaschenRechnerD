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
    public partial class Form1 : Form
    {

        double zahl1;
        double zahl2;
        double ergebnis;
        bool activetxtb = true;
        public Form1()
        {


            InitializeComponent();




        }

        private void btnGleich_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtbZahl1.Text);
            zahl2 = Convert.ToDouble(txtbZahl2.Text);

            if (listbOperationen.SelectedItems.Count > 0)
            {
                if (listbOperationen.SelectedItem.ToString() == "+")
                {
                    ergebnis = zahl1 + zahl2;

                }
                if (listbOperationen.SelectedItem.ToString() == "-")
                {
                    ergebnis = zahl1 - zahl2;
                }
                if (listbOperationen.SelectedItem.ToString() == "*")
                {
                    ergebnis = zahl1 * zahl2;
                }
                if (listbOperationen.SelectedItem.ToString() == ":")
                {
                    ergebnis = zahl1 / zahl2;
                }

                txtbErgebnis.Text = ergebnis.ToString();

            }





        }

        private void btnKomma_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btnKomma.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btnKomma.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn0.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn0.Text;
            }



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn1.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn2.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn3.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn4.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn5.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn6.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn7.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn8.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (activetxtb == true)
            {
                txtbZahl1.Text += btn9.Text;

            }
            if (activetxtb == false)
            {
                txtbZahl2.Text += btn9.Text;
            }
        }

        
 private void txtbZahl1_Click(object sender, EventArgs e)
        {
            activetxtb = true;
        }
       

        private void txtbZahl2_Click(object sender, EventArgs e)
        {
            activetxtb = false;
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtbZahl1.Text = "";
            txtbZahl2.Text = "";
            txtbErgebnis.Text = "";
        }

        

        private void btnMenue_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }
    }
}
