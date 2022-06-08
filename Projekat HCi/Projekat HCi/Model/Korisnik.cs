using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Korisnik : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string name)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }


        private string ime;
        private string prezime;
        private string lozinka;
        private string mejl;
        private string korisnickoIme;

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (value != ime)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value != prezime)
                {
                    prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }
        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }
            set
            {
                if (value != korisnickoIme)
                {
                    korisnickoIme = value;
                    OnPropertyChanged("KorisnickoIme");
                }
            }
        }
        public string Mejl
        {
            get
            {
                return mejl;
            }
            set
            {
                if (value != mejl)
                {
                    mejl = value;
                    OnPropertyChanged("Mejl");
                }
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }
            set
            {
                if (value != lozinka)
                {
                    lozinka = value;
                    OnPropertyChanged("Lozinka");
                }
            }
        }

    }
}
