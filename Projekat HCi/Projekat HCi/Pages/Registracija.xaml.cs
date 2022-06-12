using Projekat_HCi.Model;
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

namespace Projekat_HCi.Pages
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Page
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Click(object sender, RoutedEventArgs e)
        {
            bool pronadjen = false;
            foreach (Korisnik k in (Application.Current.MainWindow as MainWindow).korisnici)
            {
                if (k.KorisnickoIme == KorisnickoIme.Text)
                {
                        pronadjen = true;
                }
            }
            if (pronadjen is true)
            {
                MessageBox.Show("Vec postoji korisnik sa ovim korisnickim imenom!");
                KorisnickoIme.Clear();
                Lozinka.Clear();
            }
            else {
                Korisnik k = new Korisnik { KorisnickoIme = KorisnickoIme.Text, Ime = Ime.Text, Prezime = Prezime.Text, Lozinka = Lozinka.Password.ToString(), Mejl = Email.Text};
                (Application.Current.MainWindow as MainWindow).korisnici.Add(k);
                PocetnaUlogovaniKorisnik logged = new PocetnaUlogovaniKorisnik();
                logged.Show();
            }
        }

    }
}
