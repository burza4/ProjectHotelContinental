namespace Hotel
{
    partial class ucListaKlientow
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
            this.Imie_Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_telefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_pokoju = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.czas_pobytu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imie_Nazwisko,
            this.nr_telefonu,
            this.email,
            this.nr_pokoju,
            this.czas_pobytu});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 221);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Imie_Nazwisko
            // 
            this.Imie_Nazwisko.Text = "Imię i nazwisko";
            this.Imie_Nazwisko.Width = 104;
            // 
            // nr_telefonu
            // 
            this.nr_telefonu.Text = "nr telefonu";
            this.nr_telefonu.Width = 106;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 103;
            // 
            // nr_pokoju
            // 
            this.nr_pokoju.Text = "nr pokoju";
            this.nr_pokoju.Width = 59;
            // 
            // czas_pobytu
            // 
            this.czas_pobytu.Text = "czas pobytu";
            this.czas_pobytu.Width = 70;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.Location = new System.Drawing.Point(166, 289);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(175, 23);
            this.btnAktualizuj.TabIndex = 1;
            this.btnAktualizuj.Text = "Aktualizuj listę";
            this.btnAktualizuj.UseVisualStyleBackColor = true;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // ucListaKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.listView1);
            this.Name = "ucListaKlientow";
            this.Size = new System.Drawing.Size(506, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.ColumnHeader Imie_Nazwisko;
        private System.Windows.Forms.ColumnHeader nr_telefonu;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader nr_pokoju;
        private System.Windows.Forms.ColumnHeader czas_pobytu;
        public System.Windows.Forms.ListView listView1;
    }
}
