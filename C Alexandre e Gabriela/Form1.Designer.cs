
namespace C_Alexandre_e_Gabriela
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaenquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comodosEnquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaenquantoToolStripMenuItem,
            this.comodosEnquantoToolStripMenuItem,
            this.grausToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // tabuadaenquantoToolStripMenuItem
            // 
            this.tabuadaenquantoToolStripMenuItem.Name = "tabuadaenquantoToolStripMenuItem";
            this.tabuadaenquantoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tabuadaenquantoToolStripMenuItem.Text = "Tabuada(enquanto)";
            this.tabuadaenquantoToolStripMenuItem.Click += new System.EventHandler(this.tabuadaenquantoToolStripMenuItem_Click);
            // 
            // comodosEnquantoToolStripMenuItem
            // 
            this.comodosEnquantoToolStripMenuItem.Name = "comodosEnquantoToolStripMenuItem";
            this.comodosEnquantoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.comodosEnquantoToolStripMenuItem.Text = "Comodos(Enquanto)";
            this.comodosEnquantoToolStripMenuItem.Click += new System.EventHandler(this.comodosEnquantoToolStripMenuItem_Click);
            // 
            // grausToolStripMenuItem
            // 
            this.grausToolStripMenuItem.Name = "grausToolStripMenuItem";
            this.grausToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.grausToolStripMenuItem.Text = "graus";
            this.grausToolStripMenuItem.Click += new System.EventHandler(this.grausToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaenquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comodosEnquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grausToolStripMenuItem;
    }
}

