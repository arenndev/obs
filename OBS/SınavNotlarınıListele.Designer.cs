namespace OBS
{
    partial class SınavNotlarınıListele
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
            this.dataGridSınavNotu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSınavNotu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSınavNotu
            // 
            this.dataGridSınavNotu.AllowUserToAddRows = false;
            this.dataGridSınavNotu.AllowUserToDeleteRows = false;
            this.dataGridSınavNotu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSınavNotu.Location = new System.Drawing.Point(63, 39);
            this.dataGridSınavNotu.Name = "dataGridSınavNotu";
            this.dataGridSınavNotu.ReadOnly = true;
            this.dataGridSınavNotu.RowHeadersWidth = 51;
            this.dataGridSınavNotu.RowTemplate.Height = 24;
            this.dataGridSınavNotu.Size = new System.Drawing.Size(678, 371);
            this.dataGridSınavNotu.TabIndex = 0;
            // 
            // SınavNotlarınıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSınavNotu);
            this.Name = "SınavNotlarınıListele";
            this.Text = "SınavNotlarınıListele";
            this.Load += new System.EventHandler(this.SınavNotlarınıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSınavNotu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSınavNotu;
    }
}