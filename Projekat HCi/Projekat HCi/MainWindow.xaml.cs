
using Projekat_HCi.Model;
using Projekat_HCi.Pages;
using Projekat_HCi.ViewModel;
using System;
using System.Collections.Generic;
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

namespace Projekat_HCi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Login();


            Korisnik djole = new Korisnik { Ime = "Djordje", Prezime = "Vajagic", Lozinka = "1234", Mejl = "djole@gmail.com", KorisnickoIme = "djole" };
            Korisnik petar = new Korisnik { Ime = "petar", Prezime = "petrovic", Lozinka = "1234", Mejl = "petar@gmail.com", KorisnickoIme = "petar" };
            korisnici = new List<Korisnik>();
            korisnici.Add(djole);
            korisnici.Add(petar);

            Voz voz1 = new Voz { Broj_mesta = 30, Broj_vagona = 5, Naziv = "Super Brzi Voz", Id = 1 };
            Voz voz2 = new Voz { Broj_mesta = 20, Broj_vagona = 4, Naziv = "Ne Tako Brzi Voz", Id = 2 };
            vozovi = new List<Voz>();
            vozovi.Add(voz1);
            vozovi.Add(voz2);

            VoznaLinija voznalinija1 = new VoznaLinija { Polazak = "novi sad", Dolazak = "beograd", Id = 1 };
            VoznaLinija voznalinija2 = new VoznaLinija { Polazak = "novi sad", Dolazak = "nis", Id = 2};
            vozne_linije = new List<VoznaLinija>();
            vozne_linije.Add(voznalinija1);
            vozne_linije.Add(voznalinija2);

            Voznja voznja1 = new Voznja {Voz = voz1,Vl =  voznalinija1,  DatumVoznje = DateTime.Now };  // ovde prepraviti da ne bude datetime now
            voznje = new List<Voznja>();
            voznje.Add(voznja1);
            
            Karta karta1 = new Karta(petar, voznja1);

            /*this._ViewModel = new Zeleznica
            {
                korisnici = new List<Korisnik>()
                {
                    djole,petar
                },
                vozovi = new List<Voz>() { 
                    voz1
                },
                vozne_linije = new List<VoznaLinija>() { 
                    voznalinija1
                },
                voznje = new List<Voznja>()
                {
                    voznja1
                },
                karte = new List<Karta> { 
                    karta1
                }
            };
            this.DataContext = this._ViewModel;
            //this.korisnici = this.korVM.lista_korisnika;  ovo u sustini nije radilo nista jer je prazno
            */
        }
        public List<Voz> vozovi;
        public List<Korisnik> korisnici;
        public List<VoznaLinija> vozne_linije;
        public List<Voznja> voznje;
        public List<Karta> karte;
        
        //public Zeleznica _ViewModel;

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Main.Content = new Login();
            PrijavaDugme.Background = Brushes.Navy;
            PrijavaDugme.Foreground = Brushes.White;
            RegistracijaDugme.Background = Brushes.White;
            RegistracijaDugme.Foreground = Brushes.Black;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Registracija();
            RegistracijaDugme.Background = Brushes.Navy;
            RegistracijaDugme.Foreground = Brushes.White;
            PrijavaDugme.Background = Brushes.White;
            PrijavaDugme.Foreground = Brushes.Black;
        }
    }
}
