
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
            
        }



        private void Prijava_Click(object sender, RoutedEventArgs e)
        {
            /*
            foreach(Korisnik k in this.DataContext) { 
                if(k.korisnickoIme == KorisnickoIme && k.Lozinka == Lozinka ){
                    PocetnaUlogovaniKorisnik logged = new PocetnaUlogovaniKorisnik();
                    logged.Show();
                }
            }
            */
            PocetnaUlogovaniKorisnik logged = new PocetnaUlogovaniKorisnik();
            logged.Show();
        }
    }
}
