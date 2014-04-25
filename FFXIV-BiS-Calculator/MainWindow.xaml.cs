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

namespace FFXIVBISCALC {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();
    }

    double WEPWEIGHT = 0;
    double MAINWEIGHT = 0;
    double DTRWEIGHT = 0;
    double CRITWEIGHT = 0;
    double ACCWEIGHT = 0;
    double SKSWEIGHT = 0;
    int ACCCAP = 0;


    public class Item {
      public string name = "";
      public double WEP = 0;
      public double DEX = 0;
      public double ACC = 0;
      public double CRIT = 0;
      public double DTR = 0;
      public double SKS = 0;
    }

    public class Food {
      public string name = "";
      public double critmax = 0;
      public double dtrmax = 0;
      public double accmax = 0;
      public double sksmax = 0;
      public double critper = 0;
      public double dtrper = 0;
      public double accper = 0;
      public double sksper = 0;
    }

    public class GearSet {
      public Item weapon;
      public Item head;
      public Item body;
      public Item hands;
      public Item belt;
      public Item pants;
      public Item feet;
      public Item neck;
      public Item earrings;
      public Item wrists;
      public Item ring1;
      public Item ring2;
      public Food food;
      public double wepdmg;
      public double totaldex;
      public double bonusdex;
      public double totalcrit;
      public double bonuscrit;
      public double totaldtr;
      public double bonusdtr;
      public double totalacc;
      public double bonusacc;
      public double totalsks;
      public double bonussks;
      public double dpsscore;
    }

    Item highallagancompositebow = new HighAllaganCompositeBow();
    Item rosenbogen = new Rosenbogen();
    Item auroralcoif = new AuroralCoif();
    Item highallaganringofaiming = new HighAllaganRingOfAiming();
    Item auroralbrais = new AuroralBrais();
    Item auroralwristlets = new AuroralWristlets();
    Item highallaganglovesofaiming = new HighAllaganGlovesOfAiming();
    Item auroralring = new HighAllaganRingOfAiming();
    Item highallaganbeltofaiming = new HighAllaganBeltOfAiming();
    Item highallaganchokerofaiming = new HighAllaganChokerOfAiming();
    Item auroralbracers = new AuroralBracers();
    Item auroralsash = new AuroralSash();
    Item highallagancoatofaiming = new HighAllaganCoatOfAiming();
    Item auroralchoker = new AuroralChoker();
    Item highallaganbootsofaiming = new HighAllaganBootsOfAiming();
    Item highallaganearringsofaiming = new HighAllaganEarringsOfAiming();
    Item auroraltabard = new AuroralTabard();
    Item auroralboots = new AuroralBoots();
    Item highallaganmaskofaiming = new HighAllaganMaskOfAiming();
    Item auroralearrings = new AuroralEarrings();
    Item highallaganbreechesofaiming = new HighAllaganBreechesOfAiming();
    Item highallaganbraceletsofaiming = new HighAllaganBraceletsOfAiming();
    Food hqapkalluomelette = new HQApkalluOmelette();
    Food hqblacktrufflerisotto = new HQBlackTruffleRisotto();
    Food hqbuttonsinablanket = new HQButtonsInABlanket();
    Food hqdeviledeggs = new HQDeviledEggs();
    Food hqstuffedcabbage = new HQStuffedCabage();
    Food hqlavatoadlegs = new HQLavaToadLegs();

    public class HighAllaganCompositeBow : Item {
      public HighAllaganCompositeBow() {
        name = "High Allagan Composite Bow";
        WEP = 48;
        DEX = 45;
        ACC = 32;
        DTR = 32;
      }
    }

    public class Rosenbogen : Item {
      public Rosenbogen() {
        name = "Rosenbogen";
        WEP = 46;
        DEX = 42;
        CRIT = 31;
        SKS = 44;
      }
    }

    public class HighAllaganRingOfAiming : Item {
      public HighAllaganRingOfAiming() {
        name = "High Allagan Ring of Aiming";
        DEX = 18;
        DTR = 9;
        ACC = 19;
      }
    }

    public class HighAllaganGlovesOfAiming : Item {
      public HighAllaganGlovesOfAiming() {
        name = "High Allagan Gloves of Aiming";
        DEX = 24;
        DTR = 12;
        ACC = 25;
      }
    }

    public class HighAllaganBeltOfAiming : Item {
      public HighAllaganBeltOfAiming() {
        name = "High Allagan Belt of Aiming";
        DEX = 18;
        CRIT = 13;
        SKS = 19;
      }
    }

    public class HighAllaganChokerOfAiming : Item {
      public HighAllaganChokerOfAiming() {
        name = "High Allagan Choker of Aiming";
        DEX = 18;
        DTR = 9;
        CRIT = 19;
      }
    }

    public class HighAllaganCoatOfAiming : Item {
      public HighAllaganCoatOfAiming() {
        name = "High Allagan Coat of Aiming";
        DEX = 39;
        SKS = 29;
        CRIT = 41;
      }
    }

    public class HighAllaganBootsOfAiming : Item {
      public HighAllaganBootsOfAiming() {
        name = "High Allagan Boots of Aiming";
        DEX = 24;
        DTR = 12;
        ACC = 25;
      }
    }

    public class HighAllaganEarringsOfAiming : Item {
      public HighAllaganEarringsOfAiming() {
        name = "High Allagan Earrings of Aiming";
        DEX = 18;
        ACC = 13;
        SKS = 19;
      }
    }

    public class HighAllaganMaskOfAiming : Item {
      public HighAllaganMaskOfAiming() {
        name = "High Allagan Mask of Aiming";
        DEX = 24;
        DTR = 12;
        ACC = 25;
      }
    }

    public class HighAllaganBreechesOfAiming : Item {
      public HighAllaganBreechesOfAiming() {
        name = "High Allagan Breeches of Aiming";
        DEX = 39;
        SKS = 29;
        CRIT = 41;
      }
    }

    public class HighAllaganBraceletsOfAiming : Item {
      public HighAllaganBraceletsOfAiming() {
        name = "High Allagan Bracelets of Aiming";
        DEX = 18;
        CRIT = 13;
        SKS = 19;
      }
    }

    public class AuroralCoif : Item {
      public AuroralCoif() {
        name = "Auroral Coif";
        DEX = 24;
        ACC = 18;
        SKS = 25;
      }
    }

    public class AuroralBrais : Item {
      public AuroralBrais() {
        name = "Auroral Brais";
        DEX = 39;
        DTR = 20;
        SKS = 41;
      }
    }

    public class AuroralWristlets : Item {
      public AuroralWristlets() {
        name = "Auroral Wristlets";
        DEX = 18;
        CRIT = 13;
        ACC = 19;
      }
    }

    public class AuroralRing : Item {
      public AuroralRing() {
        name = "Auroral Ring";
        DEX = 18;
        ACC = 13;
        SKS = 19;
      }
    }

    public class AuroralBracers : Item {
      public AuroralBracers() {
        name = "Auroral Bracers";
        DEX = 24;
        SKS = 18;
        ACC = 25;
      }
    }

    public class AuroralSash : Item {
      public AuroralSash() {
        name = "Auroral Sash";
        DEX = 18;
        DTR = 9;
        CRIT = 19;
      }
    }

    public class AuroralChoker : Item {
      public AuroralChoker() {
        name = "Auroral Choker";
        DEX = 18;
        DTR = 13;
        ACC = 13;
      }
    }

    public class AuroralTabard : Item {
      public AuroralTabard() {
        name = "Auroral Tabard";
        DEX = 39;
        DTR = 20;
        CRIT = 41;
      }
    }

    public class AuroralBoots : Item {
      public AuroralBoots() {
        name = "Auroral Boots";
        DEX = 24;
        ACC = 18;
        SKS = 25;
      }
    }

    public class AuroralEarrings : Item {
      public AuroralEarrings() {
        name = "Auroral Earrings";
        DEX = 18;
        CRIT = 13;
        DTR = 19;
      }
    }

    public class HQSteamedCatfish : Food {
      public HQSteamedCatfish() {
        name = "HQ Steamed Catfish";
        critmax = 0;
        critper = 0;
        accmax = 0;
        accper = 0;
      }
    }

    public class HQLavaToadLegs : Food {
      public HQLavaToadLegs() {
        name = "HQ Lava Toad Legs";
        accmax = 27;
        accper = 0.05;
        critmax = 11;
        critper = 0.02;
      }
    }

    public class HQStuffedCabage : Food {
      public HQStuffedCabage() {
        name = "HQ Stuffed Cabbage";
        accmax = 21;
        accper = 0.05;
        critmax = 9;
        critper = 0.02;
      }
    }

    public class HQButtonsInABlanket : Food {
      public HQButtonsInABlanket() {
        name = "HQ Buttons in a Blanket";
        dtrmax = 16;
        dtrper = 0.05;
        critmax = 10;
        critper = 0.02;
      }
    }

    public class HQBlackTruffleRisotto : Food {
      public HQBlackTruffleRisotto() {
        name = "HQ Black Truffle Risotto";
        dtrmax = 17;
        dtrper = 0.05;
        critper = 0.02;
        critmax = 11;
      }
    }

    public class HQApkalluOmelette : Food {
      public HQApkalluOmelette() {
        name = "HQ Apkallu Omelette";
        critmax = 27;
        critper = 0.05;
        accmax = 11;
        accper = 0.02;
      }
    }

    public class HQDeviledEggs : Food {
      public HQDeviledEggs() {
        name = "HQ Deviled Eggs";
        critmax = 24;
        critper = 0.05;
        accmax = 10;
        accper = 0.02;
      }
    }


    public void makelists() {
      //initialize variables
      List<Item> weaponsl = new List<Item>();
      List<Item> headsl = new List<Item>();
      List<Item> bodiesl = new List<Item>();
      List<Item> handsl = new List<Item>();
      List<Item> beltsl = new List<Item>();
      List<Item> pantsl = new List<Item>();
      List<Item> feetl = new List<Item>();
      List<Item> necksl = new List<Item>();
      List<Item> earringls = new List<Item>();
      List<Item> wristsl = new List<Item>();
      List<Item> ringsl = new List<Item>();
      List<Food> foods = new List<Food>();

      //add checked Objects to lists
      if ((bool)highallaganweapon.IsChecked) { weaponsl.Add(highallagancompositebow); }
      if ((bool)ilvl110soldweapon.IsChecked) { weaponsl.Add(rosenbogen); }
      /*if ((bool)ilvl100soldweapon.IsChecked) { weaponsl.Add("ilvl100soldweapon"); }
      if ((bool)allaganweapon.IsChecked) { weaponsl.Add("allaganweapon"); }
      if ((bool)zenithweapon.IsChecked) { weaponsl.Add("zenithweapon"); }
      if ((bool)ilvl100leviweapon.IsChecked) { weaponsl.Add("ilvl100leviweapon"); }
      if ((bool)ilvl95leviweapon.IsChecked) { weaponsl.Add("ilvl95leviweapon"); }
      if ((bool)atmaweapon.IsChecked) { weaponsl.Add("atmaweapon"); }
      if ((bool)animusweapon.IsChecked) { weaponsl.Add("animusweapon"); }*/

      if ((bool)highallaganhead.IsChecked) { headsl.Add(highallaganmaskofaiming); }
      if ((bool)ilvl110soldhead.IsChecked) { headsl.Add(auroralcoif); }
      /*if ((bool)ilvl100soldhead.IsChecked) { headsl.Add("ilvl100soldhead"); }
      if ((bool)allaganhead.IsChecked) { headsl.Add("allaganhead"); }
      if ((bool)mythhead.IsChecked) { headsl.Add("mythhead"); }*/

      if ((bool)highallaganbody.IsChecked) { bodiesl.Add(highallagancoatofaiming); }
      if ((bool)ilvl110soldbody.IsChecked) { bodiesl.Add(auroraltabard); }
      /*if ((bool)ilvl100soldbody.IsChecked) { bodiesl.Add("ilvl100soldbody"); }
      if ((bool)allaganbody.IsChecked) { bodiesl.Add("allaganbody"); }
      if ((bool)mythbody.IsChecked) { bodiesl.Add("mythbody"); }*/

      if ((bool)highallaganhands.IsChecked) { handsl.Add(highallaganglovesofaiming); }
      if ((bool)ilvl110soldhands.IsChecked) { handsl.Add(auroralbracers); }
      /*if ((bool)ilvl100soldhands.IsChecked) { handsl.Add("ilvl100soldhands"); }
      if ((bool)allaganhands.IsChecked) { handsl.Add("allaganhands"); }
      if ((bool)mythhands.IsChecked) { handsl.Add("mythhands"); }*/

      if ((bool)highallaganbelt.IsChecked) { beltsl.Add(highallaganbeltofaiming); }
      if ((bool)ilvl110soldbelt.IsChecked) { beltsl.Add(auroralsash); }
      /*if ((bool)ilvl100soldbelt.IsChecked) { beltsl.Add("ilvl100soldbelt"); }
      if ((bool)allaganbelt.IsChecked) { beltsl.Add("allaganblelt"); }
      if ((bool)mythbelt.IsChecked) { beltsl.Add("mythbelt"); }*/

      if ((bool)highallaganpants.IsChecked) { pantsl.Add(highallaganbreechesofaiming); }
      if ((bool)ilvl110soldpants.IsChecked) { pantsl.Add(auroralbrais); }
      /*if ((bool)ilvl100soldpants.IsChecked) { pantsl.Add("ilvl100soldpants"); }
      if ((bool)allaganpants.IsChecked) { pantsl.Add("allaganpants"); }
      if ((bool)mythpants.IsChecked) { pantsl.Add("mythpants"); }*/

      if ((bool)highallaganfeet.IsChecked) { feetl.Add(highallaganbootsofaiming); }
      if ((bool)ilvl110soldfeet.IsChecked) { feetl.Add(auroralboots); }
      /*if ((bool)ilvl100soldfeet.IsChecked) { feetl.Add("ilvl100soldfeet"); }
      if ((bool)allaganfeet.IsChecked) { feetl.Add("allaganfeet"); }
      if ((bool)mythfeet.IsChecked) { feetl.Add("mythfeet"); }*/

      if ((bool)highallaganneck.IsChecked) { necksl.Add(highallaganchokerofaiming); }
      if ((bool)ilvl110soldneck.IsChecked) { necksl.Add(auroralchoker); }
      /*if ((bool)ilvl100soldneck.IsChecked) { necksl.Add("ilvl100soldneck"); }
      if ((bool)allaganneck.IsChecked) { necksl.Add("allaganneck"); }
      if ((bool)mythneck.IsChecked) { necksl.Add("mythneck"); }
      if ((bool)moogleneck.IsChecked) { necksl.Add("moogleneck"); }*/

      if ((bool)highallaganearrings.IsChecked) { earringls.Add(highallaganearringsofaiming); }
      if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add(auroralearrings); }
      /*if ((bool)ilvl100soldearrings.IsChecked) { earringls.Add("ilvl100soldearrings"); }
      if ((bool)allaganearrings.IsChecked) { earringls.Add("allaganearrings"); }
      if ((bool)mythearrings.IsChecked) { earringls.Add("mythearrings"); }
      if ((bool)titanearrings.IsChecked) { earringls.Add("titanearrings"); } */

      if ((bool)highallaganwrists.IsChecked) { wristsl.Add(highallaganbraceletsofaiming); }
      if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add(auroralwristlets); }
      /*if ((bool)ilvl100soldwrists.IsChecked) { wristsl.Add("ilvl100soldwrists"); }
      if ((bool)allaganwrists.IsChecked) { wristsl.Add("allaganwrists"); }
      if ((bool)mythwrists.IsChecked) { wristsl.Add("mythwrists"); }
      if ((bool)ifritwrists.IsChecked) { wristsl.Add("ifritwirsts"); }*/

      if ((bool)highallaganring.IsChecked) { ringsl.Add(highallaganringofaiming); }
      if ((bool)ilvl110soldring.IsChecked) { ringsl.Add(auroralring); }
      /*if ((bool)ilvl100soldring.IsChecked) { ringsl.Add("ilvl100soldring"); }
      if ((bool)allaganring.IsChecked) { ringsl.Add("allaganring"); }
      if ((bool)mythring.IsChecked) { ringsl.Add("mythring"); }
      if ((bool)garudaring.IsChecked) { ringsl.Add("garudaring"); } */

      foods.Add(hqapkalluomelette);
      foods.Add(hqblacktrufflerisotto);
      foods.Add(hqdeviledeggs);
      foods.Add(hqlavatoadlegs);
      foods.Add(hqbuttonsinablanket);
      foods.Add(hqstuffedcabbage);

      //convert to arrays
      Item[] weaponsarr = weaponsl.ToArray();
      Item[] headsarr = headsl.ToArray();
      Item[] bodiesarr = bodiesl.ToArray();
      Item[] handsarr = handsl.ToArray();
      Item[] beltsarr = beltsl.ToArray();
      Item[] pantsarr = pantsl.ToArray();
      Item[] feetarr = feetl.ToArray();
      Item[] necksarr = necksl.ToArray();
      Item[] earringsarr = earringls.ToArray();
      Item[] wristsarr = wristsl.ToArray();
      Item[] ringsarr = ringsl.ToArray();
      Food[] foodarr = foods.ToArray();
      //string[] foodarr = { "buttonsinablanket", "apkalluomelette" };

      //carteisan product
      var gearsets = (from weapon in weaponsarr
                      from head in headsarr
                      from body in bodiesarr
                      from hands in handsarr
                      from belt in beltsarr
                      from pants in pantsarr
                      from feet in feetarr
                      from neck in necksarr
                      from earrings in earringsarr
                      from wrists in wristsarr
                      from ring1 in ringsarr
                      from ring2 in ringsarr where ring2 != ring1
                      from food in foodarr
                      select new List<object> { weapon, head, body, hands, belt, pants, feet, neck, earrings, wrists, ring1, ring2, food }).ToList();

      List<GearSet> GearSets = new List<GearSet>();
      for (var x = 0; x < gearsets.Count - 1; x++) {
        GearSet TempGearSet = new GearSet();
        TempGearSet.weapon = (Item)gearsets[x][0];
        TempGearSet.head = (Item)gearsets[x][1];
        TempGearSet.body = (Item)gearsets[x][2];
        TempGearSet.hands = (Item)gearsets[x][3];
        TempGearSet.belt = (Item)gearsets[x][4];
        TempGearSet.pants = (Item)gearsets[x][5];
        TempGearSet.feet = (Item)gearsets[x][6];
        TempGearSet.neck = (Item)gearsets[x][7];
        TempGearSet.earrings = (Item)gearsets[x][8];
        TempGearSet.wrists = (Item)gearsets[x][9];
        TempGearSet.ring1 = (Item)gearsets[x][10];
        TempGearSet.ring2 = (Item)gearsets[x][11];
        TempGearSet.food = (Food)gearsets[x][12];

        double WEP = 0;
        double DEX = 274;
        double ACC = 341;
        double CRIT = 341;
        double DTR = 202;
        double SKS = 341;

        //sum of stats
        for (var y = 0; y < gearsets[x].Count - 2; y++) {
          WEP += ((Item)gearsets[x][y]).WEP;
          DEX += ((Item)gearsets[x][y]).DEX;
          ACC += ((Item)gearsets[x][y]).ACC;
          CRIT += ((Item)gearsets[x][y]).CRIT;
          DTR += ((Item)gearsets[x][y]).DTR;
          SKS += ((Item)gearsets[x][y]).SKS;
        }

        //food
        if (ACC * ((Food)gearsets[x][12]).accper > ((Food)gearsets[x][12]).accmax) {
          ACC += ((Food)gearsets[x][12]).accmax;
        } else { ACC += Math.Floor((ACC + 341) * ((Food)gearsets[x][12]).accper); }
        if (CRIT * ((Food)gearsets[x][12]).critper > ((Food)gearsets[x][12]).critper) {
          CRIT += ((Food)gearsets[x][12]).critmax;
        } else { CRIT += Math.Floor((CRIT + 341) * ((Food)gearsets[x][12]).critper); }
        if (DTR * ((Food)gearsets[x][12]).dtrper > ((Food)gearsets[x][12]).dtrper) {
          DTR += ((Food)gearsets[x][12]).dtrper;
        } else { DTR += Math.Floor((DTR + 341) * ((Food)gearsets[x][12]).dtrper); }
        if (SKS * ((Food)gearsets[x][12]).sksper > ((Food)gearsets[x][12]).sksper) {
          SKS += ((Food)gearsets[x][12]).sksper;
        } else { SKS += Math.Floor((SKS + 341) * ((Food)gearsets[x][12]).sksper); }

        //create object
        TempGearSet.wepdmg = WEP;
        TempGearSet.totaldex = DEX;
        TempGearSet.bonusdex = DEX - 274;
        TempGearSet.totalacc = ACC;
        TempGearSet.bonusacc = ACC - 341;
        TempGearSet.totalcrit = CRIT;
        TempGearSet.bonuscrit = CRIT - 341;
        TempGearSet.totaldtr = DTR;
        TempGearSet.bonusdtr = DTR - 202;
        TempGearSet.totalsks = SKS;
        TempGearSet.bonussks = SKS - 341;

        //acc cap 
        double calcdacc = 0;
        if (TempGearSet.totalacc > ACCCAP) {
          calcdacc = ACCCAP - 341;
        } else { calcdacc = TempGearSet.bonusacc; }

        //dps score
        TempGearSet.dpsscore = TempGearSet.wepdmg * WEPWEIGHT + TempGearSet.bonusdex * MAINWEIGHT + calcdacc * ACCWEIGHT + TempGearSet.bonuscrit * CRITWEIGHT + TempGearSet.bonusdtr * DTRWEIGHT + TempGearSet.bonussks * SKSWEIGHT;

        GearSets.Add(TempGearSet);
      }

      
      GearSets = GearSets.Distinct().ToList();


      GearSets = GearSets.OrderBy(x => x.dpsscore).ToList();
      

      Results.Text = "";
      var count = 1;
      for (var x = GearSets.Count - 1; x >= GearSets.Count - 5; x--) {
        
        Results.Text += "Gear Set: " + count;
        count += 1;
        Results.Text += Environment.NewLine;
        Results.Text += "Weapon: " + GearSets[x].weapon.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Head: " + GearSets[x].head.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Body: " + GearSets[x].body.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Hands: " + GearSets[x].hands.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Belt: " + GearSets[x].belt.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Pants: " + GearSets[x].pants.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Feet: " + GearSets[x].feet.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Neck: " + GearSets[x].neck.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Earrings: " + GearSets[x].earrings.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Wrists: " + GearSets[x].wrists.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Ring 1: " + GearSets[x].ring1.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Ring 2: " + GearSets[x].ring2.name;
        Results.Text += Environment.NewLine;
        Results.Text += "Food: " + GearSets[x].food.name;
        Results.Text += Environment.NewLine;
        Results.Text += "WepDmg: " + GearSets[x].wepdmg + "  Dex: " + GearSets[x].totaldex;
        Results.Text += Environment.NewLine;
        Results.Text += "Acc: " + GearSets[x].totalacc + "  Crit: " + GearSets[x].totalcrit;
        Results.Text += Environment.NewLine;
        Results.Text += "Dtr: " + GearSets[x].totaldtr + "  Sks: " + GearSets[x].totalsks;
        Results.Text += Environment.NewLine;
        Results.Text += "Score: " + GearSets[x].dpsscore;
        Results.Text += Environment.NewLine;
        Results.Text += Environment.NewLine;

      }


    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      calculate();
    }

    public void calculate() {
      WEPWEIGHT = Convert.ToDouble(WepWeight.Text);
      MAINWEIGHT = Convert.ToDouble(MainWeight.Text);
      CRITWEIGHT = Convert.ToDouble(CritWeight.Text);
      DTRWEIGHT = Convert.ToDouble(DetWeight.Text);
      SKSWEIGHT = Convert.ToDouble(SksWeight.Text);
      ACCWEIGHT = Convert.ToDouble(AccWeight.Text);
      ACCCAP = Convert.ToInt32(AccCap.Text);

      makelists();
    }


  }
}
