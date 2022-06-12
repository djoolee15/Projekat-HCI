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
    /// Interaction logic for RedVoznje.xaml
    /// </summary>
    public partial class RedVoznje : Page, INotifyPropertyChanged
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



        public RedVoznje()
        {
            InitializeComponent();
            DataContext = this;

            List<RedVoznjePrikaz> rv = (Application.Current.MainWindow as MainWindow).red_voznje_prikaz;

            red_voznje_prikaz_str = new ObservableCollection<RedVoznjePrikaz>(rv);




        }


    }  
}
