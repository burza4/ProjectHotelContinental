using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Pokoj
    {
        public double cena_za_dobe;
        public string nr_pokoju;
        public bool czy_wolny;

        public Pokoj(string nr_pokoju, double cena_za_dobe)
        {
            this.cena_za_dobe = cena_za_dobe;
            this.nr_pokoju = nr_pokoju;
            this.czy_wolny = true;
        }

        public override string ToString()
        {
            return "Nr : " + this.nr_pokoju + " Cena za dobe : " + this.cena_za_dobe;
        }
        public string CzyWolny()
        {
            if (this.czy_wolny == true)
                return "Wolny";
            else
                return "Zajęty";
        }
    }
}
