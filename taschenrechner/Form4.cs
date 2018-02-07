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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnWurzelberechnung_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void btnPythagoras_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
