using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Voznja : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private Voz voz;
        private List<Karta> rezKarte;
        private List<Karta> prodKarte;
        private VoznaLinija vl;
        private DateTime datum_voznje;

        public Voz Voz
        {
            get
            {
                return voz;
            }
            set
            {
                if (value != voz)
                {
                    voz = value;
                    OnPropertyChanged("Voz");
                }
            }
        }
        public List<Karta> RezKarte
        {
            get
            {
                return rezKarte;
            }
            set
            {
                if (value != rezKarte)
                {
                    rezKarte = value;
                    OnPropertyChanged("RezKarte");
                }
            }
        }

        public List<Karta> ProdKarte
        {
            get
            {
                return prodKarte;
            }
            set
            {
                if (value != prodKarte)
                {
                    prodKarte = value;
                    OnPropertyChanged("ProdKarte");
                }
            }
        }

        public VoznaLinija Vl
        {
            get
            {
                return vl;
            }
            set
            {
                if (value != vl)
                {
                    vl = value;
                    OnPropertyChanged("Vl");
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
