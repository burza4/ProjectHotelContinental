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
    public partial class ucDodajKlienta : UserControl
    {
        public Form1 frm1 { get; set; }
        List<Usluga> tmp = new List<Usluga>();
        public ucDodajKlienta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Usluga x in checkedListBox1.CheckedItems)
                tmp.Add(x);
            try
            {
                HotelContinental.EmptyBox(comboBox1);
                RoomBooked(comboBox1.SelectedItem as Pokoj);
                Klient k = new Klient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                frm1.hotel.lista_klientow.Add(k);
                k.Rezerwuj((Pokoj)comboBox1.SelectedItem, numericUpDown1.Value);
                k.DodajUslugi(tmp);

            }
            catch(ExceptionEmptyBox)
            {
                MessageBox.Show("Proszę wybrać pokój");
            }

            catch (ExceptionRoomBooked)
            {
                MessageBox.Show("Pokój zajęty. Proszę wybrać inny.");
            }
        }
        public static void RoomBooked(Pokoj room)
        {

            if (room.czy_wolny == false)
                throw new ExceptionRoomBooked();

        }
    }
}
