
namespace C_Alexandre_e_Gabriela
{
    partial class frmcomodos
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLarg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnvoltar.Location = new System.Drawing.Point(26, 391);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(102, 35);
            this.btnvoltar.TabIndex = 18;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnclear.Location = new System.Drawing.Point(134, 391);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(115, 35);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btncalc.Location = new System.Drawing.Point(26, 213);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(140, 38);
            this.btncalc.TabIndex = 14;
            this.btncalc.Text = "CALCULAR";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 20);
            this.txtName.TabIndex = 20;
            this.txtName.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(239, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "DIGITE O NOME DO COMODO:";
            this.lblName.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // txtLarg
            // 
            this.txtLarg.Location = new System.Drawing.Point(303, 123);
            this.txtLarg.Name = "txtLarg";
            this.txtLarg.Size = new System.Drawing.Size(111, 20);
            this.txtLarg.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "DIGITE A LARGURA DO COMODO:";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(343, 158);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(111, 20);
            this.txtComp.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "DIGITE O COMPRIMENTO DO COMODO:";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnexit.Location = new System.Drawing.Point(666, 391);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(106, 35);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cálculo área total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmcomodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLarg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Name = "frmcomodos";
            this.Text = "frmcomodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLarg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label3;
    }
}