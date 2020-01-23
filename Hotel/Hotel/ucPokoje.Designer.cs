namespace Hotel
{
    partial class ucPokoje
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAktPokoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 223);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr pokoju";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cena za dobe";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dostępność";
            // 
            // btnAktPokoje
            // 
            this.btnAktPokoje.BackColor = System.Drawing.Color.Gold;
            this.btnAktPokoje.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnAktPokoje.Location = new System.Drawing.Point(117, 285);
            this.btnAktPokoje.Name = "btnAktPokoje";
            this.btnAktPokoje.Size = new System.Drawing.Size(159, 23);
            this.btnAktPokoje.TabIndex = 1;
            this.btnAktPokoje.Text = "Aktualizuj listę pokoi";
            this.btnAktPokoje.UseVisualStyleBackColor = false;
            this.btnAktPokoje.Click += new System.EventHandler(this.btnAktPokoje_Click);
            // 
            // ucPokoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAktPokoje);
            this.Controls.Add(this.listView1);
            this.Name = "ucPokoje";
            this.Size = new System.Drawing.Size(403, 336);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAktPokoje;
    }
}
