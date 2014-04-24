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
    public class Item {
      public string name = "";
      public int WEP = 0;
      public int DEX = 0;
      public int ACC = 0;
      public int CRIT = 0;
      public int DTR = 0;
      public int SKS = 0;
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
      
      

      //add checked items to lists
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
      //string[] foodarr = { "buttonsinablanket", "apkalluomelette" };
      
      //carteisan product
      var gearsets = from weapon in weaponsarr
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
                     from ring2 in ringsarr
                     //from food in foodarr
                     select new[] { weapon, head, body, hands, belt, pants, feet, neck, earrings, wrists, ring1, ring2 };

      CONSOLE.Text = weaponsarr[1].name;
      //foreach (var item in gearsets) { GearSets.Text += item[0] + ", " + item[1] + ", " + item[2] + ", " + item[3] + ", " + item[4] + ", " + item[5] + ", " + item[6] + ", " + item[7] + ", " + item[8] + ", " + item[9] + ", " + item[10] + ", " + item[11] + ", " + item[12] + ", " + "\n";}

      //feet.Exists(x => x == "mythfeet")
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      calculate();
    }

    public void calculate() {
      makelists();
    }


  }
}
