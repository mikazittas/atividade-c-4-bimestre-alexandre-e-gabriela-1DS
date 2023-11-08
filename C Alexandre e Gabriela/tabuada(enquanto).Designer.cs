
namespace C_Alexandre_e_Gabriela
{
    partial class tabuada_enquanto_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btncalce = new System.Windows.Forms.Button();
            this.LBLTAB = new System.Windows.Forms.Label();
            this.txttab = new System.Windows.Forms.TextBox();
            this.btncalcr = new System.Windows.Forms.Button();
            this.btncalcf = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 404);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(74, 34);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(660, 404);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 34);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(12, 86);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(400, 20);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "DIGITE O NUMERO QUE DESEJA VER A TABUADA:";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(419, 85);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(111, 20);
            this.txtnum.TabIndex = 2;
            // 
            // btncalce
            // 
            this.btncalce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalce.Location = new System.Drawing.Point(12, 344);
            this.btncalce.Name = "btncalce";
            this.btncalce.Size = new System.Drawing.Size(128, 30);
            this.btncalce.TabIndex = 3;
            this.btncalce.Text = "calc (enquanto)";
            this.btncalce.UseVisualStyleBackColor = true;
            this.btncalce.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // LBLTAB
            // 
            this.LBLTAB.AutoSize = true;
            this.LBLTAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTAB.Location = new System.Drawing.Point(12, 131);
            this.LBLTAB.Name = "LBLTAB";
            this.LBLTAB.Size = new System.Drawing.Size(90, 20);
            this.LBLTAB.TabIndex = 4;
            this.LBLTAB.Text = "TABUADA:";
            this.LBLTAB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txttab
            // 
            this.txttab.Location = new System.Drawing.Point(108, 133);
            this.txttab.Multiline = true;
            this.txttab.Name = "txttab";
            this.txttab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttab.Size = new System.Drawing.Size(275, 141);
            this.txttab.TabIndex = 5;
            // 
            // btncalcr
            // 
            this.btncalcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcr.Location = new System.Drawing.Point(168, 344);
            this.btncalcr.Name = "btncalcr";
            this.btncalcr.Size = new System.Drawing.Size(128, 30);
            this.btncalcr.TabIndex = 6;
            this.btncalcr.Text = "calc (repeat)";
            this.btncalcr.UseVisualStyleBackColor = true;
            this.btncalcr.Click += new System.EventHandler(this.btncalcr_Click);
            // 
            // btncalcf
            // 
            this.btncalcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcf.Location = new System.Drawing.Point(322, 344);
            this.btncalcf.Name = "btncalcf";
            this.btncalcf.Size = new System.Drawing.Size(128, 30);
            this.btncalcf.TabIndex = 7;
            this.btncalcf.Text = "calc (for)";
            this.btncalcf.UseVisualStyleBackColor = true;
            this.btncalcf.Click += new System.EventHandler(this.btncalcf_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(108, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(74, 33);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TABUADA";
            // 
            // tabuada_enquanto_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalcf);
            this.Controls.Add(this.btncalcr);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.LBLTAB);
            this.Controls.Add(this.btncalce);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnvoltar);
            this.Name = "tabuada_enquanto_";
            this.Text = "tabuada";
            this.Load += new System.EventHandler(this.tabuada_enquanto__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btncalce;
        private System.Windows.Forms.Label LBLTAB;
        private System.Windows.Forms.TextBox txttab;
        private System.Windows.Forms.Button btncalcr;
        private System.Windows.Forms.Button btncalcf;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
    }
}