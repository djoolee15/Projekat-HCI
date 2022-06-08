using Projekat_HCi.PagesManager;
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
    /// Interaction logic for PocetnaUlogovaniMenadzer.xaml
    /// </summary>
    public partial class PocetnaUlogovaniMenadzer : Window
    {
        public PocetnaUlogovaniMenadzer()
        {
            InitializeComponent();
        }

        private void iredavoznje_Click(object sender, RoutedEventArgs e)
        {
            PocetnaMenadzer.Content = new IzmenaRedVoznje();

            iredavoznje.Background = Brushes.Navy;
            iredavoznje.Foreground = Brushes.White;

            ivoznihlinija.Background = Brushes.White;
            ivoznihlinija.Foreground = Brushes.Black;
            ivozova.Background = Brushes.White;
            ivozova.Foreground = Brushes.Black;
            ppmesec.Background = Brushes.White;
            ppmesec.Foreground = Brushes.Black;
            ppvoznja.Background = Brushes.White;
            ppvoznja.Foreground = Brushes.Black;
        }

        private void ivoznihlinija_Click(object sender, RoutedEventArgs e)
        {
            PocetnaMenadzer.Content = new IzmenaVozneLinije();

            ivoznihlinija.Background = Brushes.Navy;
            ivoznihlinija.Foreground = Brushes.White;

            iredavoznje.Background = Brushes.White;
            iredavoznje.Foreground = Brushes.Black;
            ivozova.Background = Brushes.White;
            ivozova.Foreground = Brushes.Black;
            ppmesec.Background = Brushes.White;
            ppmesec.Foreground = Brushes.Black;
            ppvoznja.Background = Brushes.White;
            ppvoznja.Foreground = Brushes.Black;
        }

        private void ivozova_Click(object sender, RoutedEventArgs e)
        {
            PocetnaMenadzer.Content = new IzmenaVoz();

            ivozova.Background = Brushes.Navy;
            ivozova.Foreground = Brushes.White;

            ivoznihlinija.Background = Brushes.White;
            ivoznihlinija.Foreground = Brushes.Black;
            iredavoznje.Background = Brushes.White;
            iredavoznje.Foreground = Brushes.Black;
            ppmesec.Background = Brushes.White;
            ppmesec.Foreground = Brushes.Black;
            ppvoznja.Background = Brushes.White;
            ppvoznja.Foreground = Brushes.Black;
        }

        private void ppmesec_Click(object sender, RoutedEventArgs e)
        {
            PocetnaMenadzer.Content = new PregledMesec();

            ppmesec.Background = Brushes.Navy;
            ppmesec.Foreground = Brushes.White;

            ivoznihlinija.Background = Brushes.White;
            ivoznihlinija.Foreground = Brushes.Black;
            ivozova.Background = Brushes.White;
            ivozova.Foreground = Brushes.Black;
            iredavoznje.Background = Brushes.White;
            iredavoznje.Foreground = Brushes.Black;
            ppvoznja.Background = Brushes.White;
            ppvoznja.Foreground = Brushes.Black;
        }

        private void ppvoznja_Click(object sender, RoutedEventArgs e)
        {
            PocetnaMenadzer.Content = new PregledVoznja();

            ppvoznja.Background = Brushes.Navy;
            ppvoznja.Foreground = Brushes.White;

            ivoznihlinija.Background = Brushes.White;
            ivoznihlinija.Foreground = Brushes.Black;
            ivozova.Background = Brushes.White;
            ivozova.Foreground = Brushes.Black;
            ppmesec.Background = Brushes.White;
            ppmesec.Foreground = Brushes.Black;
            iredavoznje.Background = Brushes.White;
            iredavoznje.Foreground = Brushes.Black;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    

}
