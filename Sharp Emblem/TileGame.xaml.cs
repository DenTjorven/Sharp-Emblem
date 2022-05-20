using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            App.indexPlayer1 = 0; App.indexPlayer2 = 1; App.indexPlayer3 = 2; App.indexPlayer4 = 3;
            App.indexCpu1 = 4; App.indexCpu2 = 5; App.indexCpu3 = 6; App.indexCpu4 = 7;
            //

            //switch (mapSelect) 1-5:  random map select

            //Adding data to lists for ease of use
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers1Gold.jpg", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers2Gold.jpg", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers3Gold.jpg", UriKind.Relative))));
            playerBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers4Gold.jpg", UriKind.Relative))));

            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers1Orange.jpg", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers2Orange.jpg", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers3Orange.jpg", UriKind.Relative))));
            cpuBrushs.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\BattleNumbers4Orange.jpg", UriKind.Relative))));

            App.playerChar.Add(App.karakters[App.indexPlayer1]); App.playerChar.Add(App.karakters[App.indexPlayer2]); App.playerChar.Add(App.karakters[App.indexPlayer3]); App.playerChar.Add(App.karakters[App.indexPlayer4]);
            App.cpuChar.Add(App.karakters[App.indexCpu1]); App.cpuChar.Add(App.karakters[App.indexCpu2]); App.cpuChar.Add(App.karakters[App.indexCpu3]); App.cpuChar.Add(App.karakters[App.indexCpu4]);

            Debug.WriteLine(App.playerChar + " " + App.playerChar.Count);
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
            onezero.Background = new SolidColorBrush(Colors.Green); oneone.Background = new SolidColorBrush(Colors.Green); onetwo.Background = new SolidColorBrush(Colors.Green); onethree.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a45729")); onefour.Background = new SolidColorBrush(Colors.Gold); onefive.Background = new SolidColorBrush(Colors.Gold);
            twozero.Background = new SolidColorBrush(Colors.Green); twoone.Background = new SolidColorBrush(Colors.Green); twotwo.Background = new SolidColorBrush(Colors.Blue); twothree.Background = new SolidColorBrush(Colors.Blue); twofour.Background = new SolidColorBrush(Colors.Blue); twofive.Background = new SolidColorBrush(Colors.Gold);
            threezero.Background = new SolidColorBrush(Colors.Green); threeone.Background = new SolidColorBrush(Colors.Blue); threetwo.Background = new SolidColorBrush(Colors.Green); threethree.Background = new SolidColorBrush(Colors.Green); threefour.Background = new SolidColorBrush(Colors.Blue); threefive.Background = new SolidColorBrush(Colors.Green);
            fourzero.Background = new SolidColorBrush(Colors.Green); fourone.Background = new SolidColorBrush(Colors.Green); fourtwo.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a45729")); fourthree.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a45729")); fourfour.Background = new SolidColorBrush(Colors.Blue); fourfive.Background = new SolidColorBrush(Colors.Green);
            fivezero.Background = new SolidColorBrush(Colors.Green); fiveone.Background = new SolidColorBrush(Colors.Blue); fivetwo.Background = new SolidColorBrush(Colors.Blue); fivethree.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a45729")); ; fivefour.Background = new SolidColorBrush(Colors.Green); fivefive.Background = new SolidColorBrush(Colors.Green);
            sixzero.Background = new SolidColorBrush(Colors.Green); sixone.Background = new SolidColorBrush(Colors.Green); sixtwo.Background = new SolidColorBrush(Colors.Green); sixthree.Background = new SolidColorBrush(Colors.Green); sixfour.Background = new SolidColorBrush(Colors.Green); sixfive.Background = new SolidColorBrush(Colors.Green);
            sevenzero.Background = new SolidColorBrush(Colors.DarkGreen); sevenone.Background = new SolidColorBrush(Colors.Green); seventwo.Background = new SolidColorBrush(Colors.Blue); seventhree.Background = new SolidColorBrush(Colors.DarkGreen); sevenfour.Background = new SolidColorBrush(Colors.Green); sevenfive.Background = new SolidColorBrush(Colors.DarkGreen);
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            var currentbutton = (Button)sender;
            var currentrow = Grid.GetRow(currentbutton);
            var currentcolumn = Grid.GetColumn(currentbutton);
            var brush = currentbutton.Background as ImageBrush;
            if (App.turn == 0)
            {
                switch(App.charcount)
                {
                    case 0:
                        App.playerChar[0].Xcord = currentcolumn; App.playerChar[0].Ycord = currentrow;
                        App.playerChar[0].FirstBrush = new SolidColorBrush(Colors.Green);
                        currentbutton.Background = playerBrushs[0];
                        App.charcount++;
                        break;
                    case 1:
                        App.playerChar[1].Xcord = currentcolumn; App.playerChar[1].Ycord = currentrow;
                        App.playerChar[1].FirstBrush = new SolidColorBrush(Colors.Green);
                        currentbutton.Background = playerBrushs[1];
                        App.charcount++;
                        break;
                    case 2:
                        App.playerChar[2].Xcord = currentcolumn; App.playerChar[2].Ycord = currentrow;
                        App.playerChar[2].FirstBrush = new SolidColorBrush(Colors.Green);
                        currentbutton.Background = playerBrushs[2];
                        App.charcount++;
                        break;
                    case 3:
                        App.playerChar[3].Xcord = currentcolumn; App.playerChar[3].Ycord = currentrow;
                        App.playerChar[3].FirstBrush = new SolidColorBrush(Colors.Green);
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
                                else if (((SolidColorBrush)btn.Background).Color == (Color)ColorConverter.ConvertFromString("#a45729"))
                                {

                                    //WPF had probleem met loopen door all de buttons in grid op basis van SolidColorBrush omdat somige en imagebrush hebben

                                    var row = Grid.GetRow(btn);
                                    var column = Grid.GetColumn(btn);

                                    if (index == 1)
                                    {
                                        App.cpuChar[0].Xcord = column; App.cpuChar[0].Ycord = row;
                                        App.cpuChar[0].FirstBrush = new SolidColorBrush(Colors.Green);
                                    }
                                    else if (index == 2)
                                    {
                                        App.cpuChar[1].Xcord = column; App.cpuChar[1].Ycord = row;
                                        App.cpuChar[1].FirstBrush = new SolidColorBrush(Colors.Green);
                                    }
                                    else if (index == 3)
                                    {
                                        App.cpuChar[2].Xcord = column; App.cpuChar[2].Ycord = row;
                                        App.cpuChar[2].FirstBrush = new SolidColorBrush(Colors.Green);
                                    }
                                    else
                                    {
                                        App.cpuChar[3].Xcord = column; App.cpuChar[3].Ycord = row;
                                        App.cpuChar[3].FirstBrush = new SolidColorBrush(Colors.Green);
                                    }
                                    btn.Background = cpuBrushs[index];
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
                var cursor = App.playerChar.Where(z => z.Xcord == currentcolumn && z.Ycord == currentrow);
                
                switch (App.charcount)
                {
                    case 0:
                        Turn(currentrow, currentcolumn, brush, cursor, currentbutton);
                        
                        break;
                    case 1:
                        Turn(currentrow, currentcolumn, brush, cursor, currentbutton);

                        
                        break;
                    case 2:
                        Turn(currentrow, currentcolumn, brush, cursor, currentbutton);

                        
                        break;
                    case 3:
                        Turn(currentrow, currentcolumn, brush, cursor, currentbutton);
                        if(App.selectchar)
                        {
                            foreach (Button btn in FindVisualChildren<Button>(Game))
                            {
                                if (btn.Background == playerBrushs[0] || btn.Background == playerBrushs[1] || btn.Background == playerBrushs[2] || btn.Background == playerBrushs[3])
                                {
                                    btn.IsHitTestVisible = true;
                                }
                            }
                            App.charcount = 0;
                            App.turn++;
                        }
                        break;
                }
            }
        }

        private void Turn(int currentrow, int currentcolumn, ImageBrush brush, IEnumerable<App.Karakter> cursor, Button currentbutton)
        {
            App.previousRow = currentrow;
            App.previousColumn = currentcolumn;
            App.previousBrush = brush;
            if (App.selectchar && App.attackcheck)
            {
                Debug.WriteLine("cursor: " + cursor.ToList().Count);

                foreach (var hit in FindVisualChildren<Button>(Game))
                {
                    hit.IsHitTestVisible = false;
                }

                foreach (var kara in cursor)
                {
                    var validEnemy = App.cpuChar.Where(z => Math.Abs(currentcolumn - z.Xcord) + Math.Abs(currentrow - z.Ycord) == kara.Range);
                    Debug.WriteLine("kara range: " + kara.Range);
                    Debug.WriteLine("kara name: " + kara.Name);
                    foreach (var enemy in App.cpuChar)
                    {
                        Debug.WriteLine("distance: " + (Math.Abs(currentcolumn - enemy.Xcord) + Math.Abs(currentrow - enemy.Ycord)));
                    }
                    Debug.WriteLine("validenemies: " + validEnemy.ToList().Count);
                    if (validEnemy.Any())
                    {
                        if (MessageBox.Show("An Enemy is in range, do you wish to attack?", "Attacking", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                        {
                            
                        }
                        else
                        {
                            Debug.WriteLine("attack check check");
                            App.attackcheck = false;
                            foreach (var valid in validEnemy)
                            {
                                var enemyPos = FindVisualChildren<Button>(Game).ToList().Where(e => Grid.GetColumn(e) == valid.Xcord && Grid.GetRow(e) == valid.Ycord).ToList();
                                Debug.WriteLine("enemy positions: " + validEnemy.ToList().Count);
                                foreach (var pos in enemyPos)
                                {
                                    pos.IsHitTestVisible = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (!App.attackcheck)
            {
                Debug.WriteLine("attack trigger succes");
            }
            else if (App.selectchar)
            {
                {
                    foreach (Button btn in FindVisualChildren<Button>(Game))
                    {

                        var row = Grid.GetRow(btn);
                        var column = Grid.GetColumn(btn);


                        int xdistance = Math.Abs(currentcolumn - column);
                        int ydistance = Math.Abs(currentrow - row);
                        int distance = xdistance + ydistance;
                        var hittestif = FindVisualChildren<Button>(Game).Where(b => b.IsHitTestVisible = true);

                        foreach (var kara in cursor)
                        {
                            if (distance <= kara.Movement)
                            {
                                if (btn.Background == playerBrushs[0] || btn.Background == playerBrushs[1] || btn.Background == playerBrushs[2] || btn.Background == playerBrushs[3] || btn.Background == cpuBrushs[0] || btn.Background == cpuBrushs[1] || btn.Background == cpuBrushs[2] || btn.Background == cpuBrushs[3])
                                {
                                    btn.IsHitTestVisible = false;
                                }
                                else
                                {
                                    if (((SolidColorBrush)btn.Background).Color == Colors.Blue)
                                    {
                                        if (kara.FlyMov)
                                        {
                                            btn.IsHitTestVisible = true;
                                        }
                                    }
                                    else
                                    {
                                        btn.IsHitTestVisible = true;
                                    }
                                }

                            }
                            else
                            {
                                btn.IsHitTestVisible = false;
                            }
                        }
                        App.selectchar = false;
                    }
                }
            }
            else if (!App.selectchar)
            {
                currentbutton.Background = App.previousBrush;
                var startpos = App.playerChar.Where(z => z.Xcord == App.previousColumn && z.Ycord == App.previousRow).ToList();
                var hittestelse = FindVisualChildren<Button>(Game).Where(b => b.IsHitTestVisible = true);

                foreach (var hit in hittestelse)
                {
                    hit.IsHitTestVisible = false;
                }

                foreach (Button btn in FindVisualChildren<Button>(Game))
                {

                    var row = Grid.GetRow(btn);
                    var column = Grid.GetColumn(btn);
                    foreach (var kara in startpos)
                    {
                        kara.Xcord = currentcolumn; kara.Ycord = currentrow;

                        if (column == App.previousColumn && row == App.previousRow)
                        {
                            SolidColorBrush tempBrush = new SolidColorBrush();
                            tempBrush = kara.FirstBrush;
                            kara.FirstBrush = currentbutton.Background as SolidColorBrush;

                            btn.Background = tempBrush;

                        }
                    }

                    if (btn.Background == playerBrushs[0] || btn.Background == playerBrushs[1] || btn.Background == playerBrushs[2] || btn.Background == playerBrushs[3] || btn.Background == cpuBrushs[0] || btn.Background == cpuBrushs[1] || btn.Background == cpuBrushs[2] || btn.Background == cpuBrushs[3])
                    {
                        btn.IsHitTestVisible = true;
                        currentbutton.IsHitTestVisible = false;

                    }
                }

                App.selectchar = true;
            }
            App.charcount++;

        }
    
           
        
                



        public bool DamageType(int indexKar1)
        {
            var dmgType = false;

            if (App.karakters[indexKar1].WapenType == "Tome" || App.karakters[indexKar1].WapenType == "Dragon" || App.karakters[indexKar1].WapenType == "Staff")
            {
                dmgType = true;
            }
            return dmgType;
        }
        public double WeaponTriangle(int indexKar1, int indexKar2)
        {
            var triangle = 1.0;
            if ((App.karakters[(indexKar1)].WapenKleur == "G" && App.karakters[(indexKar2)].WapenKleur == "R") || (App.karakters[(indexKar1)].WapenKleur == "R" && App.karakters[(indexKar2)].WapenKleur == "B") || (App.karakters[(indexKar1)].WapenKleur == "B" && App.karakters[(indexKar2)].WapenKleur == "G"))
            {
                triangle = 0.8;
                if (App.karakters[(indexKar1)].Gem || App.karakters[(indexKar2)].Gem || App.karakters[(indexKar1)].SkillAID == 19 || App.karakters[(indexKar2)].SkillAID == 19)
                {
                    triangle = 0.6;
                }
            }
            else if ((App.karakters[(indexKar1)].WapenKleur == "G" && App.karakters[(indexKar2)].WapenKleur == "B") || (App.karakters[(indexKar1)].WapenKleur == "R" && App.karakters[(indexKar2)].WapenKleur == "G") || (App.karakters[(indexKar1)].WapenKleur == "B" && App.karakters[(indexKar2)].WapenKleur == "R"))
            {
                triangle = 1.2;
                if (App.karakters[(indexKar1)].Gem || App.karakters[(indexKar2)].Gem || App.karakters[(indexKar1)].SkillAID == 19 || App.karakters[(indexKar2)].SkillAID == 19)
                {
                    triangle = 1.4;
                }
            }
            return triangle;
        }
        public double EffectDamage(int indexKar1, int indexKar2)
        {
            var effectdmg = 1.0;
            if ((App.karakters[(indexKar1)].DraEffect && App.karakters[(indexKar2)].WapenType == "Dragon") || (App.karakters[(indexKar1)].InfEffect && App.karakters[(indexKar2)].MovementID == 2) || (App.karakters[(indexKar1)].GEffect && App.karakters[(indexKar2)].WapenType == "C") || (App.karakters[(indexKar1)].ArmorEffect && App.karakters[(indexKar2)].MovementID == 1) || (App.karakters[(indexKar1)].CavEffect && App.karakters[(indexKar2)].MovementID == 3) || (App.karakters[(indexKar1)].FlyEffect && App.karakters[(indexKar2)].MovementID == 4))
            {
                effectdmg = 1.5;
            }
            return effectdmg;
        }
        public double SpecialAtkIncrease(int indexKar)
        {
            var speAtkInc = 1.0;
            if (App.karakters[(indexKar)].AtkInc > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speAtkInc += (App.karakters[(indexKar)].AtkInc / 100);
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speAtkInc;
        }
        public double SpecialDmgIncrease(int indexKar)
        {
            var speDmgInc = 1.0;
            if (App.karakters[(indexKar)].DmgInc > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speDmgInc += (App.karakters[(indexKar)].DmgInc / 100);
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speDmgInc;
        }
        public double SpecialDefenseIngore(int indexKar)
        {
            var speDefIgn = 1.0;
            if (App.karakters[(indexKar)].DefIgn > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speDefIgn -= (App.karakters[(indexKar)].DmgInc / 100);
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speDefIgn;

        }
        public double SpecialProcentDefence(int indexKar)
        {
            var speProDef = 0.0;
            if (App.karakters[(indexKar)].ProDef > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speProDef += (App.karakters[(indexKar)].Def * (App.karakters[(indexKar)].ProDef / 100));
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speProDef;
        }
        public double SpecialProcentResistance(int indexKar)
        {
            var speProRes = 0.0;
            if (App.karakters[(indexKar)].ProRes > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speProRes += (App.karakters[(indexKar)].Res * (App.karakters[(indexKar)].ProRes / 100));
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speProRes;
        }
        public double SpecialProcentMissingHP(int indexKar)
        {
            var speProMissHP = 0.0;
            if (App.karakters[(indexKar)].ProMisHP > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speProMissHP += ((App.karakters[(indexKar)].MaxHp - App.karakters[(indexKar)].CurrentHP) * (App.karakters[(indexKar)].ProMisHP / 100));
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speProMissHP;
        }
        public double SpecialHealForDmg(int indexKar, double dmg)
        {
            var speProHeal = 0.0;
            if (App.karakters[(indexKar)].HealForDmg > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speProHeal += (dmg * (App.karakters[(indexKar)].HealForDmg / 100));
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speProHeal;

        }
        public double SpecialDamageReduction(int indexKar, double dmg)
        {
            var speDmgRed = 0.0;
            if (App.karakters[(indexKar)].DmgReduc > 0 && App.karakters[(indexKar)].SpecialCharge == 0)
            {
                speDmgRed += (dmg * (App.karakters[(indexKar)].DmgReduc / 100));
                App.karakters[indexKar].SpecialCharge = App.karakters[indexKar].SpecialBaseCD + App.karakters[indexKar].WapenModifier;
            }
            return speDmgRed;
        }
        public int PassiveAtkInc(int indexKar)
        {
            var inc = 0;
            switch (App.karakters[(indexKar)].SkillAID)
            {
                case 11:
                    if (App.karakters[(indexKar)].CurrentHP <= App.karakters[indexKar].MaxHp * 0.5)
                    {
                        inc += 7;
                    }
                    break;
            }
            return inc;
        }
        public int PassiveSpdInc(int indexKar)
        {
            var inc = 0;
            switch (App.karakters[(indexKar)].SkillAID)
            {
                case 25:
                    if (App.karakters[(indexKar)].CurrentHP <= App.karakters[indexKar].MaxHp * 0.5)
                    {
                        inc += 7;
                    }
                    break;
            }
            return inc;
        }
        public int PassiveDefInc(int indexKar)
        {
            var inc = 0;
            switch (App.karakters[(indexKar)].SkillAID)
            {
                case 33:
                    if (App.karakters[(indexKar)].CurrentHP <= App.karakters[indexKar].MaxHp * 0.5)
                    {
                        inc += 7;
                    }
                    break;
            }
            return inc;
        }
        public int DeathBlow(int indexKar)
        {
            var blow = 0;
            if (App.karakters[indexKar].SkillAID == 6)
            {
                blow = 6;
            }
            return blow;
        }
        public int DartingBlow(int indexKar)
        {
            var blow = 0;
            if (App.karakters[indexKar].SkillAID == 13)
            {
                blow = 6;
            }
            return blow;
        }
        public int ArmoredBlow(int indexKar1, int indexKar2)
        {
            var blow = 0;
            if (DamageType(indexKar2))
            {
                if (App.karakters[indexKar1].SkillAID == 14)
                {
                    blow = 6;
                }
            }

            return blow;
        }
        public int WardingBlow(int indexKar1, int indexKar2)
        {
            var blow = 0;
            if (!DamageType(indexKar2))
            {
                if (App.karakters[indexKar1].SkillAID == 8)
                {
                    blow = 6;
                }
            }
            return blow;
        }
        public bool WaryFighter(int indexKar)
        {
            bool check = false;
            if (App.karakters[indexKar].SkillBID == 1)
            {
                check = true;
            }
            return check;
        }
        public bool DaggerBreaker(int indexKar1, int indexKar2)
        {
            bool check = false;
            if (App.karakters[indexKar1].SkillBID == 3 && App.karakters[indexKar2].WapenType == "Dagger")
            {
                check = true;
            }
            return check;
        }
        public bool SwordBreaker(int indexKar1, int indexKar2)
        {
            bool check = false;
            if (App.karakters[indexKar1].SkillBID == 6 && App.karakters[indexKar2].WapenType == "Sword")
            {
                check = true;
            }
            return check;
        }
        public bool AxeBreaker(int indexKar1, int indexKar2)
        {
            bool check = false;
            if (App.karakters[indexKar1].SkillBID == 18 && App.karakters[indexKar2].WapenType == "Axe")
            {
                check = true;
            }
            return check;
        }
        public bool LanceBreaker(int indexKar1, int indexKar2)
        {
            bool check = false;
            if (App.karakters[indexKar1].SkillBID == 26 && App.karakters[indexKar2].WapenType == "Lance")
            {
                check = true;
            }
            return check;
        }
        public bool RTomeBreaker(int indexKar1, int indexKar2)
        {
            bool check = false;
            if (App.karakters[indexKar1].SkillBID == 27 && App.karakters[indexKar2].WapenType == "Tome" && App.karakters[indexKar2].WapenKleur == "R")
            {
                check = true;
            }
            return check;
        }
        public bool Riposte(int indexKar)
        {
            bool check = false;
            if (App.karakters[indexKar].SkillBID == 12 && App.karakters[indexKar].CurrentHP >= App.karakters[indexKar].MaxHp * 0.75)
            {
                check = true;
            }
            return check;
        }
        public bool Vantage(int indexKar)
        {
            bool check = false;
            if (App.karakters[indexKar].SkillBID == 13 && App.karakters[indexKar].CurrentHP <= App.karakters[indexKar].MaxHp * 0.5)
            {
                check = true;
            }
            return check;
        }
        public bool Brash(int indexKar)
        {
            bool check = false;
            if (App.karakters[indexKar].SkillBID == 30 && App.karakters[indexKar].CurrentHP >= App.karakters[indexKar].MaxHp * 0.5)
            {
                check = true;
            }
            return check;
        }
        public double SingleAttack(int indexKar1, int indexKar2, double triangle, double effectdmg)
        {
            var totaldmg = 0.0;
            var defenseType = DamageType(indexKar1) ? App.karakters[indexKar2].Res : App.karakters[indexKar2].Def;
            var baseatk = (App.karakters[(indexKar1)].Atk + PassiveAtkInc(indexKar1));
            totaldmg = ((baseatk + DeathBlow(indexKar1)) * SpecialAtkIncrease(indexKar1) * effectdmg * triangle) - ((defenseType + PassiveDefInc(indexKar2)) * SpecialDefenseIngore(indexKar1));
            totaldmg += SpecialProcentDefence(indexKar1) + SpecialProcentResistance(indexKar1) + SpecialProcentMissingHP(indexKar1);
            totaldmg *= SpecialDmgIncrease(indexKar1);
            totaldmg -= SpecialDamageReduction(indexKar2, totaldmg);
            totaldmg = Math.Round(totaldmg, 0);
            App.karakters[(indexKar1)].CurrentHP += Convert.ToInt32(SpecialHealForDmg(indexKar1, totaldmg));
            if (App.karakters[(indexKar1)].CurrentHP > App.karakters[(indexKar1)].MaxHp)
            {
                App.karakters[(indexKar1)].CurrentHP = App.karakters[(indexKar1)].MaxHp;
            }
            if (totaldmg < 0)
            {
                totaldmg = 0;
            }
            App.karakters[indexKar2].CurrentHP -= Convert.ToInt32(totaldmg);
            if (App.karakters[indexKar2].CurrentHP < 0)
            {
                App.karakters[indexKar2].CurrentHP = 0;
            }

            App.karakters[(indexKar1)].SpecialCharge -= 1; App.karakters[(indexKar2)].SpecialCharge -= 1;
            return totaldmg;
        }
        public double CounterAttack(int indexKar1, int indexKar2, bool dmgType, double triangle, double effectdmg)
        {
            var totaldmg = 0.0;
            var defenseType = DamageType(indexKar1) ? App.karakters[indexKar2].Res : App.karakters[indexKar2].Def;
            var baseatk = (App.karakters[(indexKar1)].Atk + PassiveAtkInc(indexKar1));

            totaldmg = (baseatk * SpecialAtkIncrease(indexKar1) * effectdmg * triangle) - ((defenseType + PassiveDefInc(indexKar2) + ArmoredBlow(indexKar1, indexKar2) + WardingBlow(indexKar1, indexKar2)) * SpecialDefenseIngore(indexKar1));
            totaldmg += SpecialProcentDefence(indexKar1) + SpecialProcentResistance(indexKar1) + SpecialProcentMissingHP(indexKar1);
            totaldmg *= SpecialDmgIncrease(indexKar1);
            totaldmg -= SpecialDamageReduction(indexKar2, totaldmg);
            totaldmg = Math.Round(totaldmg, 0);
            App.karakters[(indexKar1)].CurrentHP += Convert.ToInt32(SpecialHealForDmg(indexKar1, totaldmg));
            if (App.karakters[(indexKar1)].CurrentHP > App.karakters[(indexKar1)].MaxHp)
            {
                App.karakters[(indexKar1)].CurrentHP = App.karakters[(indexKar1)].MaxHp;
            }
            if (totaldmg < 0)
            {
                totaldmg = 0;
            }
            App.karakters[indexKar2].CurrentHP -= Convert.ToInt32(totaldmg);
            if (App.karakters[indexKar2].CurrentHP < 0)
            {
                App.karakters[indexKar2].CurrentHP = 0;
            }

            App.karakters[(indexKar1)].SpecialCharge -= 1; App.karakters[(indexKar2)].SpecialCharge -= 1;
            return totaldmg;
        }
        public void CombatPlayer(int indexKar1, int indexKar2, bool dmgType, double triangle, double effectdmg)
        {

            var playerTotalDmg = 0.0;
            var cpuTotalDmg = 0.0;

            var playerAtkCounter = 1;
            var cpuAttackCounter = 1;

            if ((App.karakters[(indexKar1)].Spd + PassiveSpdInc(indexKar1) + DartingBlow(indexKar1)) - (App.karakters[(indexKar2)].Spd + PassiveSpdInc(indexKar2)) > 5)
            {
                //speed check beat
                playerAtkCounter = 2;

                if (App.karakters[indexKar1].Brave)
                {
                    playerAtkCounter = 4;
                }
                if (DaggerBreaker(indexKar2, indexKar1) || SwordBreaker(indexKar2, indexKar1) || AxeBreaker(indexKar2, indexKar1) || LanceBreaker(indexKar2, indexKar1) || RTomeBreaker(indexKar2, indexKar1))
                {
                    playerAtkCounter = 1;
                    cpuAttackCounter = 2;
                    if (App.karakters[indexKar1].Brave)
                    {
                        playerAtkCounter = 2;
                    }
                }
            }
            else if ((App.karakters[(indexKar1)].Spd + PassiveSpdInc(indexKar1) + DartingBlow(indexKar1)) - (App.karakters[(indexKar2)].Spd + PassiveSpdInc(indexKar2)) < -5)
            {
                //speed check failed
                cpuAttackCounter = 2;
                if (DaggerBreaker(indexKar1, indexKar2) || SwordBreaker(indexKar1, indexKar2) || AxeBreaker(indexKar1, indexKar2) || LanceBreaker(indexKar1, indexKar2) || RTomeBreaker(indexKar1, indexKar2))
                {
                    playerAtkCounter = 2;
                    cpuAttackCounter = 1;
                }
                if (App.karakters[indexKar1].Brave)
                {
                    playerAtkCounter = 2;
                }
            }
            else
            {
                if (DaggerBreaker(indexKar2, indexKar1) || SwordBreaker(indexKar2, indexKar1) || AxeBreaker(indexKar2, indexKar1) || LanceBreaker(indexKar2, indexKar1) || RTomeBreaker(indexKar2, indexKar1))
                {
                    cpuAttackCounter = 2;
                }
                if (DaggerBreaker(indexKar1, indexKar2) || SwordBreaker(indexKar1, indexKar2) || AxeBreaker(indexKar1, indexKar2) || LanceBreaker(indexKar1, indexKar2) || RTomeBreaker(indexKar1, indexKar2))
                {
                    playerAtkCounter = 2;
                }
                if (App.karakters[indexKar1].Brave)
                {
                    playerAtkCounter = 2;
                }
            }
            if (WaryFighter(indexKar1) || WaryFighter(indexKar2))
            {
                playerAtkCounter = 1;
                cpuAttackCounter = 1;
                if (App.karakters[indexKar1].Brave)
                {
                    playerAtkCounter = 2;
                }
            }
            if (Riposte(indexKar2))
            {
                cpuAttackCounter = 2;
            }

            if (playerAtkCounter == 1 && cpuAttackCounter == 1)
            {
                if (!Vantage(indexKar2))
                {
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    }
                }
                else
                {
                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    if (App.karakters[(indexKar1)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2,triangle, effectdmg);
                    }
                }
            }
            else if (playerAtkCounter == 2 && cpuAttackCounter == 1)
            {

                if (!Vantage(indexKar2))
                {
                    if (!Brash(indexKar1))
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2,triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            if (App.karakters[(indexKar1)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                            }
                        }
                    }
                    else
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            }
                        }
                    }

                }
                else
                {
                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    if (App.karakters[(indexKar1)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        }
                    }
                }
            }
            else if (playerAtkCounter == 1 && cpuAttackCounter == 2)
            {
                if (!Vantage(indexKar2))
                {
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                        if (App.karakters[(indexKar1)].CurrentHP > 0)
                        {
                            cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                        }
                    }
                }
                else
                {
                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    if (App.karakters[(indexKar1)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                        }
                    }
                }
            }
            else if (playerAtkCounter == 2 && cpuAttackCounter == 2)
            {
                if (!Vantage(indexKar2))
                {
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            if (App.karakters[(indexKar1)].CurrentHP > 0)
                            {
                                cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            }
                        }
                    }
                }
                else
                {
                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    if (App.karakters[(indexKar1)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            }
                        }
                    }
                }
            }
            else if (playerAtkCounter == 4 && cpuAttackCounter == 1)
            {
                if (!Vantage(indexKar2))
                {
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                                if (App.karakters[(indexKar2)].CurrentHP > 0)
                                {
                                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                                }
                            }
                        }
                    }
                }
                else
                {
                    cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                    if (App.karakters[(indexKar1)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                                if (App.karakters[(indexKar2)].CurrentHP > 0)
                                {
                                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, triangle, effectdmg);
                                }
                            }
                        }
                    }
                }
            }

            if (App.karakters[(indexKar1)].CurrentHP > 0 && App.karakters[(indexKar2)].CurrentHP > 0)
            {
                //no1 died
            }
            else if (App.karakters[(indexKar1)].CurrentHP > 0)
            {
                //defending died
            }
            else
            {
                //attacking died
            }
        }
    }
}

