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

namespace Projekat_HCi.PagesManager
{
    /// <summary>
    /// Interaction logic for IzmenaVozneLinije.xaml
    /// </summary>
    public partial class IzmenaVozneLinije : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        public ObservableCollection<VoznaLinija> linije_prikaz
        {
            get;
            set;
        }

        public IzmenaVozneLinije()
        {

            InitializeComponent();
            this.DataContext = this;





            List<VoznaLinija> linije = (Application.Current.MainWindow as MainWindow).vozne_linije;
            //ObservableCollection<string> vozovi_prikaz = new ObservableCollection<string>();
            /*
            foreach (VoznaLinija linija in linije)
            {
                //vozovi_prikaz.Add(voz.naziv);
                Console.WriteLine(linija.Polazak + " " + linija.Dolazak);
            }
            */
            linije_prikaz = new ObservableCollection<VoznaLinija>(linije);



            //cmbColors.ItemsSource = vozovi_prikaz;



            //comboVozovi.ItemsSource = vozovi;

            //comboVozovi.DisplayMemberPath = "naziv";
            //comboVozovi.SelectedValuePath = "id";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dgrMain.SelectedItem;
            if (selectedItem != null)
            {
                VoznaLinija v = (VoznaLinija)selectedItem;
                linije_prikaz.Remove((VoznaLinija)selectedItem);
                foreach (VoznaLinija vl in (Application.Current.MainWindow as MainWindow).vozne_linije)
                {
                    if (v.Id == vl.Id)
                    {
                        (Application.Current.MainWindow as MainWindow).vozne_linije.Remove(vl);
                        (Application.Current.MainWindow as MainWindow).kontroler.brisanjeVozneLinije(vl);
                        break;
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool pronadjen = false;
            int id = int.Parse(id_1.Text);
            foreach (VoznaLinija v in linije_prikaz)
            {
                if (v.Id == id)
                {
                    pronadjen = true;
                    break; 
                }
            }
            if (pronadjen is true)
            {
                MessageBox.Show("Postoji vozna linija sa ovim indexom!");
            }
            else
            {

                string polazak = br_m.Text;
                string dolazak = br_v.Text;


                VoznaLinija linija1 = new VoznaLinija { Dolazak = dolazak, Polazak = polazak, Id = id };
                linije_prikaz.Add(linija1);
                (Application.Current.MainWindow as MainWindow).vozne_linije.Add(linija1 as VoznaLinija);
                this.InitializeComponent();

            }
            /*
    private DelegateCommand<Voz> _deleteCommand;
    public DelegateCommand<Voz> DeleteCommand =>
    _deleteCommand ?? (_deleteCommand = new DelegateCommand<Voz>(ExecuteCommandName));

    void ExecuteCommandName(Voz parameter) { 
    vozovi_prikaz.Remove(parameter);
    }


    <DataGridTemplateColumn.CellTemplate>
          <DataTemplate>
              <StackPanel Orientation="Horizontal">
                  <Button Command="{Binding DataContext.DeleteCommand, ElementName = izmena_vo}" CommandParameter="{Binding}">Izbrisi</Button>
              </StackPanel>
          </DataTemplate>
      </DataGridTemplateColumn.CellTemplate>



    */

        }
    }
}
