﻿using Projekat_HCi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekat_HCi.PagesManager
{
    /// <summary>
    /// Interaction logic for PregledVoznja.xaml
    /// </summary>
    public partial class PregledVoznja : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        private ICollectionView _View;
        public ICollectionView View
        {
            get
            {
                return _View;
            }
            set
            {
                _View = value;
                OnPropertyChanged("View");
            }
        }
        public ObservableCollection<KartaPrikaz> prodate_karte_prikaz
        {
            get;
            set;
        }



        public PregledVoznja()
        {
            InitializeComponent();
            this.DataContext = this;
            prodate_karte_prikaz = new ObservableCollection<KartaPrikaz>((Application.Current.MainWindow as MainWindow).karte_prikaz);
            foreach (KartaPrikaz kp in prodate_karte_prikaz)
                /*
            {
                if (kp.Stanje != "prodata")
                {
                    prodate_karte_prikaz.Remove(kp);
                }
            }
                */
            View = CollectionViewSource.GetDefaultView(prodate_karte_prikaz);
            View.GroupDescriptions.Add(new PropertyGroupDescription(nameof(KartaPrikaz.Id_voznje)));

            foreach (KartaPrikaz kp in prodate_karte_prikaz) { Console.WriteLine(kp.Id_voznje); }


        }
    }
   
}
