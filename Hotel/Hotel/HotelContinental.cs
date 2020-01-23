using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public class HotelContinental
    {
        public List<Pracownik> lista_pracownikow;
        public List<Klient> lista_klientow;
        public List<Pokoj> lista_pokoi;
        public List<Usluga> lista_uslug;
        public HotelContinental()
        {
            this.lista_pracownikow = new List<Pracownik>();
            this.lista_klientow= new List<Klient>();
            this.lista_pokoi = new List<Pokoj>();
            this.lista_uslug= new List<Usluga>();
        }
        public static void EmptyBox(ComboBox x)
        {

            if (x.SelectedItem == null)
                throw new ExceptionEmptyBox();

        }
    }
}
