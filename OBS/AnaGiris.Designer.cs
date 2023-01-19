namespace OBS
{
    partial class AnaGiris
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
            this.btnOgrenciGirisi = new System.Windows.Forms.Button();
            this.btnOgretmenGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciGirisi
            // 
            this.btnOgrenciGirisi.Location = new System.Drawing.Point(59, 53);
            this.btnOgrenciGirisi.Name = "btnOgrenciGirisi";
            this.btnOgrenciGirisi.Size = new System.Drawing.Size(160, 72);
            this.btnOgrenciGirisi.TabIndex = 0;
            this.btnOgrenciGirisi.Text = "ÖğrenciGirişi";
            this.btnOgrenciGirisi.UseVisualStyleBackColor = true;
            this.btnOgrenciGirisi.Click += new System.EventHandler(this.btnOgrenciGirisi_Click);
            // 
            // btnOgretmenGirisi
            // 
            this.btnOgretmenGirisi.Location = new System.Drawing.Point(59, 131);
            this.btnOgretmenGirisi.Name = "btnOgretmenGirisi";
            this.btnOgretmenGirisi.Size = new System.Drawing.Size(160, 75);
            this.btnOgretmenGirisi.TabIndex = 1;
            this.btnOgretmenGirisi.Text = "Öğretmen Girişi";
            this.btnOgretmenGirisi.UseVisualStyleBackColor = true;
            this.btnOgretmenGirisi.Click += new System.EventHandler(this.btnOgretmenGirisi_Click);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 288);
            this.Controls.Add(this.btnOgretmenGirisi);
            this.Controls.Add(this.btnOgrenciGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaGiris";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciGirisi;
        private System.Windows.Forms.Button btnOgretmenGirisi;
    }
}

