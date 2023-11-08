using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Alexandre_e_Gabriela
{
    public partial class tabuada_enquanto_ : Form
    {
        public tabuada_enquanto_()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double i, r, num;

            i = 0;
            num = Convert.ToDouble(txtnum.Text);
            txttab.Clear();

            while (i <= 10)
            {
                r = num * i;
                txttab.Text = String.Concat(txttab.Text + "\r\n" + num.ToString() + " X " + i.ToString() + " = " + r.ToString());
                i = i + 1;
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncalcr_Click(object sender, EventArgs e)
        {
            double i, r, num;

            i = 0;
            txttab.Clear();
            do
            {
                num = Convert.ToDouble(txtnum.Text);
                r = num * i;
                txttab.Text = String.Concat(txttab.Text + "\r\n" + num.ToString() + " X " + i.ToString() + " = " + r.ToString());
                i++;
            } while (i < 11);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttab.Clear();
        }

        private void btncalcf_Click(object sender, EventArgs e)
        {
            double i, r, num;

            txttab.Clear();
            num = Convert.ToDouble(txtnum.Text);


            for (i = 1; i<11; i++)
            { 
                r = num * i;
                txttab.Text = String.Concat(txttab.Text + "\r\n" + num.ToString() + " X " + i.ToString() + " = " + r.ToString());
            }

        }

        private void tabuada_enquanto__Load(object sender, EventArgs e)
        {

        }
    }
}
