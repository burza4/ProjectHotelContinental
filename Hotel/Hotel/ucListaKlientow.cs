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
    public partial class ucListaKlientow : UserControl
    {
        public Form1 frm1 { get; set; }
        public ucListaKlientow()
        {
            InitializeComponent();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(var x in frm1.hotel.lista_klientow)
            {
                var row = new string[] { x.imie + " " + x.nazwisko, x.numer_telefonu, x.email, x.pokoj.nr_pokoju,x.liczba_dni.ToString()};
                var a = new ListViewItem(row);
                a.Tag = x;
                listView1.Items.Add(a);
            }
        }
    }
}
