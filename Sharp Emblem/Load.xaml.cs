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

namespace Sharp_Emblem
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : Page
    {
        public Load()
        {
            InitializeComponent();
        }

        private void StartNew_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("Moeilijkheid.xaml", UriKind.RelativeOrAbsolute));
        }

        private void VorigeSelect_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
