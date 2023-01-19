namespace OBS
{
    partial class DevamsızlıkGir
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
            this.lblDersId = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtBoxDersId = new System.Windows.Forms.TextBox();
            this.txtBoxOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtBoxTarih = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridDevamsızlık = new System.Windows.Forms.DataGridView();
            this.txtBoxSınavId = new System.Windows.Forms.TextBox();
            this.lblSınavId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevamsızlık)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersId.Location = new System.Drawing.Point(55, 64);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(77, 20);
            this.lblDersId.TabIndex = 0;
            this.lblDersId.Text = "Ders Id:";
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciNo.Location = new System.Drawing.Point(55, 107);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(167, 20);
            this.lblOgrenciNo.TabIndex = 1;
            this.lblOgrenciNo.Text = "Ogrenci Numarası:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(55, 151);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(58, 20);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtBoxDersId
            // 
            this.txtBoxDersId.Location = new System.Drawing.Point(289, 62);
            this.txtBoxDersId.Name = "txtBoxDersId";
            this.txtBoxDersId.Size = new System.Drawing.Size(150, 22);
            this.txtBoxDersId.TabIndex = 3;
            // 
            // txtBoxOgrenciNo
            // 
            this.txtBoxOgrenciNo.Location = new System.Drawing.Point(289, 105);
            this.txtBoxOgrenciNo.Name = "txtBoxOgrenciNo";
            this.txtBoxOgrenciNo.Size = new System.Drawing.Size(150, 22);
            this.txtBoxOgrenciNo.TabIndex = 4;
            // 
            // txtBoxTarih
            // 
            this.txtBoxTarih.Location = new System.Drawing.Point(289, 151);
            this.txtBoxTarih.Name = "txtBoxTarih";
            this.txtBoxTarih.Size = new System.Drawing.Size(150, 22);
            this.txtBoxTarih.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(503, 62);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 63);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(503, 151);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 63);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridDevamsızlık
            // 
            this.dataGridDevamsızlık.AllowUserToAddRows = false;
            this.dataGridDevamsızlık.AllowUserToDeleteRows = false;
            this.dataGridDevamsızlık.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevamsızlık.Location = new System.Drawing.Point(59, 228);
            this.dataGridDevamsızlık.Name = "dataGridDevamsızlık";
            this.dataGridDevamsızlık.ReadOnly = true;
            this.dataGridDevamsızlık.RowHeadersWidth = 51;
            this.dataGridDevamsızlık.RowTemplate.Height = 24;
            this.dataGridDevamsızlık.Size = new System.Drawing.Size(559, 150);
            this.dataGridDevamsızlık.TabIndex = 8;
            this.dataGridDevamsızlık.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDevamsızlık_CellEnter);
            // 
            // txtBoxSınavId
            // 
            this.txtBoxSınavId.Location = new System.Drawing.Point(289, 192);
            this.txtBoxSınavId.Name = "txtBoxSınavId";
            this.txtBoxSınavId.Size = new System.Drawing.Size(150, 22);
            this.txtBoxSınavId.TabIndex = 9;
            // 
            // lblSınavId
            // 
            this.lblSınavId.AutoSize = true;
            this.lblSınavId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSınavId.Location = new System.Drawing.Point(55, 194);
            this.lblSınavId.Name = "lblSınavId";
            this.lblSınavId.Size = new System.Drawing.Size(82, 20);
            this.lblSınavId.TabIndex = 10;
            this.lblSınavId.Text = "Sınav Id:";
            // 
            // DevamsızlıkGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.lblSınavId);
            this.Controls.Add(this.txtBoxSınavId);
            this.Controls.Add(this.dataGridDevamsızlık);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBoxTarih);
            this.Controls.Add(this.txtBoxOgrenciNo);
            this.Controls.Add(this.txtBoxDersId);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.lblDersId);
            this.Name = "DevamsızlıkGir";
            this.Text = "DevamsızlıkGir";
            this.Load += new System.EventHandler(this.DevamsızlıkGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevamsızlık)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtBoxDersId;
        private System.Windows.Forms.TextBox txtBoxOgrenciNo;
        private System.Windows.Forms.TextBox txtBoxTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridDevamsızlık;
        private System.Windows.Forms.TextBox txtBoxSınavId;
        private System.Windows.Forms.Label lblSınavId;
    }
}