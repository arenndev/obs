namespace OBS
{
    partial class OgrenciGiris
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
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.OgrenciSifre = new System.Windows.Forms.Label();
            this.txtBoxOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtBoxOgrenciSifre = new System.Windows.Forms.TextBox();
            this.btnOgrenciGirisYap = new System.Windows.Forms.Button();
            this.lblKullaniciBilgileriYanlis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciNo.Location = new System.Drawing.Point(45, 51);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(110, 20);
            this.lblOgrenciNo.TabIndex = 0;
            this.lblOgrenciNo.Text = "Öğrenci No:";
            // 
            // OgrenciSifre
            // 
            this.OgrenciSifre.AutoSize = true;
            this.OgrenciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciSifre.Location = new System.Drawing.Point(100, 96);
            this.OgrenciSifre.Name = "OgrenciSifre";
            this.OgrenciSifre.Size = new System.Drawing.Size(55, 20);
            this.OgrenciSifre.TabIndex = 1;
            this.OgrenciSifre.Text = "Şifre:";
            // 
            // txtBoxOgrenciNo
            // 
            this.txtBoxOgrenciNo.Location = new System.Drawing.Point(172, 51);
            this.txtBoxOgrenciNo.Name = "txtBoxOgrenciNo";
            this.txtBoxOgrenciNo.Size = new System.Drawing.Size(133, 22);
            this.txtBoxOgrenciNo.TabIndex = 2;
            // 
            // txtBoxOgrenciSifre
            // 
            this.txtBoxOgrenciSifre.Location = new System.Drawing.Point(172, 94);
            this.txtBoxOgrenciSifre.Name = "txtBoxOgrenciSifre";
            this.txtBoxOgrenciSifre.Size = new System.Drawing.Size(133, 22);
            this.txtBoxOgrenciSifre.TabIndex = 3;
            // 
            // btnOgrenciGirisYap
            // 
            this.btnOgrenciGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGirisYap.Location = new System.Drawing.Point(172, 140);
            this.btnOgrenciGirisYap.Name = "btnOgrenciGirisYap";
            this.btnOgrenciGirisYap.Size = new System.Drawing.Size(133, 34);
            this.btnOgrenciGirisYap.TabIndex = 4;
            this.btnOgrenciGirisYap.Text = "Giriş Yap";
            this.btnOgrenciGirisYap.UseVisualStyleBackColor = true;
            this.btnOgrenciGirisYap.Click += new System.EventHandler(this.btnOgrenciGirisYap_Click);
            // 
            // lblKullaniciBilgileriYanlis
            // 
            this.lblKullaniciBilgileriYanlis.AutoSize = true;
            this.lblKullaniciBilgileriYanlis.ForeColor = System.Drawing.Color.Red;
            this.lblKullaniciBilgileriYanlis.Location = new System.Drawing.Point(89, 194);
            this.lblKullaniciBilgileriYanlis.Name = "lblKullaniciBilgileriYanlis";
            this.lblKullaniciBilgileriYanlis.Size = new System.Drawing.Size(181, 16);
            this.lblKullaniciBilgileriYanlis.TabIndex = 5;
            this.lblKullaniciBilgileriYanlis.Text = "Şifre veya kullanıcı adı yanlış!";
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 240);
            this.Controls.Add(this.lblKullaniciBilgileriYanlis);
            this.Controls.Add(this.btnOgrenciGirisYap);
            this.Controls.Add(this.txtBoxOgrenciSifre);
            this.Controls.Add(this.txtBoxOgrenciNo);
            this.Controls.Add(this.OgrenciSifre);
            this.Controls.Add(this.lblOgrenciNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgrenciGiris";
            this.Text = "OgrenciGiris";
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label OgrenciSifre;
        private System.Windows.Forms.TextBox txtBoxOgrenciNo;
        private System.Windows.Forms.TextBox txtBoxOgrenciSifre;
        private System.Windows.Forms.Button btnOgrenciGirisYap;
        private System.Windows.Forms.Label lblKullaniciBilgileriYanlis;
    }
}