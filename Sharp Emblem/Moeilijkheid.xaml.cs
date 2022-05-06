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

namespace Sharp_Emblem
{
    /// <summary>
    /// Interaction logic for Moeilijkheid.xaml
    /// </summary>
    public partial class Moeilijkheid : Page
    {
        public Moeilijkheid()
        {
            InitializeComponent();
        }

        private void NormalSelect_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("ConfigSelect.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HardSelect_Click(object sender, RoutedEventArgs e)
        {
            App.hard = true;
            MainWindow.frame.Navigate(new System.Uri("ConfigSelect.xaml", UriKind.RelativeOrAbsolute));
        }

        private void LunaticSelect_Click(object sender, RoutedEventArgs e)
        {
            App.lunatic = true;
            MainWindow.frame.Navigate(new System.Uri("ConfigSelect.xaml", UriKind.RelativeOrAbsolute));
        }

        private void VorigeSelect_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("Load.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
