using Projekat_HCi.Model;
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

namespace Projekat_HCi.PagesKorisnik
{
    /// <summary>
    /// Interaction logic for KupljeneKarte.xaml
    /// </summary>
    public partial class KupljeneKarte : Page ,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

      

        public ObservableCollection<KartaPrikaz> karte_prikaz
        {
            get;
            set;
        }



        public KupljeneKarte()
        {
            InitializeComponent();
            DataContext = this;

            List<KartaPrikaz> karte = (Application.Current.MainWindow as MainWindow).karte_prikaz;

            karte_prikaz = new ObservableCollection<KartaPrikaz>();
            foreach (KartaPrikaz k in karte) {
                if (k.Stanje == "kupljena") {
                    karte_prikaz.Add(k);
                }
            }
            /*
            foreach (KartaPrikaz k in karte_prikaz)
            {
                Console.WriteLine(k.Id + " " + k.Naziv_voza);
            }
            */



        }
    }
}
