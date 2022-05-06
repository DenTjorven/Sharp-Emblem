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
    /// Interaction logic for BattleSim.xaml
    /// </summary>
    public partial class BattleSim : Page
    {
        public BattleSim()
        {

            InitializeComponent();

            foreach (var karakter in App.karakters)
            {
                PlayerBox.Items.Add(karakter.Name);
                CpuBox.Items.Add(karakter.Name);

            }
        }

        private void CpuBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IndexPlayer1();
            IndexCpu1();
            CombatPlayer(App.indexPlayer1, App.indexCpu1, DamageType(App.indexPlayer1), WeaponTriangle(App.indexPlayer1, App.indexCpu1), EffectDamage(App.indexPlayer1, App.indexCpu1));
        }

        private void PlayerBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IndexPlayer1();
            IndexCpu1();
            CombatPlayer(App.indexPlayer1, App.indexCpu1, DamageType(App.indexPlayer1), WeaponTriangle(App.indexPlayer1, App.indexCpu1), EffectDamage(App.indexPlayer1, App.indexCpu1));

        }

        public void IndexPlayer1()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)PlayerBox.SelectedItem == karakter.Name)
                {
                    App.indexPlayer1 = App.karakters.IndexOf(karakter);
                }

            }
        }
        public void IndexCpu1()
        {
            foreach (var karakter in App.karakters)
            {
                if ((string)CpuBox.SelectedItem == karakter.Name)
                {
                    App.indexCpu1 = App.karakters.IndexOf(karakter);
                }

            }
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
        public double SingleAttack(int indexKar1, int indexKar2, bool dmgType, double triangle, double effectdmg)
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
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                    }
                }
            }
            else if (playerAtkCounter == 2 && cpuAttackCounter == 1)
            {

                if (!Vantage(indexKar2))
                {
                    if (!Brash(indexKar1))
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            cpuTotalDmg += CounterAttack(indexKar2, indexKar1, DamageType(indexKar2), WeaponTriangle(indexKar2, indexKar1), EffectDamage(indexKar2, indexKar1));
                            if (App.karakters[(indexKar1)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                            }
                        }
                    }
                    else
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        }
                    }
                }
            }
            else if (playerAtkCounter == 1 && cpuAttackCounter == 2)
            {
                if (!Vantage(indexKar2))
                {
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                    if (App.karakters[(indexKar2)].CurrentHP > 0)
                    {
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
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
                        playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                        if (App.karakters[(indexKar2)].CurrentHP > 0)
                        {
                            playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                            if (App.karakters[(indexKar2)].CurrentHP > 0)
                            {
                                playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                                if (App.karakters[(indexKar2)].CurrentHP > 0)
                                {
                                    playerTotalDmg += SingleAttack(indexKar1, indexKar2, dmgType, triangle, effectdmg);
                                }
                            }
                        }
                    }
                }
            }

            if (App.karakters[(indexKar1)].CurrentHP > 0 && App.karakters[(indexKar2)].CurrentHP > 0)
            {
                Round1.Text = $"Indecisive outcome:  {App.karakters[indexKar1].Name} inflicts a total of {playerTotalDmg} damage" + Environment.NewLine +
                $"to {App.karakters[(indexKar2)].Name} reducing their hp to {App.karakters[indexKar2].CurrentHP}" + Environment.NewLine +
                $"{App.karakters[indexKar2].Name} inflicts a total of {cpuTotalDmg} damage" + Environment.NewLine +
                $"to {App.karakters[(indexKar1)].Name} reducing their hp to {App.karakters[indexKar1].CurrentHP}" + Environment.NewLine +
                $"(player attack count is {playerAtkCounter}, cpu attack count is {cpuAttackCounter})";
            }
            else if (App.karakters[(indexKar1)].CurrentHP > 0)
            {
                Round1.Text = $"Attacking Character Wins Combat:  {App.karakters[indexKar1].Name} inflicts a total of {playerTotalDmg} damage" + Environment.NewLine +
                $"to {App.karakters[(indexKar2)].Name} reducing their hp to {App.karakters[indexKar2].CurrentHP}, killing them. Leaving themselves with {App.karakters[indexKar1].CurrentHP}." + Environment.NewLine +
                $"(player attack count is {playerAtkCounter}, cpu attack count is {cpuAttackCounter})";
            }
            else
            {
                Round1.Text = $"Defending Character Wins Combat:  {App.karakters[indexKar2].Name} inflicts a total of {cpuTotalDmg} damage" + Environment.NewLine +
                $"to {App.karakters[(indexKar1)].Name} reducing their hp to {App.karakters[indexKar1].CurrentHP}, killing them. Leaving themselves with {App.karakters[indexKar2].CurrentHP}." + Environment.NewLine +
                $"(player attack count is {playerAtkCounter}, cpu attack count is {cpuAttackCounter})";
            }


            App.karakters[indexKar2].CurrentHP = App.karakters[indexKar2].MaxHp; App.karakters[indexKar1].CurrentHP = App.karakters[indexKar1].MaxHp;
            App.karakters[indexKar2].SpecialCharge = App.karakters[indexKar2].SpecialBaseCD + App.karakters[(indexKar2)].WapenModifier; App.karakters[indexKar1].SpecialCharge = App.karakters[indexKar1].SpecialBaseCD + App.karakters[(indexKar1)].WapenModifier;
        }
    }
}

