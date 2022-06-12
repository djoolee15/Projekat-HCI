using Projekat_HCi.PagesKorisnik;
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
using System.Windows.Shapes;

namespace Projekat_HCi
{
    /// <summary>
    /// Interaction logic for PocetnaUlogovaniKorisnik.xaml
    /// </summary>
    public partial class PocetnaUlogovaniKorisnik : Window
    {
        public PocetnaUlogovaniKorisnik()
        {
            InitializeComponent();
            PocetnaKorisnik.Content = new RedVoznje();
        }

        private void RedVoznje_Click(object sender, RoutedEventArgs e)
        {
            PocetnaKorisnik.Content = new RedVoznje();

            RedVoznje.Background = Brushes.Navy;
            RedVoznje.Foreground = Brushes.White;

            VozneLinije.Background = Brushes.White;
            VozneLinije.Foreground = Brushes.Black;
            Mreza.Background = Brushes.White;
            Mreza.Foreground = Brushes.Black;
            RezKarte.Background = Brushes.White;
            RezKarte.Foreground = Brushes.Black;
            KupljeneKarte.Background = Brushes.White;
            KupljeneKarte.Foreground = Brushes.Black;
        }

        private void VozneLinije_Click(object sender, RoutedEventArgs e)
        {
            PocetnaKorisnik.Content = new VozneLinije();

            VozneLinije.Background = Brushes.Navy;
            VozneLinije.Foreground = Brushes.White;

            RedVoznje.Background = Brushes.White;
            RedVoznje.Foreground = Brushes.Black;
            Mreza.Background = Brushes.White;
            Mreza.Foreground = Brushes.Black;
            RezKarte.Background = Brushes.White;
            RezKarte.Foreground = Brushes.Black;
            KupljeneKarte.Background = Brushes.White;
            KupljeneKarte.Foreground = Brushes.Black;
        }

        private void Mreza_Click(object sender, RoutedEventArgs e)
        {
            PocetnaKorisnik.Content = new VozneLinijeMreza();

            Mreza.Background = Brushes.Navy;
            Mreza.Foreground = Brushes.White;
            VozneLinije.Background = Brushes.White;
            VozneLinije.Foreground = Brushes.Black;
            RedVoznje.Background = Brushes.White;
            RedVoznje.Foreground = Brushes.Black;
            RezKarte.Background = Brushes.White;
            RezKarte.Foreground = Brushes.Black;
            KupljeneKarte.Background = Brushes.White;
            KupljeneKarte.Foreground = Brushes.Black;
        }

        private void KupljeneKarte_Click(object sender, RoutedEventArgs e)
        {
            PocetnaKorisnik.Content = new KupljeneKarte();

            KupljeneKarte.Background = Brushes.Navy;
            KupljeneKarte.Foreground = Brushes.White;

            VozneLinije.Background = Brushes.White;
            VozneLinije.Foreground = Brushes.Black;
            Mreza.Background = Brushes.White;
            Mreza.Foreground = Brushes.Black;
            RezKarte.Background = Brushes.White;
            RezKarte.Foreground = Brushes.Black;
            RedVoznje.Background = Brushes.White;
            RedVoznje.Foreground = Brushes.Black;
        }

        private void RezKarte_Click(object sender, RoutedEventArgs e)
        {
            PocetnaKorisnik.Content = new RezervisaneKarte();

            RezKarte.Background = Brushes.Navy;
            RezKarte.Foreground = Brushes.White;
            VozneLinije.Background = Brushes.White;
            VozneLinije.Foreground = Brushes.Black;
            Mreza.Background = Brushes.White;
            Mreza.Foreground = Brushes.Black;
            RedVoznje.Background = Brushes.White;
            RedVoznje.Foreground = Brushes.Black;
            KupljeneKarte.Background = Brushes.White;
            KupljeneKarte.Foreground = Brushes.Black;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
