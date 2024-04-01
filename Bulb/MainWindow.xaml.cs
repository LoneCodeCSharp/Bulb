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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bulb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Color color = Color.FromRgb(100, 100, 100);
            bord.Background = new SolidColorBrush(color);
        }

        private void slColorR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void red_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)red.Value, (byte)green.Value, (byte)blue.Value);
            bord.Background = new SolidColorBrush(color);
            bord.Effect = new DropShadowEffect
            {
               Color= new Color {R=(byte)red.Value,G= (byte)green.Value,B=(byte)blue.Value},
                ShadowDepth = 0,
                BlurRadius = 50, 
                Direction = 20
            };
        }

        private void green_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)red.Value, (byte)green.Value, (byte)blue.Value);
            bord.Background = new SolidColorBrush(color);
        }

        private void blue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)red.Value, (byte)green.Value, (byte)blue.Value);
            bord.Background = new SolidColorBrush(color);
        }
    }
}
