using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class RedVoznjePrikaz : INotifyPropertyChanged
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
        private string dolazak;
        private string polazak;
        private DateTime datum_voznje;


       


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



        public DateTime DatumVoznje
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
                    OnPropertyChanged("DatumVoznje");
                }
            }
        }






    }


}
