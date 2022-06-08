using Projekat_HCi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.ViewModel
{
    public class Zeleznica
    {
        public List<Voz> vozovi {get; set;}
        public List<Voznja> voznje { get; set; }
        public List<VoznaLinija> vozne_linije { get; set; }
        public List<Karta> karte { get; set; }
        public List<Korisnik> korisnici { get; set; }
    }
}
