using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public abstract class Osoba
    {
        public string imie;
        public string nazwisko;
        public string numer_telefonu;
        public string email;
        protected Osoba(string imie, string nazwisko, string nr, string email)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.numer_telefonu = nr;
        }
    }
    public class Klient : Osoba, IRezerwacja
    {

        List<Usluga> lista_zakupionych_uslug;
        public Pokoj pokoj;
        public decimal liczba_dni;
        public Klient(string imie, string nazwisko, string nr, string email  ) : base(imie, nazwisko, nr, email)
        {
            this.lista_zakupionych_uslug = new List<Usluga>();
           

        }

        public void Rezerwuj(Pokoj pokoj, decimal ileDni)
        {
            this.pokoj = pokoj;
            this.pokoj.czy_wolny = false;
            this.liczba_dni = ileDni;

        }

        public void DodajUslugi(List<Usluga> uslugi)
        {
            this.lista_zakupionych_uslug.AddRange(uslugi);
        }
        public string Paragon()
        {
            string paragon = "PARAGON\n" + DateTime.Now.ToString() +"\n\n";

            double cena = 0;
            double cena_pokoj = ((double)this.liczba_dni * this.pokoj.cena_za_dobe);
            paragon += "Pokój nr " + this.pokoj.nr_pokoju+"\nLiczba dni: "+this.liczba_dni+"\nCena za pokój: " + cena_pokoj;
            foreach(var x in this.lista_zakupionych_uslug)
            {
                cena += x.cena;
                paragon += "\n"+ x.nazwa + " " + x.cena + "zł";
            }
            paragon += "\n\nSuma: " + (cena + cena_pokoj)+" zł";
            return paragon;
        }
    }
    public class Pracownik : Osoba
    {
        public enum Stanowisko { Recepcjonista, Sprzątaczka };
        public Stanowisko stanowisko;

        public Pracownik(string imie, string nazwisko, string nr, string email, Stanowisko st) : base(imie, nazwisko, nr, email)
        {
            this.stanowisko = st;
        }
    }

}
