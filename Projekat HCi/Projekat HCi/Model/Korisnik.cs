using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Korisnik
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string lozinka { get; set; }
        public string mejl { get; set; }
        public string korisnickoIme { get; set; }


        public Korisnik() { }

        public Korisnik(string ime, string prezime, string lozinka, string mejl, string korisnickoIme) {
            this.ime = ime;
            this.prezime = prezime; 
            this.lozinka = lozinka;
            this.mejl = mejl;
            this.korisnickoIme = korisnickoIme;
        }
    }
}
