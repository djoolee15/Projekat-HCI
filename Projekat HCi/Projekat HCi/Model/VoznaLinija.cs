using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_HCi.Model
{
    public class VoznaLinija : INotifyPropertyChanged
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
        private string polazak;
        private string dolazak;

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


    }

}
