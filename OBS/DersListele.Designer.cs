namespace OBS
{
    partial class DersListele
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
            this.dataGridDersListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDersListele
            // 
            this.dataGridDersListele.AllowUserToAddRows = false;
            this.dataGridDersListele.AllowUserToDeleteRows = false;
            this.dataGridDersListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDersListele.Location = new System.Drawing.Point(61, 46);
            this.dataGridDersListele.Name = "dataGridDersListele";
            this.dataGridDersListele.ReadOnly = true;
            this.dataGridDersListele.RowHeadersWidth = 51;
            this.dataGridDersListele.RowTemplate.Height = 24;
            this.dataGridDersListele.Size = new System.Drawing.Size(690, 340);
            this.dataGridDersListele.TabIndex = 0;
            // 
            // DersListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDersListele);
            this.Name = "DersListele";
            this.Text = "DersListele";
            this.Load += new System.EventHandler(this.DersListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDersListele;
    }
}