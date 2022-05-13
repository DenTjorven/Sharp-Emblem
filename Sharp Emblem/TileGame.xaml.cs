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
    /// Interaction logic for TileGame.xaml
    /// </summary>
    public partial class TileGame : Page
    {
        public TileGame()
        {
            InitializeComponent();

            var tempRan = new Random();
            var mapSelect = tempRan.Next(1, 6);

            SetMap1();

            //switch (mapSelect) 1-5:  random map select

            foreach (Button btn in FindVisualChildren<Button>(Game))
            {
                btn.IsHitTestVisible = false;
                if (((SolidColorBrush)btn.Background).Color == Colors.Gold)
                {
                    btn.IsHitTestVisible = true;
                }
            }

            string messageBoxText = "Please select starting positions for your units, in order (1-4) on the golden tiles";
            string caption = "Starting Positions";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(messageBoxText, caption, button, icon);


            
        }

        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public void SetMap1()
        {
            zerozero.Background = new SolidColorBrush(Colors.DarkGreen); zeroone.Background = new SolidColorBrush(Colors.Green); zerotwo.Background = new SolidColorBrush(Colors.Green); zerothree.Background = new SolidColorBrush(Colors.Blue); zerofour.Background = new SolidColorBrush(Colors.Gold); zerofive.Background = new SolidColorBrush(Colors.Green);
            onezero.Background = new SolidColorBrush(Colors.Green); oneone.Background = new SolidColorBrush(Colors.Green); onetwo.Background = new SolidColorBrush(Colors.Green); onethree.Background = new SolidColorBrush(Colors.Green); onefour.Background = new SolidColorBrush(Colors.Gold); onefive.Background = new SolidColorBrush(Colors.Gold);
            twozero.Background = new SolidColorBrush(Colors.Green); twoone.Background = new SolidColorBrush(Colors.Green); twotwo.Background = new SolidColorBrush(Colors.Blue); twothree.Background = new SolidColorBrush(Colors.Blue); twofour.Background = new SolidColorBrush(Colors.Blue); twofive.Background = new SolidColorBrush(Colors.Gold);
            threezero.Background = new SolidColorBrush(Colors.Green); threeone.Background = new SolidColorBrush(Colors.Blue); threetwo.Background = new SolidColorBrush(Colors.OrangeRed); threethree.Background = new SolidColorBrush(Colors.Green); threefour.Background = new SolidColorBrush(Colors.Blue); threefive.Background = new SolidColorBrush(Colors.Green);
            fourzero.Background = new SolidColorBrush(Colors.Green); fourone.Background = new SolidColorBrush(Colors.Green); fourtwo.Background = new SolidColorBrush(Colors.OrangeRed); fourthree.Background = new SolidColorBrush(Colors.OrangeRed); fourfour.Background = new SolidColorBrush(Colors.Blue); fourfive.Background = new SolidColorBrush(Colors.Green);
            fivezero.Background = new SolidColorBrush(Colors.Green); fiveone.Background = new SolidColorBrush(Colors.Blue); fivetwo.Background = new SolidColorBrush(Colors.Blue); fivethree.Background = new SolidColorBrush(Colors.OrangeRed); fivefour.Background = new SolidColorBrush(Colors.Green); fivefive.Background = new SolidColorBrush(Colors.Green);
            sixzero.Background = new SolidColorBrush(Colors.Green); sixone.Background = new SolidColorBrush(Colors.Green); sixtwo.Background = new SolidColorBrush(Colors.Green); sixthree.Background = new SolidColorBrush(Colors.Green); sixfour.Background = new SolidColorBrush(Colors.Green); sixfive.Background = new SolidColorBrush(Colors.Green);
            sevenzero.Background = new SolidColorBrush(Colors.DarkGreen); sevenone.Background = new SolidColorBrush(Colors.Green); seventwo.Background = new SolidColorBrush(Colors.Blue); seventhree.Background = new SolidColorBrush(Colors.DarkGreen); sevenfour.Background = new SolidColorBrush(Colors.Green); sevenfive.Background = new SolidColorBrush(Colors.DarkGreen);
        }

        private void ButtonClickCommandHandler(object parameter)
        {
            foreach (Button btn in FindVisualChildren<Button>(Game))
            {
                if(btn.CommandParameter == parameter)
                {
                    btn.Background = new SolidColorBrush(Colors.Black);
                }
            }








            //switch (parameter)
            //{
            //case 1:
            //break;
            //case 2:
            //break;
            //}
        }
    }


}
