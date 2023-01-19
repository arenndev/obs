namespace OBS
{
    partial class OgretmenGiris
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
            this.lblOgretmenId = new System.Windows.Forms.Label();
            this.OgretmenSifre = new System.Windows.Forms.Label();
            this.Idveyasifre = new System.Windows.Forms.Label();
            this.txtBoxOgretmenId = new System.Windows.Forms.TextBox();
            this.txtBoxOgretmenSifre = new System.Windows.Forms.TextBox();
            this.OgretmenGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOgretmenId
            // 
            this.lblOgretmenId.AutoSize = true;
            this.lblOgretmenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenId.Location = new System.Drawing.Point(25, 45);
            this.lblOgretmenId.Name = "lblOgretmenId";
            this.lblOgretmenId.Size = new System.Drawing.Size(118, 20);
            this.lblOgretmenId.TabIndex = 0;
            this.lblOgretmenId.Text = "Öğretmen İd:";
            // 
            // OgretmenSifre
            // 
            this.OgretmenSifre.AutoSize = true;
            this.OgretmenSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgretmenSifre.Location = new System.Drawing.Point(88, 86);
            this.OgretmenSifre.Name = "OgretmenSifre";
            this.OgretmenSifre.Size = new System.Drawing.Size(55, 20);
            this.OgretmenSifre.TabIndex = 1;
            this.OgretmenSifre.Text = "Şifre:";
            // 
            // Idveyasifre
            // 
            this.Idveyasifre.AutoSize = true;
            this.Idveyasifre.BackColor = System.Drawing.Color.Transparent;
            this.Idveyasifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Idveyasifre.ForeColor = System.Drawing.Color.Red;
            this.Idveyasifre.Location = new System.Drawing.Point(103, 180);
            this.Idveyasifre.Name = "Idveyasifre";
            this.Idveyasifre.Size = new System.Drawing.Size(129, 18);
            this.Idveyasifre.TabIndex = 2;
            this.Idveyasifre.Text = "İd veya şifre yanlış!";
            // 
            // txtBoxOgretmenId
            // 
            this.txtBoxOgretmenId.Location = new System.Drawing.Point(168, 45);
            this.txtBoxOgretmenId.Name = "txtBoxOgretmenId";
            this.txtBoxOgretmenId.Size = new System.Drawing.Size(120, 22);
            this.txtBoxOgretmenId.TabIndex = 3;
            // 
            // txtBoxOgretmenSifre
            // 
            this.txtBoxOgretmenSifre.Location = new System.Drawing.Point(168, 86);
            this.txtBoxOgretmenSifre.Name = "txtBoxOgretmenSifre";
            this.txtBoxOgretmenSifre.Size = new System.Drawing.Size(120, 22);
            this.txtBoxOgretmenSifre.TabIndex = 4;
            // 
            // OgretmenGirisYap
            // 
            this.OgretmenGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgretmenGirisYap.Location = new System.Drawing.Point(168, 125);
            this.OgretmenGirisYap.Name = "OgretmenGirisYap";
            this.OgretmenGirisYap.Size = new System.Drawing.Size(120, 36);
            this.OgretmenGirisYap.TabIndex = 5;
            this.OgretmenGirisYap.Text = "Giriş Yap";
            this.OgretmenGirisYap.UseVisualStyleBackColor = true;
            this.OgretmenGirisYap.Click += new System.EventHandler(this.OgretmenGirisYap_Click);
            // 
            // OgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 225);
            this.Controls.Add(this.OgretmenGirisYap);
            this.Controls.Add(this.txtBoxOgretmenSifre);
            this.Controls.Add(this.txtBoxOgretmenId);
            this.Controls.Add(this.Idveyasifre);
            this.Controls.Add(this.OgretmenSifre);
            this.Controls.Add(this.lblOgretmenId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgretmenGiris";
            this.Text = "OgretmenGiris";
            this.Load += new System.EventHandler(this.OgretmenGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgretmenId;
        private System.Windows.Forms.Label OgretmenSifre;
        private System.Windows.Forms.Label Idveyasifre;
        private System.Windows.Forms.TextBox txtBoxOgretmenId;
        private System.Windows.Forms.TextBox txtBoxOgretmenSifre;
        private System.Windows.Forms.Button OgretmenGirisYap;
    }
}