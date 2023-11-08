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
    public partial class frmcomodos : Form
    {
        public frmcomodos()
        {
            InitializeComponent();
        }
        double areat;

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double larg, comp, area;

            string name;

            name = txtName.Text;


            larg = Convert.ToDouble(txtLarg.Text);
            comp = Convert.ToDouble(txtComp.Text);
            area = larg * comp;
            areat+= area;

            var Result = MessageBox.Show("a area do comodo: " + name + " é de: " + area + "M²" + "\r\n" + "Deseja continuar?", "RESULTADO", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                txtLarg.Clear();
                txtComp.Clear();
                txtName.Clear();

            }
            else
            {
                MessageBox.Show("A area total do imovel é de: " + Convert.ToString(areat) + "M²", "AREA TOTAL");
            }





        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MENU = new Form1();
            MENU.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtComp.Clear();
            txtLarg.Clear();
            txtName.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
