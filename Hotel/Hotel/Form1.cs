using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public HotelContinental hotel;
        public Form1()
        {
            InitializeComponent();
            hotel = new HotelContinental();
            hotel.lista_pracownikow.Add(new Pracownik("Charon", "Reddick","9995553333","123@xd.pl", Pracownik.Stanowisko.Recepcjonista));
            hotel.lista_pracownikow.Add(new Pracownik("John", "Wick","9995553333", "123@xd.pl", Pracownik.Stanowisko.Sprzątaczka));
            hotel.lista_uslug.Add(new Usluga("Open Bar", 66.12));
            hotel.lista_uslug.Add(new Usluga("Basen", 10.50));
            hotel.lista_uslug.Add(new Usluga("Siłownia", 30.55));
            hotel.lista_uslug.Add(new Usluga("Sejf", 60.01));
            hotel.lista_uslug.Add(new Usluga("Budzenie", 6.77));
            hotel.lista_pokoi.Add(new Pokoj("1", 50.01));
            hotel.lista_pokoi.Add(new Pokoj("2", 1140.99));
            hotel.lista_pokoi.Add(new Pokoj("3", 32.99));
            hotel.lista_pokoi.Add(new Pokoj("4", 41.99));
            hotel.lista_pokoi.Add(new Pokoj("5", 31.99));
            hotel.lista_pokoi.Add(new Pokoj("6", 30.99));
            hotel.lista_klientow.Add(new Klient("Arnold", "Hochland", "333-441-343", "olympia@terminator.kaboom"));
            hotel.lista_klientow[0].Rezerwuj(hotel.lista_pokoi[1], 5);
        }

        override protected void OnLoad(EventArgs e)
        {
            ucDodajKlienta1.frm1 = this;
            ucListaKlientow1.frm1 = this;
            ucDodajPracownika1.frm1 = this;
            ucPokoje1.frm1 = this;
            foreach (var x in this.hotel.lista_pokoi)
            {
                if(x.czy_wolny==true)
                    ucDodajKlienta1.comboBox1.Items.Add(x);
            }
                
            foreach (var x in this.hotel.lista_uslug)
                ucDodajKlienta1.checkedListBox1.Items.Add(x);
            foreach (var x in Enum.GetValues(typeof(Pracownik.Stanowisko)))
            {
                    ucDodajPracownika1.comboBox1.Items.Add(x);
            }

            foreach (var x in this.hotel.lista_pracownikow)
            {
                var row = new string[] { x.imie + " " + x.nazwisko, x.numer_telefonu, x.email,(x.stanowisko).ToString() };
                var a = new ListViewItem(row);
                a.Tag = x;
                ucDodajPracownika1.listView1.Items.Add(a);
            }

            foreach (var x in this.hotel.lista_pokoi)
            {
                var row = new string[] { x.nr_pokoju, x.cena_za_dobe.ToString(),x.CzyWolny() };
                var a = new ListViewItem(row);
                a.Tag = x;
                ucPokoje1.listView1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucDodajKlienta1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucListaKlientow1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ucDodajPracownika1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucPokoje1.BringToFront();
        }

        
    }
}
