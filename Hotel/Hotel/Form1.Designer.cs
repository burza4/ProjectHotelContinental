namespace Hotel
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ucPokoje1 = new Hotel.ucPokoje();
            this.ucDodajPracownika1 = new Hotel.ucDodajPracownika();
            this.ucDodajKlienta1 = new Hotel.ucDodajKlienta();
            this.ucListaKlientow1 = new Hotel.ucListaKlientow();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(59, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nowy Klient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(59, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lista Klientów";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(59, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 74);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pracownicy";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(59, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 74);
            this.button4.TabIndex = 7;
            this.button4.Text = "Lista pokoi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ucPokoje1
            // 
            this.ucPokoje1.Location = new System.Drawing.Point(162, -10);
            this.ucPokoje1.Name = "ucPokoje1";
            this.ucPokoje1.Size = new System.Drawing.Size(573, 377);
            this.ucPokoje1.TabIndex = 8;
            // 
            // ucDodajPracownika1
            // 
            this.ucDodajPracownika1.Location = new System.Drawing.Point(162, 12);
            this.ucDodajPracownika1.Name = "ucDodajPracownika1";
            this.ucDodajPracownika1.Size = new System.Drawing.Size(626, 380);
            this.ucDodajPracownika1.TabIndex = 5;
            // 
            // ucDodajKlienta1
            // 
            this.ucDodajKlienta1.frm1 = null;
            this.ucDodajKlienta1.Location = new System.Drawing.Point(162, 12);
            this.ucDodajKlienta1.Name = "ucDodajKlienta1";
            this.ucDodajKlienta1.Size = new System.Drawing.Size(626, 438);
            this.ucDodajKlienta1.TabIndex = 2;
            // 
            // ucListaKlientow1
            // 
            this.ucListaKlientow1.frm1 = null;
            this.ucListaKlientow1.Location = new System.Drawing.Point(162, 0);
            this.ucListaKlientow1.Name = "ucListaKlientow1";
            this.ucListaKlientow1.Size = new System.Drawing.Size(626, 438);
            this.ucListaKlientow1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(735, 367);
            this.Controls.Add(this.ucPokoje1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ucDodajPracownika1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ucDodajKlienta1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucListaKlientow1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ucDodajKlienta ucDodajKlienta1;
        private System.Windows.Forms.Button button2;
        private ucListaKlientow ucListaKlientow1;
        private ucDodajPracownika ucDodajPracownika1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private ucPokoje ucPokoje1;
    }
}

