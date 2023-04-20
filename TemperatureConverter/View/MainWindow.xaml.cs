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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var text = double.Parse(textBox.Text);
            var fahrenheit = (text * 1.8) + 32;
            var kelvin = text + 273.15;

            var rFahrenheit = fahrenheit.ToString();
            var rKelvin = kelvin.ToString();
            textBox2.Text = rFahrenheit;
            textBox3.Text = rKelvin;
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var text = double.Parse(textBox2.Text);
            var celsius = (text - 32) / 1.8;
            var kelvin = celsius + 273.15;

            var rCelsius = celsius.ToString();
            var rKelvin = kelvin.ToString();
            textBox.Text = rCelsius;
            textBox3.Text = rKelvin;
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var text = double.Parse(textBox3.Text);
            var celsius = text - 273.15;
            var fahrenheit = (celsius * 1.8) + 32;

            var rCelsius = celsius.ToString();
            var rFahrenheit = fahrenheit.ToString();
            textBox.Text = rCelsius;
            textBox2.Text = rFahrenheit;
        }
    }
}
