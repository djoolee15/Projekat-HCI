using Prism.Commands;
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
    /// Interaction logic for IzmenaVoz.xaml
    /// </summary>
    public partial class IzmenaVoz : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        public ObservableCollection<Voz> vozovi_prikaz
        {
            get;
            set;
        }

        public IzmenaVoz()
        {

            InitializeComponent();
            this.DataContext = this;



            

            List<Voz> vozovi = (Application.Current.MainWindow as MainWindow).vozovi;
            vozovi_prikaz = new ObservableCollection<Voz>(vozovi);


            //ObservableCollection<string> vozovi_prikaz = new ObservableCollection<string>();
            
            foreach (Voz voz in vozovi) {
                //vozovi_prikaz.Add(voz.naziv);
                Console.WriteLine(voz.Naziv + " " + voz.Id);
            }
            
           




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
                Voz v = (Voz)selectedItem;
                vozovi_prikaz.Remove((Voz)selectedItem);
                //(Application.Current.MainWindow as MainWindow).vozovi.Remove((Voz)selectedItem);
                foreach (Voz voz in (Application.Current.MainWindow as MainWindow).vozovi)
                {
                    if (v.Id == voz.Id)
                    {
                        (Application.Current.MainWindow as MainWindow).vozovi.Remove(v);
                        (Application.Current.MainWindow as MainWindow).kontroler.BrisanjeVoza(v);

                        foreach (Voz vozic in vozovi_prikaz)
                        {
                            //vozovi_prikaz.Add(voz.naziv);
                            Console.WriteLine(vozic.Naziv + " " + vozic.Id);
                        }




                        break;
                    }
                }

                //dgrMain.Items.Remove(selectedItem);
            }



            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string naziv = naziv_1.Text;
            int id = int.Parse(id_1.Text);
            int br_mesta = int.Parse(br_m.Text);
            int br_vagona = int.Parse(br_v.Text);
           
           
            Voz voz1 = new Voz { Broj_mesta = br_mesta, Broj_vagona = br_vagona, Naziv = naziv, Id = id };
            vozovi_prikaz.Add(voz1);
            (Application.Current.MainWindow as MainWindow).vozovi.Add(voz1 as Voz);
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
