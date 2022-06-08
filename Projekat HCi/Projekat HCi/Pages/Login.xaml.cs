
using Projekat_HCi.Model;
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

namespace Projekat_HCi.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            var parentWindow = this.Parent as Window;
            //this.DataContext = parentWindow.DataContext;
            
            

    }
        


        private void Prijava_Click(object sender, RoutedEventArgs e)
        {
            bool pronadjen = false;
            foreach (Korisnik k in (Application.Current.MainWindow as MainWindow).korisnici)
            {
                if (k.KorisnickoIme == KorisnickoIme.Text && k.Lozinka == Lozinka.Password.ToString())
                {
                    if (k.KorisnickoIme == "djole") {
                        PocetnaUlogovaniMenadzer logged = new PocetnaUlogovaniMenadzer();
                        logged.Show();
                        pronadjen = true;
                    }
                    else { 
                    PocetnaUlogovaniKorisnik logged = new PocetnaUlogovaniKorisnik();
                    logged.Show();
                    pronadjen = true;
                    }
                }
            }
            if(pronadjen is false){
                MessageBox.Show("Ne postoji korisnik sa ovim kredencijalima! Pokusajte ponovo!");
                KorisnickoIme.Clear();
                Lozinka.Clear();    
            }
            
            
        }
    }
}
