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



        public ObservableCollection<Voznja> redovi_voznje
        {
            get;
            set;
        }

        public IzmenaRedVoznje()
        {

            InitializeComponent();
            this.DataContext = this;





            List<Voznja> redovi = (Application.Current.MainWindow as MainWindow).voznje;
            //ObservableCollection<string> vozovi_prikaz = new ObservableCollection<string>();
            redovi_voznje = new ObservableCollection<Voznja>(redovi);



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
                redovi_voznje.Remove((Voznja)selectedItem);
                //dgrMain.Items.Remove(selectedItem);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            


            DateTime vreme_voznje = DateTime.ParseExact(br_m.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);


            Voznja voznja = new Voznja{};
            redovi_voznje.Add(voznja);
            (Application.Current.MainWindow as MainWindow).voznje.Add(voznja as Voznja);
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
