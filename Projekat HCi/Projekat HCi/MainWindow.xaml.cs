
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
            this.korVM = new Korisnici
            {
                lista_korisnika = new List<Korisnik>()
                {
                    new Korisnik("Djordje","Vajagic","1234","djole@gmail.com","djole")
                }
            };
            this.DataContext = this.korVM;
            this.korisnici = this.korVM.lista_korisnika;
        }

        public  List<Korisnik> korisnici;
        private Korisnici korVM;

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
