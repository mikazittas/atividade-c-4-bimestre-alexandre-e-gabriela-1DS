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
    public partial class graus : Form
    {
        public graus()
        {
            InitializeComponent();
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmprincipal = new Form1();
            frmprincipal.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

        }

        private void btncalce_Click(object sender, EventArgs e)
        {
            double i, c, f;

            i = 0;

            c = Convert.ToDouble(txtnum.Text);

            txtnum.Clear();
            txtresult.Clear();

            while (i <= 100)
            {
                f = c * 1.8 + 32;
                f = f + i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "C° para F° ---> " + f.ToString());
                i = i + 10;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalcr_Click(object sender, EventArgs e)
        {
            double i, c, f;

            i = 0;

            c = Convert.ToDouble(txtnum.Text);

            txtnum.Clear();
            txtresult.Clear();

            do
            {
                f = c * 1.8 + 32;
                f = f + i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "C° para F° ---> " + f.ToString());
                i = i + 10;
            } while (i < 110);
        }

        private void btncalcf_Click(object sender, EventArgs e)
        {
            double i, c, f;

            c = Convert.ToDouble(txtnum.Text);

            txtnum.Clear();
            txtresult.Clear();

            for(i = 0; i<110; i = i+10)
            {
                f = c * 1.8 + 32;
                f = f + i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "C° para F° ---> " + f.ToString());
            };
        }

        private void graus_Load(object sender, EventArgs e)
        {

        }
    }
}
