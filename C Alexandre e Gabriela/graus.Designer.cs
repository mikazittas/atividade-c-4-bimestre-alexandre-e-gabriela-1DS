
namespace C_Alexandre_e_Gabriela
{
    partial class graus
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
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalce = new System.Windows.Forms.Button();
            this.btncalcr = new System.Windows.Forms.Button();
            this.btncalcf = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(12, 67);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(254, 20);
            this.lblnum.TabIndex = 2;
            this.lblnum.Text = "DIGITE O VALOR EM GRAUS C°:";
            this.lblnum.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(272, 69);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(111, 20);
            this.txtnum.TabIndex = 3;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(12, 127);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(310, 20);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "RESULTADO + SOMANDO DE 10 EM 10:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(333, 127);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(203, 268);
            this.txtresult.TabIndex = 5;
            // 
            // btncalce
            // 
            this.btncalce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalce.Location = new System.Drawing.Point(12, 220);
            this.btncalce.Name = "btncalce";
            this.btncalce.Size = new System.Drawing.Size(128, 30);
            this.btncalce.TabIndex = 6;
            this.btncalce.Text = "calc (enquanto)";
            this.btncalce.UseVisualStyleBackColor = true;
            this.btncalce.Click += new System.EventHandler(this.btncalce_Click);
            // 
            // btncalcr
            // 
            this.btncalcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcr.Location = new System.Drawing.Point(12, 269);
            this.btncalcr.Name = "btncalcr";
            this.btncalcr.Size = new System.Drawing.Size(128, 30);
            this.btncalcr.TabIndex = 7;
            this.btncalcr.Text = "calc (repeat)";
            this.btncalcr.UseVisualStyleBackColor = true;
            this.btncalcr.Click += new System.EventHandler(this.btncalcr_Click);
            // 
            // btncalcf
            // 
            this.btncalcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcf.Location = new System.Drawing.Point(12, 324);
            this.btncalcf.Name = "btncalcf";
            this.btncalcf.Size = new System.Drawing.Size(128, 30);
            this.btncalcf.TabIndex = 8;
            this.btncalcf.Text = "calc (for)";
            this.btncalcf.UseVisualStyleBackColor = true;
            this.btncalcf.Click += new System.EventHandler(this.btncalcf_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(674, 404);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 34);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(106, 405);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(74, 33);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 404);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(74, 34);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cálculo temperatura";
            // 
            // graus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalcf);
            this.Controls.Add(this.btncalcr);
            this.Controls.Add(this.btncalce);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Name = "graus";
            this.Text = "graus";
            this.Load += new System.EventHandler(this.graus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalce;
        private System.Windows.Forms.Button btncalcr;
        private System.Windows.Forms.Button btncalcf;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label1;
    }
}