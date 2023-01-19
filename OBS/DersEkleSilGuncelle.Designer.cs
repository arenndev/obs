namespace OBS
{
    partial class DersEkleSilGuncelle
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
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblDersKod = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblDersId = new System.Windows.Forms.Label();
            this.txtBoxDersAdi = new System.Windows.Forms.TextBox();
            this.txtBoxDersId = new System.Windows.Forms.TextBox();
            this.txtBoxDersKodu = new System.Windows.Forms.TextBox();
            this.txtBoxDersKredisi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblBilgilerEklendiEklenemedi = new System.Windows.Forms.Label();
            this.dataGridDersEkleSilGuncelle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersEkleSilGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdi.Location = new System.Drawing.Point(37, 57);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(89, 20);
            this.lblDersAdi.TabIndex = 0;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // lblDersKod
            // 
            this.lblDersKod.AutoSize = true;
            this.lblDersKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersKod.Location = new System.Drawing.Point(37, 131);
            this.lblDersKod.Name = "lblDersKod";
            this.lblDersKod.Size = new System.Drawing.Size(104, 20);
            this.lblDersKod.TabIndex = 1;
            this.lblDersKod.Text = "Ders Kodu:";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKredi.Location = new System.Drawing.Point(37, 166);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(136, 20);
            this.lblKredi.TabIndex = 2;
            this.lblKredi.Text = "Dersin Kredisi:";
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersId.Location = new System.Drawing.Point(37, 94);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(77, 20);
            this.lblDersId.TabIndex = 3;
            this.lblDersId.Text = "Ders Id:";
            // 
            // txtBoxDersAdi
            // 
            this.txtBoxDersAdi.Location = new System.Drawing.Point(207, 57);
            this.txtBoxDersAdi.Name = "txtBoxDersAdi";
            this.txtBoxDersAdi.Size = new System.Drawing.Size(178, 22);
            this.txtBoxDersAdi.TabIndex = 4;
            // 
            // txtBoxDersId
            // 
            this.txtBoxDersId.Enabled = false;
            this.txtBoxDersId.Location = new System.Drawing.Point(207, 92);
            this.txtBoxDersId.Name = "txtBoxDersId";
            this.txtBoxDersId.Size = new System.Drawing.Size(178, 22);
            this.txtBoxDersId.TabIndex = 5;
            // 
            // txtBoxDersKodu
            // 
            this.txtBoxDersKodu.Location = new System.Drawing.Point(207, 131);
            this.txtBoxDersKodu.Name = "txtBoxDersKodu";
            this.txtBoxDersKodu.Size = new System.Drawing.Size(178, 22);
            this.txtBoxDersKodu.TabIndex = 6;
            // 
            // txtBoxDersKredisi
            // 
            this.txtBoxDersKredisi.Location = new System.Drawing.Point(207, 164);
            this.txtBoxDersKredisi.Name = "txtBoxDersKredisi";
            this.txtBoxDersKredisi.Size = new System.Drawing.Size(178, 22);
            this.txtBoxDersKredisi.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(441, 171);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 60);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(441, 105);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 60);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(441, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(119, 62);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblBilgilerEklendiEklenemedi
            // 
            this.lblBilgilerEklendiEklenemedi.AutoSize = true;
            this.lblBilgilerEklendiEklenemedi.Location = new System.Drawing.Point(207, 254);
            this.lblBilgilerEklendiEklenemedi.Name = "lblBilgilerEklendiEklenemedi";
            this.lblBilgilerEklendiEklenemedi.Size = new System.Drawing.Size(179, 16);
            this.lblBilgilerEklendiEklenemedi.TabIndex = 22;
            this.lblBilgilerEklendiEklenemedi.Text = "lblBilgilerEklendiEklenemedi";
            // 
            // dataGridDersEkleSilGuncelle
            // 
            this.dataGridDersEkleSilGuncelle.AllowUserToAddRows = false;
            this.dataGridDersEkleSilGuncelle.AllowUserToDeleteRows = false;
            this.dataGridDersEkleSilGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDersEkleSilGuncelle.Location = new System.Drawing.Point(40, 298);
            this.dataGridDersEkleSilGuncelle.Name = "dataGridDersEkleSilGuncelle";
            this.dataGridDersEkleSilGuncelle.ReadOnly = true;
            this.dataGridDersEkleSilGuncelle.RowHeadersWidth = 51;
            this.dataGridDersEkleSilGuncelle.RowTemplate.Height = 24;
            this.dataGridDersEkleSilGuncelle.Size = new System.Drawing.Size(496, 168);
            this.dataGridDersEkleSilGuncelle.TabIndex = 23;
            this.dataGridDersEkleSilGuncelle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDersEkleSilGuncelle_CellEnter);
            // 
            // DersEkleSilGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 513);
            this.Controls.Add(this.dataGridDersEkleSilGuncelle);
            this.Controls.Add(this.lblBilgilerEklendiEklenemedi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBoxDersKredisi);
            this.Controls.Add(this.txtBoxDersKodu);
            this.Controls.Add(this.txtBoxDersId);
            this.Controls.Add(this.txtBoxDersAdi);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.lblDersKod);
            this.Controls.Add(this.lblDersAdi);
            this.Name = "DersEkleSilGuncelle";
            this.Text = "DersEkleSilGuncelle";
            this.Load += new System.EventHandler(this.DersEkleSilGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersEkleSilGuncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDersKod;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.TextBox txtBoxDersAdi;
        private System.Windows.Forms.TextBox txtBoxDersId;
        private System.Windows.Forms.TextBox txtBoxDersKodu;
        private System.Windows.Forms.TextBox txtBoxDersKredisi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblBilgilerEklendiEklenemedi;
        private System.Windows.Forms.DataGridView dataGridDersEkleSilGuncelle;
    }
}