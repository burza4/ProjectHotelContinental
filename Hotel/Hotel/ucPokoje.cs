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
    public partial class ucPokoje : UserControl
    {
        public Form1 frm1;
        public ucPokoje()
        {
            InitializeComponent();
        }

        private void btnAktPokoje_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var x in frm1.hotel.lista_pokoi)
            {
                var row = new string[] { x.nr_pokoju, x.cena_za_dobe.ToString(), x.CzyWolny() };
                var a = new ListViewItem(row);
                a.Tag = x;
                listView1.Items.Add(a);
            }
        }
    }
}
