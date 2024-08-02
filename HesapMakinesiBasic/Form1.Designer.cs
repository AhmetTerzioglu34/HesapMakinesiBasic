namespace HesapMakinesiBasic
{
    partial class Form1
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
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(378, 67);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 0;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(158, 67);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlk sayıyı giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(375, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci sayıyı giriniz";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(158, 128);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(110, 61);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(158, 201);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(110, 61);
            this.btnCikar.TabIndex = 2;
            this.btnCikar.Text = "-";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(378, 128);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(110, 61);
            this.btnCarp.TabIndex = 2;
            this.btnCarp.Text = "x";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(378, 201);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(110, 61);
            this.btnBol.TabIndex = 2;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSonuc.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblSonuc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSonuc.Location = new System.Drawing.Point(288, 278);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(113, 64);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblSonuc;
    }
}

