using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ucDodajPracownika : UserControl
    {
        public Form1 frm1;
        public ucDodajPracownika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HotelContinental.EmptyBox(comboBox1);
                frm1.hotel.lista_pracownikow.Add(new Pracownik(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, (Pracownik.Stanowisko)comboBox1.SelectedItem));
                listView1.Items.Clear();
                foreach (var x in frm1.hotel.lista_pracownikow)
                {
                    var row = new string[] { x.imie + " " + x.nazwisko, x.numer_telefonu, x.email, (x.stanowisko).ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = x;
                    listView1.Items.Add(a);
                }
            }
            catch (ExceptionEmptyBox)
            {
                MessageBox.Show("Proszę wybrać stanowisko");
            }
        }
    }
}
