using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    interface IRezerwacja
    {
        void Rezerwuj(Pokoj pokoj, decimal ileDni);
        void DodajUslugi(List<Usluga> uslugi);
    }
}
