using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class VoznaLinija
    {
        string Polazak;
        string Dolazak;
        public VoznaLinija() { }

        public VoznaLinija(string polazak, string dolazak) {
            this.Dolazak = dolazak;
            this.Polazak = polazak;
        }
    }

}
