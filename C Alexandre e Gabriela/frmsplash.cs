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
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            
        }

        private void tmrSplash_Tick_1(object sender, EventArgs e)
        {
            if (prgSplash.Value < 100)
            {
                //execute o progressbar 2vezes
                prgSplash.Value = prgSplash.Value + 5;
            }
            //senão
            else
            {
                //desabite o timer 
                tmrSplash.Enabled = false;
                //deixe o tmer com a visibiliadade falsa
                this.Visible = false;
                //instancia para chamar a tela menu
                Form1 menu = new Form1();
                //chamando a tela menu
                menu.Show();

            }
        }
    }
}
