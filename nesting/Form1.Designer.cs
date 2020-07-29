namespace nesting
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSheets = new System.Windows.Forms.GroupBox();
            this.btnAddSheet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbSheets.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSheets
            // 
            this.gbSheets.Controls.Add(this.listView1);
            this.gbSheets.Controls.Add(this.btnAddSheet);
            this.gbSheets.Location = new System.Drawing.Point(12, 12);
            this.gbSheets.Name = "gbSheets";
            this.gbSheets.Size = new System.Drawing.Size(572, 154);
            this.gbSheets.TabIndex = 0;
            this.gbSheets.TabStop = false;
            this.gbSheets.Text = "Fogli Madre";
            // 
            // btnAddSheet
            // 
            this.btnAddSheet.Location = new System.Drawing.Point(491, 122);
            this.btnAddSheet.Name = "btnAddSheet";
            this.btnAddSheet.Size = new System.Drawing.Size(75, 23);
            this.btnAddSheet.TabIndex = 0;
            this.btnAddSheet.Text = "Aggiungi";
            this.btnAddSheet.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 569);
            this.Controls.Add(this.gbSheets);
            this.Name = "frmMain";
            this.Text = "Nesting";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSheets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSheets;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAddSheet;
    }
}

