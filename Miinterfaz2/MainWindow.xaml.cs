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

namespace Miinterfaz2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OnClick1(Object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Le diste al boton !");
            Console.WriteLine("Le has dado al boton !");
        }

        private void OnClick2(Object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Le diste al boton 2!");
            Console.WriteLine("Le has dado al boton 2!");
        }

        private void OnClick3(Object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Le diste al boton 3!");
            Console.WriteLine("Le has dado al boton 2!");
        }

       // private void Panel_Click(object sender, RoutedEventArgs e)
        //{
          //  Console.WriteLine("Le has dado CLICK al Panel");
        //}

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado CLICK al Panel");
        }
    }


}
