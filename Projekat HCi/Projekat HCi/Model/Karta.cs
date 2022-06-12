using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Karta : INotifyPropertyChanged
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
        private Korisnik korisnik;
        private Voznja voznja;
        private string stanje;
        private int cena;

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
        public Korisnik Korisnik
        {
            get
            {
                return korisnik;
            }
            set
            {
                if (value != korisnik)
                {
                    korisnik = value;
                    OnPropertyChanged("Korisnik");
                }
            }
        }
        public Voznja Voznja
        {
            get
            {
                return voznja;
            }
            set
            {
                if (value != voznja)
                {
                    voznja = value;
                    OnPropertyChanged("Voznja");
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




    }

    
}
