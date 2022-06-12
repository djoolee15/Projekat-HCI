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
    /// Interaction logic for VozneLinije.xaml
    /// </summary>
    public partial class VozneLinije : Page , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    

        public ObservableCollection<VoznaLinija> vozne_linije_prikaz
        {
            get;
            set;
        }


        public VozneLinije()
        {
           
            InitializeComponent();
            DataContext = this;
            List<VoznaLinija> linije = (Application.Current.MainWindow as MainWindow).vozne_linije;
            vozne_linije_prikaz = new ObservableCollection<VoznaLinija>(linije);
            //ObservableCollection<string> vozovi_prikaz = new ObservableCollection<string>();
            /*
            foreach (VoznaLinija linija in linije)
            {
                //vozovi_prikaz.Add(voz.naziv);
                Console.WriteLine(linija.Polazak + " " + linija.Dolazak);
            }
            vozne_linije_prikaz = new ObservableCollection<VoznaLinija>(linije);

            foreach (VoznaLinija linija in vozne_linije_prikaz)
            {
                //vozovi_prikaz.Add(voz.naziv);
                Console.WriteLine(linija.Polazak + " " + linija.Dolazak);
            }
            */
        }


    

    }
}
