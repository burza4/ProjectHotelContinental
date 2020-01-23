using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Usluga
    {
        public string nazwa;
        public double cena;
        public Usluga(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public override string ToString()
        {
            return this.nazwa+" Cena : "+this.cena;
        }
    }
}
