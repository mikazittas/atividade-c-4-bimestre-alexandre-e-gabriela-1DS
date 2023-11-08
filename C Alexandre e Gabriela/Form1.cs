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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabuadaparaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabuadaenquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tabuada_enquanto_ TABE = new tabuada_enquanto_();
            TABE.Show();
        }


        private void grausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            graus GRAUS = new graus();
            GRAUS.Show();
        }

        private void comodosEnquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcomodos COMODO = new frmcomodos();
            COMODO.Show();
        }
    }
}
