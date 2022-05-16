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
        List<Button> buttons = new List<Button>();
        List<ImageBrush> playerBrushs = new List<ImageBrush>();
        List<ImageBrush> cpuBrushs = new List<ImageBrush>();
        public TileGame()
        {
            InitializeComponent();

            var tempRan = new Random();
            var mapSelect = tempRan.Next(1, 6);

            //Temp
            SetMap1();
            App.indexPlayer1 = 2; App.indexPlayer2 = 3; App.indexPlayer3 = 4; App.indexPlayer4 = 5;
            App.indexCpu1 = 6; App.indexCpu2 = 7; App.indexCpu3 = 8; App.indexCpu4 = 9;
            //

            //switch (mapSelect) 1-5:  random map select

            //Adding data to lists for ease of use
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers1.png", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers2.png", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers3.png", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers4.png", UriKind.Relative))));

            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers1.png", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers2.png", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers3.png", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers4.png", UriKind.Relative))));

            App.playerChar.Add(App.karakters[App.indexPlayer1]); App.playerChar.Add(App.karakters[App.indexPlayer2]); App.playerChar.Add(App.karakters[App.indexPlayer3]); App.playerChar.Add(App.karakters[App.indexPlayer4]);
            App.cpuChar.Add(App.karakters[App.indexCpu1]); App.cpuChar.Add(App.karakters[App.indexCpu2]); App.cpuChar.Add(App.karakters[App.indexCpu3]); App.cpuChar.Add(App.karakters[App.indexCpu4]);

            foreach (Button btn in FindVisualChildren<Button>(Game))
            {
                buttons.Add(btn);
            }
            //

            foreach (Button btn in FindVisualChildren<Button>(Game))
            {
                btn.IsHitTestVisible = false;
                if (((SolidColorBrush)btn.Background).Color == Colors.Gold)
                {
                    btn.IsHitTestVisible = true;
                }
            }
            MessageBox.Show("Please select starting positions for your units, in order (1-4) on the golden tiles", "Starting Positions", MessageBoxButton.OK, MessageBoxImage.Information);


            
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

#pragma warning disable CS8604 // Possible null reference argument.
                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
#pragma warning restore CS8604 // Possible null reference argument.
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

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            var currentbutton = (Button)sender;
            var currentrow = Grid.GetRow(currentbutton);
            var currentcolumn = Grid.GetColumn(currentbutton);
            var cursor = App.karakters.Where(z => z.Xcord == currentcolumn && z.Ycord == currentrow);

            if (App.turn == 0)
            {
                switch(App.charcount)
                {
                    case 0:
                        App.karakters[App.indexPlayer1].Xcord = currentcolumn; App.karakters[App.indexPlayer1].Ycord = currentrow;
                        currentbutton.Background = playerBrushs[0];
                        App.charcount++;
                        break;
                    case 1:
                        App.karakters[App.indexPlayer2].Xcord = currentcolumn; App.karakters[App.indexPlayer2].Ycord = currentrow;
                        currentbutton.Background = playerBrushs[1];
                        App.charcount++;
                        break;
                    case 2:
                        App.karakters[App.indexPlayer3].Xcord = currentcolumn; App.karakters[App.indexPlayer3].Ycord = currentrow;
                        currentbutton.Background = playerBrushs[2];
                        App.charcount++;
                        break;
                    case 3:
                        App.karakters[App.indexPlayer4].Xcord = currentcolumn; App.karakters[App.indexPlayer4].Ycord = currentrow;
                        currentbutton.Background = playerBrushs[3];
                        App.charcount = 0;
                        if (MessageBox.Show("Are these positions correct?", "Starting Positions", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                        {
                            SetMap1();
                        }
                        else
                        {
                            var index = 0;

                            foreach (Button btn in FindVisualChildren<Button>(Game))
                            {
                                if (btn.Background == playerBrushs[0] || btn.Background == playerBrushs[1] || btn.Background == playerBrushs[2] || btn.Background == playerBrushs[3])
                                {

                                }
                                else if (((SolidColorBrush)btn.Background).Color == Colors.OrangeRed)
                                {

                                    //WPF heeft probleem met loopen door all de buttons in grid op basis van SolidColorBrush omdat somige en imagebrush hebben

                                    var row = Grid.GetRow(btn);
                                    var column = Grid.GetColumn(btn);

                                    btn.Background = cpuBrushs[index];

                                    if (index == 1)
                                    {
                                        App.karakters[App.indexCpu1].Xcord = column; App.karakters[App.indexCpu1].Ycord = row;
                                    }
                                    else if (index == 2)
                                    {
                                        App.karakters[App.indexCpu2].Xcord = column; App.karakters[App.indexCpu2].Ycord = row;
                                    }
                                    else if (index == 3)
                                    {
                                        App.karakters[App.indexCpu3].Xcord = column; App.karakters[App.indexCpu3].Ycord = row;
                                    }
                                    else
                                    {
                                        App.karakters[App.indexCpu4].Xcord = column; App.karakters[App.indexCpu4].Ycord = row;
                                    }

                                    index++;
                                }
                            }
                            App.turn++;
                        }
                        break;
                } 
            }
            else
            {
                switch (App.charcount)
                {
                    case 0:
                        if (App.selectchar == true)
                        {
                            foreach (Button btn in FindVisualChildren<Button>(Game))
                            {
                                var row = Grid.GetRow(btn);
                                App.previousRow = row;
                                var column = Grid.GetColumn(btn);
                                App.previousColumn = column;

                                int xdistance = Math.Abs(currentcolumn - column);
                                int ydistance = Math.Abs(currentrow - row);
                                int distance = xdistance + ydistance;

                                foreach (var kara in cursor)
                                {
                                    if (distance <= kara.Movement)
                                    {
                                        if(((SolidColorBrush)btn.Background).Color == Colors.Blue)
                                        {
                                        }
                                        else
                                        {
                                            btn.IsHitTestVisible = true;
                                        }
                                    }
                                    else
                                    {
                                        btn.IsHitTestVisible = false;
                                    }
                                }

                            }
                            App.selectchar = false;
                        }
                        else
                        {
                            foreach (Button btn in FindVisualChildren<Button>(Game))
                            {
                                
                            }
                        }
                        App.charcount++;
                        break;
                    case 1:


                        App.charcount++;
                        break;
                    case 2:


                        App.charcount++;
                        break;
                    case 3:
                        App.charcount = 0;
                        App.turn++;
                        break;
                }
            }
            

            //foreach (Button btn in FindVisualChildren<Button>(Game))
            //{
            //if (sender == btn)
            //{
            //btn.Background = new SolidColorBrush(Colors.Black);
            //}
            //}

        }
    }


}

