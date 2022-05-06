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
    /// Interaction logic for ConfigSelect.xaml
    /// </summary>
    public partial class ConfigSelect : Page
    {
        public ConfigSelect()
        {
            InitializeComponent();
        }

        private void SpelerSelect_Checked(object sender, RoutedEventArgs e)
        {
            App.spelerRandom = false;
        }

        private void SpelerRandom_Checked(object sender, RoutedEventArgs e)
        {
            App.spelerRandom = true;
        }

        private void CpuSelect_Checked(object sender, RoutedEventArgs e)
        {
            App.cpuRandom = false;
        }

        private void CpuRandom_Checked(object sender, RoutedEventArgs e)
        {
            App.cpuRandom = true;
        }

        private void BevestigSelect_Click(object sender, RoutedEventArgs e)
        {
            if(App.spelerRandom && App.cpuRandom)
            {
                SpelerRan();
                CpuRan();
                MainWindow.frame.Navigate(new System.Uri("TileGame.xaml", UriKind.RelativeOrAbsolute));
            }
            else if(!App.spelerRandom && App.cpuRandom)
            {
                CpuRan();
                MainWindow.frame.Navigate(new System.Uri("SpelerSelect.xaml", UriKind.RelativeOrAbsolute));
            }
            else if(App.spelerRandom && !App.cpuRandom)
            {
                SpelerRan();
                MainWindow.frame.Navigate(new System.Uri("CpuSelect.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MainWindow.frame.Navigate(new System.Uri("SpelerSelect.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        public void SpelerRan()
        {
            var dupe = true;
            var tempRan = new Random();
            App.indexPlayer1 = tempRan.Next(2, 60); App.indexPlayer2 = tempRan.Next(2, 60); App.indexPlayer3 = tempRan.Next(2, 60); App.indexPlayer4 = tempRan.Next(2, 60);

            while (dupe)
            {
                if ((App.indexPlayer1 == App.indexPlayer2) || (App.indexPlayer1 == App.indexPlayer3) || (App.indexPlayer1 == App.indexPlayer4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexPlayer2 == App.indexPlayer1) || (App.indexPlayer2 == App.indexPlayer3) || (App.indexPlayer2 == App.indexPlayer4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexPlayer3 == App.indexPlayer2) || (App.indexPlayer3 == App.indexPlayer1) || (App.indexPlayer3 == App.indexPlayer4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexPlayer4 == App.indexPlayer2) || (App.indexPlayer4 == App.indexPlayer3) || (App.indexPlayer4 == App.indexPlayer1))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }

                if (dupe)
                {
                    App.indexPlayer1 = tempRan.Next(2, 60); App.indexPlayer2 = tempRan.Next(2, 60); App.indexPlayer3 = tempRan.Next(2, 60); App.indexPlayer4 = tempRan.Next(2, 60);
                }
            }

        }
        public void CpuRan()
        {
            var dupe = true;
            var tempRan = new Random();
            App.indexCpu1 = tempRan.Next(2, 60); App.indexCpu2 = tempRan.Next(2, 60); App.indexCpu3 = tempRan.Next(2, 60); App.indexCpu4 = tempRan.Next(2, 60);

            while (dupe)
            {
                if ((App.indexCpu1 == App.indexCpu2) || (App.indexCpu1 == App.indexCpu3) || (App.indexCpu1 == App.indexCpu4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexCpu2 == App.indexCpu1) || (App.indexCpu2 == App.indexCpu3) || (App.indexCpu2 == App.indexCpu4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexCpu3 == App.indexCpu2) || (App.indexCpu3 == App.indexCpu1) || (App.indexCpu3 == App.indexCpu4))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }
                if ((App.indexCpu4 == App.indexCpu2) || (App.indexCpu4 == App.indexCpu3) || (App.indexCpu4 == App.indexCpu1))
                {
                    dupe = true;
                }
                else
                {
                    dupe = false;
                }

                if (dupe)
                {
                    App.indexCpu1 = tempRan.Next(2, 60); App.indexCpu2 = tempRan.Next(2, 60); App.indexCpu3 = tempRan.Next(2, 60); App.indexCpu4 = tempRan.Next(2, 60);
                }
            }
        }
    }
}
