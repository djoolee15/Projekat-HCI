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
    /// Interaction logic for Kupovina.xaml
    /// </summary>
    public partial class Kupovina : Page , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        public ObservableCollection<RedVoznjePrikaz> red_voznje_prikaz_str
        {
            get;
            set;
        }
        public Kupovina()
        {
            InitializeComponent();
            DataContext = this;

            List<RedVoznjePrikaz> rv = (Application.Current.MainWindow as MainWindow).red_voznje_prikaz;

            red_voznje_prikaz_str = new ObservableCollection<RedVoznjePrikaz>(rv);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dgrMain.SelectedItem;
            if (selectedItem != null)
            {
                RedVoznjePrikaz rvp = (RedVoznjePrikaz)selectedItem;
                foreach (Voznja v in (Application.Current.MainWindow as MainWindow).voznje)
                {
                    if (v.Id == rvp.Id) {
                        int id = (Application.Current.MainWindow as MainWindow).karte.Count;
                        Karta karta1 = new Karta { Id = 1 + id, Korisnik = (Application.Current.MainWindow as MainWindow).ulogovani_korisnik, Voznja = v, Stanje = "rezervisana", Cena = 300 };
                        (Application.Current.MainWindow as MainWindow).karte.Add(karta1);
                        KartaPrikaz kp = new KartaPrikaz { Id = karta1.Id, Naziv_voza = karta1.Voznja.Voz.Naziv, Polazak = karta1.Voznja.Vl.Polazak, Dolazak = karta1.Voznja.Vl.Dolazak, Datum_voznje = karta1.Voznja.DatumVoznje, Stanje = karta1.Stanje, Cena = karta1.Cena, Id_voznje = karta1.Voznja.Id, KorisnickoImeKupca = karta1.Korisnik.KorisnickoIme };

                        (Application.Current.MainWindow as MainWindow).karte_prikaz.Add(kp);
                    }
                }
            }
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedItem = dgrMain.SelectedItem;
            if (selectedItem != null)
            {
                RedVoznjePrikaz rvp = (RedVoznjePrikaz)selectedItem;
                foreach (Voznja v in (Application.Current.MainWindow as MainWindow).voznje)
                {
                    if (v.Id == rvp.Id)
                    {
                        int id = (Application.Current.MainWindow as MainWindow).karte.Count;
                        Karta karta1 = new Karta { Id = id +  1, Korisnik = (Application.Current.MainWindow as MainWindow).ulogovani_korisnik, Voznja = v, Stanje = "kupljena", Cena = 300 };
                        (Application.Current.MainWindow as MainWindow).karte.Add(karta1);
                        KartaPrikaz kp = new KartaPrikaz { Id = karta1.Id, Naziv_voza = karta1.Voznja.Voz.Naziv, Polazak = karta1.Voznja.Vl.Polazak, Dolazak = karta1.Voznja.Vl.Dolazak, Datum_voznje = karta1.Voznja.DatumVoznje, Stanje = karta1.Stanje, Cena = karta1.Cena, Id_voznje = karta1.Voznja.Id, KorisnickoImeKupca = karta1.Korisnik.KorisnickoIme };

                        (Application.Current.MainWindow as MainWindow).karte_prikaz.Add(kp);
                    }
                }
            }
        }
    }
}
