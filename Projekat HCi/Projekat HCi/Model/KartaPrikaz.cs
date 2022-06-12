using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class KartaPrikaz : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private int id;
        private string naziv_voza;
        private string polazak;
        private string dolazak;
        private DateTime datum_voznje;
        private string stanje;
        private string mesec;
        private int cena;
        private int id_voznje;
        private string korisnickoImeKupca;


        public string KorisnickoImeKupca
        {
            get
            {
                return korisnickoImeKupca;
            }
            set
            {
                if (value != korisnickoImeKupca)
                {
                    korisnickoImeKupca = value;
                    OnPropertyChanged("KorisnickoImeKupca");
                }
            }
        }

        public int Id_voznje
        {
            get
            {
                return id_voznje;
            }
            set
            {
                if (value != id_voznje)
                {
                    id_voznje = value;
                    OnPropertyChanged("Id_voznje");
                }
            }
        }


        public int Cena
        {
            get
            {
                return cena;
            }
            set
            {
                if (value != cena)
                {
                    cena = value;
                    OnPropertyChanged("Cena");
                }
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Naziv_voza
        {
            get
            {
                return naziv_voza;
            }
            set
            {
                if (value != naziv_voza)
                {
                    naziv_voza = value;
                    OnPropertyChanged("Naziv_voza");
                }
            }
        }
        public string Polazak
        {
            get
            {
                return polazak;
            }
            set
            {
                if (value != polazak)
                {
                    polazak = value;
                    OnPropertyChanged("Polazak");
                }
            }
        }
        public string Dolazak
        {
            get
            {
                return dolazak;
            }
            set
            {
                if (value != dolazak)
                {
                    dolazak = value;
                    OnPropertyChanged("Dolazak");
                }
            }
        }

        public DateTime Datum_voznje
        {
            get
            {
                return datum_voznje;
            }
            set
            {
                if (value != datum_voznje)
                {
                    datum_voznje = value;
                    OnPropertyChanged("Datum_voznje");
                }
            }
        }

        public string Stanje
        {
            get
            {
                return stanje;
            }
            set
            {
                if (value != stanje)
                {
                    stanje = value;
                    OnPropertyChanged("Stanje");
                }
            }
        }
        public string Mesec
        {
            get
            {
                return mesec;
            }
            set
            {
                if (value != mesec)
                {
                    mesec = value;
                    OnPropertyChanged("Mesec");
                }
            }
        }


    }
}
