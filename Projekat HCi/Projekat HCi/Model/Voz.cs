using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class Voz : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        private int _id;
        private string _naziv;
        private int _broj_mesta;
        private int _broj_vagona;
        private enum prtljag {bez, rucni, kofer };

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public int Broj_mesta
        {
            get
            {
                return _broj_mesta;
            }
            set
            {
                if (value != _broj_mesta)
                {
                    _broj_mesta = value;
                    OnPropertyChanged("Broj_mesta");
                }
            }
        }


        public int Broj_vagona
        {
            get
            {
                return _broj_vagona;
            }
            set
            {
                if (value != _broj_vagona)
                {
                    _broj_vagona = value;
                    OnPropertyChanged("Broj_vagona");
                }
            }
        }

        public string Naziv
        {
            get
            {
                return _naziv;
            }
            set
            {
                if (value != _naziv)
                {
                    _naziv = value;
                    OnPropertyChanged("Naziv");
                }
            }
        }


    }
}
