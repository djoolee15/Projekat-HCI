using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Karta
    {
        Korisnik korisnik;
        Voznja voznja;
        stanje stanje;


        public Karta() { }

        public Karta(Korisnik korisnik, Voznja voznja)
        {
            this.korisnik = korisnik;
            this.voznja = voznja;
            this.stanje = stanje.rezervisana;
        }
    }

    enum stanje { prodata, rezervisana, slobodna };
}
