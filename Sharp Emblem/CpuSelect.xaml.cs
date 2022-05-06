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
    /// Interaction logic for CpuSelect.xaml
    /// </summary>
    public partial class CpuSelect : Page
    {
        public CpuSelect()
        {
            InitializeComponent();

            foreach (var karakter in App.karakters)
            {
                Char1Box.Items.Add(karakter.Name);
                Char2Box.Items.Add(karakter.Name);
                Char3Box.Items.Add(karakter.Name);
                Char4Box.Items.Add(karakter.Name);
            }
        }
        public void IndexChar1()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)Char1Box.SelectedItem == karakter.Name)
                {
                    App.indexCpu1 = App.karakters.IndexOf(karakter);
                }

            }
        }
        public void IndexChar2()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)Char2Box.SelectedItem == karakter.Name)
                {
                    App.indexCpu2 = App.karakters.IndexOf(karakter);
                }

            }
        }
        public void IndexChar3()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)Char3Box.SelectedItem == karakter.Name)
                {
                    App.indexCpu3 = App.karakters.IndexOf(karakter);
                }

            }
        }
        public void IndexChar4()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)Char4Box.SelectedItem == karakter.Name)
                {
                    App.indexCpu4 = App.karakters.IndexOf(karakter);
                }

            }
        }

        private void VorigeSelect_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("ConfigSelect.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Bevestig_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(new System.Uri("TileGame.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
