
using Projekat_HCi.Model;
using Projekat_HCi.Pages;
using Projekat_HCi.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            VoznaLinija voznalinija2 = new VoznaLinija { Polazak = "novi sad", Dolazak = "nis", Id = 2 };
            VoznaLinija voznalinija3 = new VoznaLinija { Polazak = "beograd", Dolazak = "nis", Id = 3 };
            VoznaLinija voznalinija4 = new VoznaLinija { Polazak = "kraljevo", Dolazak = "novi sad", Id = 4 };
            vozne_linije = new List<VoznaLinija>();
            vozne_linije.Add(voznalinija1);
            vozne_linije.Add(voznalinija2);
            vozne_linije.Add(voznalinija3);
            vozne_linije.Add(voznalinija4);


            Voznja voznja1 = new Voznja { Id = 1, Voz = voz1, Vl = voznalinija1, DatumVoznje = DateTime.Now };  // ovde prepraviti da ne bude datetime now
            Voznja voznja2 = new Voznja { Id = 2, Voz = voz1, Vl = voznalinija2, DatumVoznje = DateTime.Now };
            Voznja voznja3 = new Voznja { Id = 3, Voz = voz2, Vl = voznalinija1, DatumVoznje = DateTime.Now };
            voznje = new List<Voznja>();
            voznje.Add(voznja1);
            voznje.Add(voznja2);
            voznje.Add(voznja3);


            Karta karta1 = new Karta { Id = 1, Korisnik = petar, Voznja = voznja1 , Stanje = "kupljena" , Cena = 300};
            Karta karta2 = new Karta { Id = 2, Korisnik = petar, Voznja = voznja1 , Stanje = "kupljena" , Cena = 300 };
            Karta karta3 = new Karta { Id = 3, Korisnik = petar, Voznja = voznja2 , Stanje = "rezervisana" , Cena = 300 };
            Karta karta4 = new Karta { Id = 4, Korisnik = petar, Voznja = voznja2 , Stanje = "rezervisana", Cena = 300 };
            karte = new List<Karta>();
            karte.Add(karta1);
            karte.Add(karta2);
            karte.Add(karta3); 
            karte.Add(karta4);

            List<string> myList = new List<string>();
            myList.Add("Jun");
            myList.Add("Jul");
            myList.Add("Avgust");
            // add items to the list
            
            
            Random r = new Random();
            karte_prikaz = new List<KartaPrikaz>();


            foreach (Karta karta in karte) {
                KartaPrikaz kp = new KartaPrikaz { Id = karta.Id, Naziv_voza = karta.Voznja.Voz.Naziv, Polazak = karta.Voznja.Vl.Polazak, Dolazak = karta.Voznja.Vl.Dolazak,  Datum_voznje = karta.Voznja.DatumVoznje, Stanje = karta.Stanje, Cena = karta.Cena, Id_voznje = karta.Voznja.Id, KorisnickoImeKupca = karta.Korisnik.KorisnickoIme };
                int index = r.Next(myList.Count);
                string randomString = myList[index];
                kp.Mesec = randomString;
                karte_prikaz.Add(kp);
            }


            red_voznje_prikaz = new List<RedVoznjePrikaz>();
            foreach (Voznja v in voznje)
            {
                RedVoznjePrikaz rv = new RedVoznjePrikaz { Id = v.Id,Naziv_voza = v.Voz.Naziv, Polazak = v.Vl.Polazak, Dolazak = v.Vl.Dolazak, DatumVoznje = v.DatumVoznje};
                red_voznje_prikaz.Add(rv);
            }



            kontroler = new Controller();
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



        public List<KartaPrikaz> karte_prikaz;
        public List<RedVoznjePrikaz> red_voznje_prikaz;
        
        public Korisnik ulogovani_korisnik;

        public Controller kontroler;

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
