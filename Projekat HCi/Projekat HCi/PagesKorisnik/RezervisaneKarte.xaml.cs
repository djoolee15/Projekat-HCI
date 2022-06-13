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
    /// Interaction logic for RezervisaneKarte.xaml
    /// </summary>
    public partial class RezervisaneKarte : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        Point startPoint = new Point();

        public ObservableCollection<KartaPrikaz> karte_prikaz
        {
            get;
            set;
        }

        public ObservableCollection<KartaPrikaz> karte_prikaz_2
        {
            get;
            set;
        }

        public RezervisaneKarte()
        {
            InitializeComponent();
            this.DataContext = this;

            karte_prikaz = new ObservableCollection<KartaPrikaz>();
            karte_prikaz_2 = new ObservableCollection<KartaPrikaz>();

            foreach (KartaPrikaz kp in (Application.Current.MainWindow as MainWindow).karte_prikaz) {
                if (kp.Stanje == "rezervisana")
                {
                    karte_prikaz.Add(kp);
                }
                else { 
                    karte_prikaz_2.Add(kp);
                }
            }
        }

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                // Find the data behind the ListViewItem
                KartaPrikaz kp = (KartaPrikaz)listView.ItemContainerGenerator.
                    ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("myFormat", kp);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                KartaPrikaz kp = e.Data.GetData("myFormat") as KartaPrikaz;
                karte_prikaz.Remove(kp);
                karte_prikaz_2.Add(kp);
                kp.Stanje = "kupljena";
            }
        }


    }
}
