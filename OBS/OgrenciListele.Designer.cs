namespace OBS
{
    partial class OgrenciListele
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
            this.dataGridOgrenciListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenciListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOgrenciListe
            // 
            this.dataGridOgrenciListe.AllowUserToAddRows = false;
            this.dataGridOgrenciListe.AllowUserToDeleteRows = false;
            this.dataGridOgrenciListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgrenciListe.Location = new System.Drawing.Point(44, 55);
            this.dataGridOgrenciListe.Name = "dataGridOgrenciListe";
            this.dataGridOgrenciListe.ReadOnly = true;
            this.dataGridOgrenciListe.RowHeadersWidth = 51;
            this.dataGridOgrenciListe.RowTemplate.Height = 24;
            this.dataGridOgrenciListe.Size = new System.Drawing.Size(710, 339);
            this.dataGridOgrenciListe.TabIndex = 0;
            // 
            // OgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridOgrenciListe);
            this.Name = "OgrenciListele";
            this.Text = "OgrenciListelecs";
            this.Load += new System.EventHandler(this.OgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenciListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOgrenciListe;
    }
}