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

namespace Video81_ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblaciones> listaPob = new List<Poblaciones>();
            listaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaT=2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 19, Temperatura2 = 21, DiferenciaT= 2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Malaga", Poblacion2 = "Bilbao", Temperatura1 = 20, Temperatura2 = 23, DiferenciaT= 2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 22, Temperatura2 = 27, DiferenciaT= 5 });
            listaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                    MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }

        private void TextBlock_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }

        private void TextBlock_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }

        private void ProgressBar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C   " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona Primnero un Elemento");
            }
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int DiferenciaT { get; set; }
    }
}
