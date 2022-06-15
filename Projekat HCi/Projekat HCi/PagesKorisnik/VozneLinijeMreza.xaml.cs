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

namespace Projekat_HCi.PagesKorisnik
{
    /// <summary>
    /// Interaction logic for VozneLinijeMreza.xaml
    /// </summary>
    public partial class VozneLinijeMreza : Page
    {
        public VozneLinijeMreza()
        {
            InitializeComponent();

            ZoomViewbox.Width = 100;
            ZoomViewbox.Height = 100;
        }


        private void MainWindow_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            UpdateViewBox((e.Delta > 0) ? 15 : -15);
        }

        private void UpdateViewBox(int newValue)
        {
            if ((ZoomViewbox.Width >= 0) && ZoomViewbox.Height >= 0)
            {
                ZoomViewbox.Width += newValue;
                ZoomViewbox.Height += newValue;
            }
        }

        /*
        private void MainWindow_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            UpdateViewBox((e.Delta > 0) ? 5 : -5);
        }

        private void UpdateViewBox(int newValue)
        {
            if ((ZoomViewbox.Width >= 0) && ZoomViewbox.Height >= 0)
            {
                ZoomViewbox.Width += newValue;
                ZoomViewbox.Height += newValue;
            }
        }
        
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var scaler = mainPanel.LayoutTransform as ScaleTransform;

            if (scaler == null)
            {
                mainPanel.LayoutTransform = new ScaleTransform(slider1.Value, slider1.Value);
            }
            else if (scaler.HasAnimatedProperties)
            {
                // Do nothing because the value is being changed by animation.
                // Setting scaler.ScaleX will cause infinite recursion due to the
                // binding specified in the XAML.
            }
            else
            {
                scaler.ScaleX = slider1.Value;
                scaler.ScaleY = slider1.Value;
            }
        }
        */
    }
}
