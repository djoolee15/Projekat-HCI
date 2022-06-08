using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Voznja
    {
        Voz voz;
        List<Karta> RezKarte;
        List<Karta> ProdKarte;
        VoznaLinija vl;
        DateTime datum_voznje;


        public Voznja() { }

        public Voznja(Voz voz, VoznaLinija vl, DateTime datum_voznje) {
            this.voz = voz;
            this.vl = vl;
            this.datum_voznje = datum_voznje; 
        }
    }
}
