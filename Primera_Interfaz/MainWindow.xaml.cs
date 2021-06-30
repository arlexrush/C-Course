using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
 

namespace Primera_Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Grid MiGrid = new Grid();
            this.Content = MiGrid;
            
            MiGrid.Background = Brushes.LightSalmon;
            MiGrid.Height = 500;
            MiGrid.Width = 600;


            Button MiBoton = new Button();
            MiBoton.Width = 150;
            MiBoton.Height = 75;
            MiBoton.Background = Brushes.BlueViolet;
            

            WrapPanel miwrap = new WrapPanel();
            
            
            TextBlock txt1 = new TextBlock();
            txt1.Text = "Enviar Mail";
            txt1.Foreground = Brushes.Yellow;
            miwrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Enviar Mail";
            txt2.Foreground = Brushes.Blue;
            miwrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Enviar Mail";
            txt3.Foreground = Brushes.Red;
            miwrap.Children.Add(txt3);

            MiBoton.Content = miwrap;


            MiGrid.Children.Add(MiBoton);

        }

        
    }
}
