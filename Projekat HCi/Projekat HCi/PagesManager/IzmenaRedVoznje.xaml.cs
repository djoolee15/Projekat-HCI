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
    /// Interaction logic for IzmenaRedVoznje.xaml
    /// </summary>
    public partial class IzmenaRedVoznje : Page ,INotifyPropertyChanged
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

        public ObservableCollection<Voz> voz_prikaz
        {
            get;
            set;
        }
        public ObservableCollection<VoznaLinija> linija_prikaz
        {
            get;
            set;
        }


        public IzmenaRedVoznje()
        {

            InitializeComponent();
            this.DataContext = this;
            datumBx.Text = "6/14/2022 12:40:22 PM";
            List<RedVoznjePrikaz> rv = (Application.Current.MainWindow as MainWindow).red_voznje_prikaz;

            red_voznje_prikaz_str = new ObservableCollection<RedVoznjePrikaz>(rv);

            CmbVoz.ItemsSource = ((Application.Current.MainWindow as MainWindow).vozovi);
            cmbVoznaLinija.ItemsSource = ((Application.Current.MainWindow as MainWindow).vozne_linije);

            //cmbColors.ItemsSource = vozovi_prikaz;



            //comboVozovi.ItemsSource = vozovi;

            //comboVozovi.DisplayMemberPath = "naziv";
            //comboVozovi.SelectedValuePath = "id";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            foreach (Karta k in (Application.Current.MainWindow as MainWindow).karte) { 
                Console.Write(k.Id);
            }


            var selectedItem = dgrMain.SelectedItem;
            if (selectedItem != null)
            {
                RedVoznjePrikaz rvp = (RedVoznjePrikaz)selectedItem;
                red_voznje_prikaz_str.Remove((RedVoznjePrikaz)selectedItem);
                (Application.Current.MainWindow as MainWindow).red_voznje_prikaz.Remove((RedVoznjePrikaz)selectedItem);
                foreach (Voznja v in (Application.Current.MainWindow as MainWindow).voznje)
                {
                    if(v.Id == rvp.Id ){
                       
                        (Application.Current.MainWindow as MainWindow).red_voznje_prikaz.Remove(rvp);
                        (Application.Current.MainWindow as MainWindow).kontroler.brisanjeRedaVoznje(rvp);
                        break;
                    }
                }
                //(Application.Current.MainWindow as MainWindow).voznje.Remove((Voznja)selectedItem);
                foreach (Karta k in (Application.Current.MainWindow as MainWindow).karte)
                { 
                Console.Write(k.Id);
                }
                //dgrMain.Items.Remove(selectedItem);
            }
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            /*


            DateTime vreme_voznje = DateTime.ParseExact(br_m.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);


            Voznja voznja = new Voznja{};
            redovi_voznje.Add(voznja);
            (Application.Current.MainWindow as MainWindow).voznje.Add(voznja as Voznja);
            this.InitializeComponent();
             */
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string inputString = datumBx.Text;
            DateTime dDate;

            int id_voznje = (Application.Current.MainWindow as MainWindow).voznje.Count();


            if (DateTime.TryParse(inputString, out dDate) && CmbVoz.SelectedItem != null && cmbVoznaLinija.SelectedItem != null)
            {
                String.Format("MM/dd/yyyy hh:mm tt", dDate);
                Voznja v = new Voznja { Id = id_voznje, Voz = (Voz)CmbVoz.SelectedItem, Vl = (VoznaLinija)cmbVoznaLinija.SelectedItem, DatumVoznje = dDate };
                (Application.Current.MainWindow as MainWindow).voznje.Add(v);
                RedVoznjePrikaz rvp = new RedVoznjePrikaz { Id = v.Id, Naziv_voza = v.Voz.Naziv, Polazak = v.Vl.Polazak, Dolazak = v.Vl.Dolazak, DatumVoznje = v.DatumVoznje };
                (Application.Current.MainWindow as MainWindow).red_voznje_prikaz.Add(rvp);


                

            }
            else
            {
                MessageBox.Show("Niste uneli datum u pravilnom formatu! {MM/dd/yyyy hh:mm tt}");
            }
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
