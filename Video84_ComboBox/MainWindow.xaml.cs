﻿using System;
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

namespace Video84_ComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> listaCapitales = new List<Capitales>
            {
                new Capitales { NombreCapital = "Madrid" },
                new Capitales { NombreCapital = "Bogota" },
                new Capitales { NombreCapital = "Lima" },
                new Capitales { NombreCapital = "DF" },
                new Capitales { NombreCapital = "Santiago" }
            };
            capitalesLA.ItemsSource = listaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;

        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            DF.IsChecked = false;
            Santiago.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if(Madrid.IsChecked==true && Bogota.IsChecked==true && Lima.IsChecked==true && DF.IsChecked==true && Santiago.IsChecked == true) 
            {
                TodasC.IsChecked = true;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }


        private void Individual_NoChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && DF.IsChecked == false && Santiago.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
