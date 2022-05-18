using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static List<Karakter> karakters = new List<Karakter>();
        public static List<Karakter> playerChar = new List<Karakter>();
        public static List<Karakter> cpuChar = new List<Karakter>();

        public static int indexPlayer1 = 0; public static int indexPlayer2 = 0; public static int indexPlayer3 = 0; public static int indexPlayer4 = 0;
        public static int indexCpu1 = 0; public static int indexCpu2 = 0; public static int indexCpu3 = 0; public static int indexCpu4 = 0;
        public static bool hard = false; public static bool lunatic = false; public static bool spelerRandom = false; public static bool cpuRandom = false;
        public static int turn = 0; public static int charcount = 0; public static bool selectchar = true; public static bool cput = false;
        public static int previousColumn = 9; public static int previousRow = 9; 
        public static ImageBrush previousBrush = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Gebruiker\Desktop\School 21-22\Project Sharp Emblem V0.2\Sharp Emblem\Sharp Emblem\Pictures\Battle Numbers1.png", UriKind.Relative)));
        public static SolidColorBrush originalP1Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalP2Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalP3Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalP4Brush = new SolidColorBrush(Colors.Red);
        public static SolidColorBrush originalC1Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalC2Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalC3Brush = new SolidColorBrush(Colors.Red); public static SolidColorBrush originalC4Brush = new SolidColorBrush(Colors.Red);


        public App()
        {
            using (var db = new sharpemblemContext())
            {
                var dbkarakters = db.TKarakters.ToList();
                var dbWapens = db.TWapens.ToList();
                var dbSpecials = db.TSpeciaals.ToList();
                var dbMovements = db.TBewegings.ToList();
                var dbSkillAs = db.TAskills.ToList();
                var dbSkillBs = db.TBskills.ToList();
                var dbSkillCs = db.TCskills.ToList();
                var dbkarakterMovementsLink = db.TTussenkarmovs.ToList();
                var dbkarakterWapenLink = db.TTussenkarwapens.ToList();
                var dbkarakterSpecialLink = db.TTussenkarspecs.ToList();
                var dbkarakterSkillALink = db.TTussenkaras.ToList();
                var dbkarakterSkillBLink = db.TTussenkarbs.ToList();
                var dbkarakterSkillCLink = db.TTussenkarcs.ToList();

                foreach (var k in dbkarakters)
                {
                    var karakter = new Karakter(k.CharId, k.DNaam, k.DHp, k.DHp, k.DAtk, k.DSpd, k.DDef, k.DRes, 0, 0, false, false, 0, "", 0, "", 0, "", 0, "", 0, "", "", 0, false, false, false, false, false, false, false, false, false, false, false, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                                0,
                                                9, 9);

                    int i = 0;

                    foreach (var kmlink in dbkarakterMovementsLink)
                    {
                        if (kmlink.CharId == k.CharId)
                        {
                            karakter.MovementID = dbkarakterMovementsLink[i].MovementId;
                            foreach (var mov in dbMovements)
                            {
                                if (karakter.MovementID == mov.MovementId)
                                {
                                    karakter.Movement = mov.DMov;
                                    karakter.FlyMov = mov.DFly;
                                    karakter.CavMov = mov.DCav;
                                    break;
                                }
                            }
                        }
                        i++;
                    }
                    i = 0;
                    foreach (var kwlink in dbkarakterWapenLink)
                    {
                        if (kwlink.CharId == k.CharId)
                        {
                            karakter.WapenID = dbkarakterWapenLink[i].WeaponId;
                            foreach (var wap in dbWapens)
                            {
                                if (karakter.WapenID == wap.WeaponId)
                                {
                                    karakter.WapenName = wap.DNaam; karakter.WapenKracht = wap.DKracht;
                                    karakter.WapenType = wap.DType; karakter.WapenKleur = wap.DKleur;
                                    karakter.WapenModifier = wap.DCooldownEffect; karakter.DistantC = wap.DDc;
                                    karakter.Gem = wap.DGem; karakter.DraEffect = wap.DDraEffect;
                                    karakter.InfEffect = wap.DInfEffect; karakter.GEffect = wap.DColorEffect;
                                    karakter.ArmorEffect = wap.DArmorEffect; karakter.CavEffect = wap.DCavEffect;
                                    karakter.FlyEffect = wap.DFlyEffect; karakter.Brave = wap.DBrave;
                                    karakter.Killer = wap.DKiller; karakter.BladeTome = wap.DBladetome;
                                    if (karakter.Brave)
                                    {
                                        karakter.Spd += -5;
                                    }
                                    break;
                                }
                            }
                        }
                        i++;
                    }
                    i = 0;
                    foreach (var kslink in dbkarakterSpecialLink)
                    {
                        if (kslink.CharId == k.CharId)
                        {
                            karakter.SpecialID = dbkarakterSpecialLink[i].SpecialId;
                            foreach (var spe in dbSpecials)
                            {
                                if (karakter.SpecialID == spe.SpecialId)
                                {
                                    karakter.SpecialName = spe.DNaam; karakter.SpecialBaseCD = spe.DCooldown;
                                    karakter.AtkInc = spe.DAtkInc; karakter.DefIgn = spe.DDefIng;
                                    karakter.ProRes = spe.DProOfRes; karakter.ProDef = spe.DProOfDef;
                                    karakter.ProMisHP = spe.DProOfMissHp; karakter.DmgReduc = spe.DDmgReduc;
                                    karakter.DmgInc = spe.DDmgIncre; karakter.HealForDmg = spe.DHealForDmg;
                                    karakter.SpecialCharge = karakter.SpecialBaseCD + karakter.WapenModifier;
                                    if (karakter.Killer)
                                    {
                                        karakter.SpecialCharge = karakter.SpecialBaseCD - 1;
                                    }
                                    break;
                                }
                            }
                        }
                        i++;
                    }
                    i = 0;
                    foreach (var kalink in dbkarakterSkillALink)
                    {
                        if (kalink.CharId == k.CharId)
                        {
                            karakter.SkillAID = dbkarakterSkillALink[i].ASkillId;
                            foreach (var a in dbSkillAs)
                            {
                                if (karakter.SkillAID == a.ASkillId)
                                {
                                    karakter.SkillAName = a.DNaam;
                                    switch (karakter.SkillAID)
                                    {
                                        case 1:
                                            karakter.Spd += 3;
                                            break;
                                        case 7:
                                            karakter.Res += 3;
                                            break;
                                        case 10:
                                            karakter.Def += 3;
                                            break;
                                        case 15:
                                            karakter.MaxHp += 5;
                                            break;
                                        case 20:
                                            karakter.Atk += 3; karakter.Spd += 3;
                                            karakter.Res += 3; karakter.Def += 3;
                                            break;
                                        case 22:
                                            karakter.Atk += 3;
                                            break;
                                        case 24:
                                            karakter.Atk += 5; karakter.Spd += 5;
                                            karakter.Res += -5; karakter.Def += -5;
                                            break;
                                    }
                                    break;
                                }
                            }
                        }
                        i++;
                    }
                    i = 0;
                    foreach (var kblink in dbkarakterSkillBLink)
                    {
                        if (kblink.CharId == k.CharId)
                        {
                            karakter.SkillBID = dbkarakterSkillBLink[i].BSkillId;
                            foreach (var b in dbSkillBs)
                            {
                                if (karakter.SkillBID == b.BSkillId)
                                {
                                    karakter.SkillBName = b.DNaam;
                                    break;
                                }
                            }
                        }
                        i++;
                    }
                    i = 0;
                    foreach (var kclink in dbkarakterSkillCLink)
                    {
                        if (kclink.CharId == k.CharId)
                        {
                            karakter.SkillCID = dbkarakterSkillCLink[i].CSkillId;
                            foreach (var c in dbSkillCs)
                            {
                                if (karakter.SkillCID == c.CSkillId)
                                {
                                    karakter.SkillCName = c.DNaam;
                                    break;
                                }
                            }
                        }
                        i++;
                    }

                    karakters.Add(karakter);
                }
            }
        }
        public class Karakter
        {
            public int Id;
            public string Name;
            public int MaxHp; public int CurrentHP; public int Atk; public int Spd; public int Def; public int Res;
            public int MovementID; public int Movement; public bool FlyMov; public bool CavMov;
            public int SkillAID; public string SkillAName; public int SkillBID; public string SkillBName; public int SkillCID; public string SkillCName;
            public int WapenID; public string WapenName; public int WapenKracht; public string WapenType; public string WapenKleur; public int WapenModifier;
            public bool DistantC; public bool Gem; public bool DraEffect; public bool InfEffect; public bool GEffect; public bool ArmorEffect; public bool CavEffect; public bool FlyEffect;
            public bool Brave; public bool Killer; public bool BladeTome;
            public int SpecialID; public string SpecialName; public int SpecialBaseCD; public int AtkInc; public int DefIgn; public int ProRes; public int ProDef; public int ProMisHP;
            public int DmgReduc; public int DmgInc; public int HealForDmg;
            public int SpecialCharge;
            public double Xcord; public double Ycord;

            public Karakter(int id, string naam, int maxhp, int currenthp, int atk, int spd, int def, int res,
                int movementID, int movement, bool flyMov, bool cavMov,
                int skillAID, string skillAName, int skillBID, string skillBName, int skillCID, string skillCName,
                int wapenID, string wapenName, int wapenKracht, string wapenType, string wapenKleur, int wapenModifier,
                bool distantC, bool gem, bool draEffect, bool infEffect, bool gEffect, bool armorEffect, bool cavEffect, bool flyEffect, bool brave, bool killer, bool bladeTome,
                int specialID, string specialName, int specialBaseCD, int atkInc, int defIgn, int proRes, int proDef, int proMisHP, int dmgReduc, int dmgInc, int healForDmg,
                int specialCharge,
                double xcord, double ycord)
            {
                Id = id;
                Name = naam;
                MaxHp = maxhp; CurrentHP = currenthp; Atk = atk; Spd = spd; Def = def; Res = res;
                MovementID = movementID; Movement = movement; FlyMov = flyMov; CavMov = cavMov;
                SkillAID = skillAID; SkillAName = skillAName;
                SkillBID = skillBID; SkillBName = skillBName;
                SkillCID = skillCID; SkillCName = skillCName;
                WapenID = wapenID; WapenName = wapenName; WapenKracht = wapenKracht; WapenType = wapenType; WapenKleur = wapenKleur; WapenModifier = wapenModifier;
                DistantC = distantC; Gem = gem; DraEffect = draEffect; InfEffect = infEffect; GEffect = gEffect; ArmorEffect = armorEffect; CavEffect = cavEffect; FlyEffect = flyEffect; Brave = brave; Killer = killer; BladeTome = bladeTome;
                SpecialID = specialID; SpecialName = specialName; SpecialBaseCD = specialBaseCD; AtkInc = atkInc; DefIgn = defIgn; ProRes = proRes; ProDef = proDef; ProMisHP = proMisHP; ProMisHP = proMisHP; DmgReduc = dmgReduc; DmgInc = dmgInc; HealForDmg = healForDmg;
                SpecialCharge = specialCharge;
                Xcord = xcord;
                Ycord = ycord;
            }
        }

        
    }
}
