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
  /// 

  public partial class Item {
    public string job = "";
    public string name = "";
    public double WEP = 0;
    public double AADMG = 0;
    public double DELAY = 0;
    public double VIT = 0;
    public double STR = 0;
    public double DEX = 0;
    public double INT = 0;
    public double PIE = 0;
    public double ACC = 0;
    public double CRIT = 0;
    public double DTR = 0;
    public double SKS = 0;
    public double SPS = 0;
    public int ilvl = 0;
    public int DEF = 0;
    public int MDEF = 0;
    public string slot = "";
    public bool crafted = false;
  }

  public partial class Food {
    public string name = "";
    public double critmax = 0;
    public double dtrmax = 0;
    public double accmax = 0;
    public double sksmax = 0;
    public double spsmax = 0;
    public double critper = 0;
    public double dtrper = 0;
    public double accper = 0;
    public double sksper = 0;
    public double spsper = 0;
  }

  public partial class GearSet {
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
    public double totalint;
    public double bonusint;
    public double bonusdex;
    public double totalcrit;
    public double bonuscrit;
    public double totaldtr;
    public double bonusdtr;
    public double totalacc;
    public double bonusacc;
    public double totalsks;
    public double bonussks;
    public double bonussps;
    public double totalsps;
    public double dpsscore;
  }

  public partial class Job {
    public string name = "";
    public double acccap = 0;
    public double wepweight = 0;
    public double mainweight = 0;
    public double accweight = 0;
    public double dtrweight = 0;
    public double critweight = 0;
    public double sksweight = 0;
    public double spsweight = 0;
  }

  //weapon
  public class WeatheredLaevateinn : Item {
    public WeatheredLaevateinn() {
      job = "Caster";
      name = "Weathered Laevateinn";
      slot = "weapon";
      WEP = 72;
      VIT = 38;
      INT = 37;
      ACC = 40;
      SPS = 28;
      ilvl = 100;
    }
  }

  public class StardustRodAnimus : Item {
    public StardustRodAnimus() {
      job = "Caster";
      name = "Stardust Rod Animus";
      slot = "weapon";
      WEP = 72;
      VIT = 38;
      INT = 37;
      CRIT = 0;
      DTR = 20;
      SPS = 40;
      ilvl = 100;
    }
  }

  public class Laevateinn : Item {
    public Laevateinn() {
      job = "Caster";
      name = "Laevateinn";
      slot = "weapon";
      WEP = 75;
      VIT = 44;
      INT = 42;
      ACC = 44;
      SPS = 31;
      ilvl = 110;
    }
  }

  public class HighAllaganStaff : Item {
    public HighAllaganStaff() {
      job = "Caster";
      name = "High Allagan Staff";
      slot = "weapon";
      WEP = 77;
      VIT = 47;
      INT = 45;
      CRIT = 32;
      SPS = 46;
      ilvl = 115;
    }
  }


  //head
  public class WeatheredEvenstarHat : Item {
    public WeatheredEvenstarHat() {
      job = "Caster";
      name = "Weathered Evenstar Hat";
      slot = "head";
      VIT = 22;
      INT = 21;
      CRIT = 23;
      SPS = 16;
      DEF = 46;
      MDEF = 80;
      ilvl = 100;
    }
  }

  public class EvenstarHat : Item {
    public EvenstarHat() {
      job = "Caster";
      name = "Evenstar Hat";
      slot = "head";
      VIT = 25;
      INT = 24;
      CRIT = 25;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }


  public class HighAllaganMaskOfCasting : Item {
    public HighAllaganMaskOfCasting() {
      job = "Caster";
      name = "High Allagan Mask Of Casting";
      slot = "head";
      VIT = 25;
      INT = 24;
      ACC = 25;
      CRIT = 18;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }


  //body
  public class WeatheredEvenstarCoat : Item {
    public WeatheredEvenstarCoat() {
      job = "Caster";
      name = "Weathered Evenstar Coat";
      slot = "body";
      VIT = 35;
      INT = 34;
      CRIT = 26;
      DTR = 27;
      DEF = 65;
      MDEF = 112;
      ilvl = 100;
    }
  }

  public class EvenstarCoat : Item {
    public EvenstarCoat() {
      job = "Caster";
      name = "Evenstar Coat";
      slot = "body";
      VIT = 41;
      INT = 39;
      CRIT = 29;
      DTR = 29;
      DEF = 67;
      MDEF = 115;
      ilvl = 110;
    }
  }

  public class HighAllaganCoatOfCasting : Item {
    public HighAllaganCoatOfCasting() {
      job = "Caster";
      name = "High Allagan Coat Of Casting";
      slot = "body";
      VIT = 41;
      INT = 39;
      DTR = 29;
      SPS = 29;
      DEF = 67;
      MDEF = 115;
      ilvl = 110;
    }
  }


  //hands
  public class WeatheredEvenstarGloves : Item {
    public WeatheredEvenstarGloves() {
      job = "Caster";
      name = "Weathered Evenstar Gloves";
      slot = "hands";
      VIT = 22;
      INT = 21;
      CRIT = 23;
      SPS = 16;
      DEF = 46;
      MDEF = 80;
      ilvl = 100;
    }
  }

  public class EvenstarGloves : Item {
    public EvenstarGloves() {
      job = "Caster";
      name = "Evenstar Gloves";
      slot = "hands";
      VIT = 25;
      INT = 24;
      CRIT = 25;
      SPS = 18;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }

  public class HighAllaganGlovesOfCasting : Item {
    public HighAllaganGlovesOfCasting() {
      job = "Caster";
      name = "High Allagan Gloves Of Casting";
      slot = "hands";
      VIT = 25;
      INT = 24;
      ACC = 25;
      DTR = 12;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }


  //belt
  public class WeatheredEvenstarSash : Item {
    public WeatheredEvenstarSash() {
      job = "Caster";
      name = "Weathered Evenstar Sash";
      slot = "belt";
      VIT = 16;
      INT = 16;
      ACC = 17;
      CRIT = 12;
      DEF = 40;
      MDEF = 69;
      ilvl = 100;
    }
  }

  public class EvenstarSash : Item {
    public EvenstarSash() {
      job = "Caster";
      name = "Evenstar Sash";
      slot = "belt";
      VIT = 19;
      INT = 18;
      ACC = 19;
      CRIT = 13;
      DEF = 41;
      MDEF = 71;
      ilvl = 110;
    }
  }
  public class HighAllaganBeltOfCasting : Item {
    public HighAllaganBeltOfCasting() {
      job = "Caster";
      name = "High Allagan Belt Of Casting";
      slot = "belt";
      VIT = 19;
      INT = 18;
      DTR = 13;
      SPS = 13;
      DEF = 41;
      MDEF = 71;
      ilvl = 110;
    }
  }


  //pants
  public class WeatheredEvenstarTights : Item {
    public WeatheredEvenstarTights() {
      job = "Caster";
      name = "Weathered Evenstar Tights";
      slot = "pants";
      VIT = 35;
      INT = 34;
      ACC = 26;
      DTR = 27;
      DEF = 65;
      MDEF = 112;
      ilvl = 100;
    }
  }

  public class EvenstarTights : Item {
    public EvenstarTights() {
      job = "Caster";
      name = "Evenstar Tights";
      slot = "pants";
      VIT = 41;
      INT = 39;
      ACC = 29;
      DTR = 29;
      DEF = 67;
      MDEF = 115;
      ilvl = 110;
    }
  }
  public class HighAllaganBreechesOfCasting : Item {
    public HighAllaganBreechesOfCasting() {
      job = "Caster";
      name = "High Allagan Breeches Of Casting";
      slot = "pants";
      VIT = 41;
      INT = 39;
      CRIT = 29;
      SPS = 41;
      DEF = 67;
      MDEF = 115;
      ilvl = 110;
    }
  }


  //feet
  public class WeatheredEvenstarBootees : Item {
    public WeatheredEvenstarBootees() {
      job = "Caster";
      name = "Weathered Evenstar Bootees";
      slot = "feet"; ;
      VIT = 22;
      INT = 21;
      CRIT = 23;
      SPS = 16;
      DEF = 46;
      MDEF = 80;
      ilvl = 100;
    }
  }
  public class EvenstarBootees : Item {
    public EvenstarBootees() {
      job = "Caster";
      name = "Evenstar Bootees";
      slot = "feet";
      VIT = 25;
      INT = 24;
      CRIT = 25;
      SPS = 18;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }

  public class HighAllaganBootsOfCasting : Item {
    public HighAllaganBootsOfCasting() {
      job = "Caster";
      name = "High Allagan Boots Of Casting";
      slot = "feet";
      VIT = 25;
      INT = 24;
      ACC = 25;
      CRIT = 18;
      DEF = 48;
      MDEF = 82;
      ilvl = 110;
    }
  }


  //neck
  public class WeatheredEvenstarNecklace : Item {
    public WeatheredEvenstarNecklace() {
      job = "Caster";
      name = "Weathered Evenstar Necklace";
      slot = "neck";
      INT = 16;
      CRIT = 12;
      SPS = 17;
      DEF = 1;
      MDEF = 1;
      ilvl = 100;
    }
  }

  public class EvenstarNecklace : Item {
    public EvenstarNecklace() {
      job = "Caster";
      name = "Evenstar Necklace";
      slot = "neck";
      INT = 18;
      CRIT = 13;
      SPS = 19;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }

  public class HighAllaganChokerOfCasting : Item {
    public HighAllaganChokerOfCasting() {
      job = "Caster";
      name = "High Allagan Choker Of Casting";
      slot = "neck";
      INT = 18;
      ACC = 19;
      SPS = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }

  //earrings
  public class WeatheredEvenstarEarrings : Item {
    public WeatheredEvenstarEarrings() {
      job = "Caster";
      name = "Weathered Evenstar Earrings";
      slot = "earrings";
      INT = 16;
      ACC = 12;
      DTR = 12;
      DEF = 1;
      MDEF = 1;
      ilvl = 100;
    }
  }

  public class EvenstarEarrings : Item {
    public EvenstarEarrings() {
      job = "Caster";
      name = "Evenstar Earrings";
      slot = "earrings";
      INT = 18;
      ACC = 13;
      DTR = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }

  public class HighAllaganEarringsOfCasting : Item {
    public HighAllaganEarringsOfCasting() {
      job = "Caster";
      name = "High Allagan Earrings Of Casting";
      slot = "earrings";
      INT = 18;
      CRIT = 19;
      DTR = 9;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }


  //wrists
  public class WeatheredEvenstarArmillae : Item {
    public WeatheredEvenstarArmillae() {
      job = "Caster";
      name = "Weathered Evenstar Armillae";
      slot = "wrists";
      INT = 16;
      CRIT = 12;
      DTR = 12;
      DEF = 1;
      MDEF = 1;
      ilvl = 100;
    }
  }

  public class EvenstarArmillaes : Item {
    public EvenstarArmillaes() {
      job = "Caster";
      name = "Evenstar Armillae";
      slot = "earrings";
      INT = 18;
      CRIT = 13;
      DTR = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }

  public class HighAllaganBraceletsOfCasting : Item {
    public HighAllaganBraceletsOfCasting() {
      job = "Caster";
      name = "High Allagan Bracelets Of Casting";
      slot = "earrings";
      INT = 18;
      ACC = 19;
      CRIT = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }


  //ring
  public class WeatheredEvenstarRing : Item {
    public WeatheredEvenstarRing() {
      job = "Caster";
      name = "Weathered Evenstar Ring";
      slot = "ring";
      INT = 16;
      ACC = 17;
      CRIT = 12;
      DEF = 1;
      MDEF = 1;
      ilvl = 100;
    }
  }

  public class EvenstarRing : Item {
    public EvenstarRing() {
      job = "Caster";
      name = "Evenstar Ring";
      slot = "ring";
      INT = 18;
      ACC = 19;
      CRIT = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }

  public class HighAllaganRingOfCasting : Item {
    public HighAllaganRingOfCasting() {
      job = "Caster";
      name = "High Allagan Ring Of Casting";
      slot = "ring";
      INT = 18;
      ACC = 19;
      SPS = 13;
      DEF = 1;
      MDEF = 1;
      ilvl = 110;
    }
  }



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
      ACC = 19;
    }
  }

  public class WeatheredAuroralChoker : Item {
    public WeatheredAuroralChoker() {
      name = "Weathered Auroral Choker";
      DEX = 16;
      ACC = 12;
      DTR = 12;
    }
  }

  public class ArtemisBowAtma : Item {
    public ArtemisBowAtma() {
      name = "Artemis Bow Atma";
      WEP = 41;
      DEX = 31;
      SKS = 26;
      ACC = 37;
    }
  }

  public class WeatheredAuroralBoots : Item {
    public WeatheredAuroralBoots() {
      name = "Weathered Auroral Boots";
      DEX = 21;
      ACC = 16;
      SKS = 23;
    }
  }

  public class WeatheredAuroralCoif : Item {
    public WeatheredAuroralCoif() {
      name = "Weathered Auroral Coif";
      DEX = 21;
      ACC = 16;
      SKS = 23;
    }
  }

  public class WeatheredAuroralEarrings : Item {
    public WeatheredAuroralEarrings() {
      name = "Weathered Auroral Earrings";
      DEX = 16;
      CRIT = 12;
      ACC = 17;
    }
  }

  public class WeatheredAuroralBrais : Item {
    public WeatheredAuroralBrais() {
      name = "Weathered Auroral Brais";
      DEX = 34;
      DTR = 19;
      SKS = 38;
    }
  }

  public class TidalWaveBow : Item {
    public TidalWaveBow() {
      name = "Tidal Wave Bow";
      DEX = 37;
      ACC = 28;
      CRIT = 40;
    }
  }

  public class WeatheredRosenbogen : Item {
    public WeatheredRosenbogen() {
      name = "Weathered Rosenbogen";
      DEX = 37;
      CRIT = 28;
      SKS = 40;
    }
  }

  public class WeatheredAuroralWristlets : Item {
    public WeatheredAuroralWristlets() {
      name = "Weathered Auroral Wristlets";
      DEX = 16;
      CRIT = 12;
      ACC = 17;
    }
  }

  public class WeatheredAuroralBracers : Item {
    public WeatheredAuroralBracers() {
      name = "Weathered Auroral Bracers";
      DEX = 21;
      SKS = 16;
      ACC = 23;
    }
  }

  public class RibbonOfAiming : Item {
    public RibbonOfAiming() {
      name = "Ribbon of Aiming";
      DEX = 16;
      CRIT = 12;
      SKS = 17;
    }
  }

  public class WeatheredAuroralRing : Item {
    public WeatheredAuroralRing() {
      name = "Weathered Auroral Ring";
      DEX = 16;
      ACC = 12;
      SKS = 17;
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

  public class HQSachertorte : Food {
    public HQSachertorte() {
      name = "HQ Sachertorte";
      spsmax = 30;
      dtrmax = 8;
      spsper = 0.05;
      dtrper = 0.02;
    }
  }

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
    double SPSWEIGHT = 0;
    int ACCCAP = 0;

    Item highallagancompositebow = new HighAllaganCompositeBow();
    Item rosenbogen = new Rosenbogen();
    Item auroralcoif = new AuroralCoif();
    Item highallaganringofaiming = new HighAllaganRingOfAiming();
    Item auroralbrais = new AuroralBrais();
    Item auroralwristlets = new AuroralWristlets();
    Item highallaganglovesofaiming = new HighAllaganGlovesOfAiming();
    Item auroralring = new AuroralRing();
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
    Food hqsachertorte = new HQSachertorte();

    Item weatheredlaevateinn = new WeatheredLaevateinn();
    Item stardustrodanimus = new StardustRodAnimus();
    Item laevateinn = new Laevateinn();
    Item highallaganstaff = new HighAllaganStaff();
    Item weatheredevenstarhat = new WeatheredEvenstarHat();
    Item evenstarhat = new EvenstarHat();
    Item highallaganmaskofcasting = new HighAllaganMaskOfCasting();
    Item weatheredevenstarcoat = new WeatheredEvenstarCoat();
    Item evenstarcoat = new EvenstarCoat();
    Item highallagancoatofcasting = new HighAllaganCoatOfCasting();
    Item weatheredevenstargloves = new WeatheredEvenstarGloves();
    Item evenstargloves = new EvenstarGloves();
    Item highallaganglovesofcasting = new HighAllaganGlovesOfCasting();
    Item weatheredevenstarsash = new WeatheredEvenstarSash();
    Item evenstarsash = new EvenstarSash();
    Item highallaganbeltofcasting = new HighAllaganBeltOfCasting();
    Item weatheredevenstartights = new WeatheredEvenstarTights();
    Item evenstartights = new EvenstarTights();
    Item highallaganbreechesofcasting = new HighAllaganBreechesOfCasting();
    Item weatheredevenstarbootees = new WeatheredEvenstarBootees();
    Item evenstarbootees = new EvenstarBootees();
    Item highallaganbootsofcasting = new HighAllaganBootsOfCasting();
    Item weatheredevenstarnecklace = new WeatheredEvenstarNecklace();
    Item evenstarnecklace = new EvenstarNecklace();
    Item highallaganchokerofcasting = new HighAllaganChokerOfCasting();
    Item weatheredevenstarearrings = new WeatheredEvenstarEarrings();
    Item evenstarearrings = new EvenstarEarrings();
    Item highallaganearringsofcasting = new HighAllaganEarringsOfCasting();
    Item weatheredevenstararmillae = new WeatheredEvenstarArmillae();
    Item evenstararmillae = new EvenstarArmillaes();
    Item highallaganbraceletsofcasting = new HighAllaganBraceletsOfCasting();
    Item weatheredevenstarring = new WeatheredEvenstarRing();
    Item evenstarring = new EvenstarRing();
    Item highallaganringofcasting = new HighAllaganRingOfCasting();

    public virtual void makelists() {
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
      if (Job.Text == "BLM") {
        if ((bool)highallaganweapon.IsChecked) { weaponsl.Add(highallaganstaff); }
        if ((bool)ilvl110soldweapon.IsChecked) { weaponsl.Add(laevateinn); }

        if ((bool)highallaganhead.IsChecked) { headsl.Add(highallaganmaskofcasting); }
        if ((bool)ilvl110soldhead.IsChecked) { headsl.Add(evenstarhat); }

        if ((bool)highallaganbody.IsChecked) { bodiesl.Add(highallagancoatofcasting); }
        if ((bool)ilvl110soldbody.IsChecked) { bodiesl.Add(evenstarcoat); }

        if ((bool)highallaganhands.IsChecked) { handsl.Add(highallaganglovesofcasting); }
        if ((bool)ilvl110soldhands.IsChecked) { handsl.Add(evenstargloves); }

        if ((bool)highallaganbelt.IsChecked) { beltsl.Add(highallaganbeltofcasting); }
        if ((bool)ilvl110soldbelt.IsChecked) { beltsl.Add(evenstarsash); }

        if ((bool)highallaganpants.IsChecked) { pantsl.Add(highallaganbreechesofcasting); }
        if ((bool)ilvl110soldpants.IsChecked) { pantsl.Add(evenstartights); }

        if ((bool)highallaganfeet.IsChecked) { feetl.Add(highallaganbootsofcasting); }
        if ((bool)ilvl110soldfeet.IsChecked) { feetl.Add(evenstarbootees); }

        if ((bool)highallaganneck.IsChecked) { necksl.Add(highallaganchokerofcasting); }
        if ((bool)ilvl110soldneck.IsChecked) { necksl.Add(evenstarnecklace); }

        if ((bool)highallaganearrings.IsChecked) { earringls.Add(highallaganearringsofcasting); }
        if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add(evenstarearrings); }

        if ((bool)highallaganwrists.IsChecked) { wristsl.Add(highallaganbraceletsofcasting); }
        if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add(evenstararmillae); }

        if ((bool)highallaganring.IsChecked) { ringsl.Add(highallaganringofcasting); }
        if ((bool)ilvl110soldring.IsChecked) { ringsl.Add(evenstarring); }
      }

      if (Job.Text == "Bard") {
        if ((bool)highallaganweapon.IsChecked) { weaponsl.Add(highallagancompositebow); }
        if ((bool)ilvl110soldweapon.IsChecked) { weaponsl.Add(rosenbogen); }

        if ((bool)highallaganhead.IsChecked) { headsl.Add(highallaganmaskofaiming); }
        if ((bool)ilvl110soldhead.IsChecked) { headsl.Add(auroralcoif); }

        if ((bool)highallaganbody.IsChecked) { bodiesl.Add(highallagancoatofaiming); }
        if ((bool)ilvl110soldbody.IsChecked) { bodiesl.Add(auroraltabard); }

        if ((bool)highallaganhands.IsChecked) { handsl.Add(highallaganglovesofaiming); }
        if ((bool)ilvl110soldhands.IsChecked) { handsl.Add(auroralbracers); }

        if ((bool)highallaganbelt.IsChecked) { beltsl.Add(highallaganbeltofaiming); }
        if ((bool)ilvl110soldbelt.IsChecked) { beltsl.Add(auroralsash); }

        if ((bool)highallaganpants.IsChecked) { pantsl.Add(highallaganbreechesofaiming); }
        if ((bool)ilvl110soldpants.IsChecked) { pantsl.Add(auroralbrais); }

        if ((bool)highallaganfeet.IsChecked) { feetl.Add(highallaganbootsofaiming); }
        if ((bool)ilvl110soldfeet.IsChecked) { feetl.Add(auroralboots); }

        if ((bool)highallaganneck.IsChecked) { necksl.Add(highallaganchokerofaiming); }
        if ((bool)ilvl110soldneck.IsChecked) { necksl.Add(auroralchoker); }

        if ((bool)highallaganearrings.IsChecked) { earringls.Add(highallaganearringsofaiming); }
        if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add(auroralearrings); }

        if ((bool)highallaganwrists.IsChecked) { wristsl.Add(highallaganbraceletsofaiming); }
        if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add(auroralwristlets); }

        if ((bool)highallaganring.IsChecked) { ringsl.Add(highallaganringofaiming); }
        if ((bool)ilvl110soldring.IsChecked) { ringsl.Add(auroralring); }
      }

      if (Job.Text == "Choose") { return; }

      foods.Add(hqapkalluomelette);
      foods.Add(hqblacktrufflerisotto);
      foods.Add(hqdeviledeggs);
      foods.Add(hqlavatoadlegs);
      foods.Add(hqbuttonsinablanket);
      foods.Add(hqstuffedcabbage);
      foods.Add(hqsachertorte);

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
                      from ring2 in ringsarr
                      where ring2 != ring1
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
        double INT = 274;
        double ACC = 341;
        double CRIT = 341;
        double DTR = 202;
        double SKS = 341;
        double SPS = 341;
        bool debug = false;

        //sum of stats
        if (
          TempGearSet.weapon == laevateinn &&
          TempGearSet.head == highallaganmaskofcasting &&
          TempGearSet.body == highallagancoatofcasting &&
          TempGearSet.hands == evenstargloves &&
          TempGearSet.belt == highallaganbeltofcasting &&
          TempGearSet.pants == highallaganbreechesofcasting &&
          TempGearSet.feet == evenstarbootees &&
          TempGearSet.neck == evenstarnecklace &&
          TempGearSet.earrings == evenstarearrings &&
          TempGearSet.wrists == evenstararmillae &&
          TempGearSet.ring1 == evenstarring &&
          TempGearSet.ring2 == highallaganringofcasting &&
          TempGearSet.food == hqdeviledeggs
          ) { debug = true; }

        if (debug) { }

        for (var y = 0; y < gearsets[x].Count - 1; y++) {
          WEP += ((Item)gearsets[x][y]).WEP;
          DEX += ((Item)gearsets[x][y]).DEX;
          INT += ((Item)gearsets[x][y]).INT;
          ACC += ((Item)gearsets[x][y]).ACC;
          CRIT += ((Item)gearsets[x][y]).CRIT;
          DTR += ((Item)gearsets[x][y]).DTR;
          SKS += ((Item)gearsets[x][y]).SKS;
          SPS += ((Item)gearsets[x][y]).SPS;
        }

        //food
        if (ACC * ((Food)gearsets[x][12]).accper > ((Food)gearsets[x][12]).accmax) {
          ACC += ((Food)gearsets[x][12]).accmax;
        } else { ACC += Math.Floor((ACC) * ((Food)gearsets[x][12]).accper); }

        if (CRIT * ((Food)gearsets[x][12]).critper > ((Food)gearsets[x][12]).critmax) {
          CRIT += ((Food)gearsets[x][12]).critmax;
        } else { CRIT += Math.Floor((CRIT) * ((Food)gearsets[x][12]).critper); }

        if (DTR * ((Food)gearsets[x][12]).dtrper > ((Food)gearsets[x][12]).dtrmax) {
          DTR += ((Food)gearsets[x][12]).dtrmax;
        } else { DTR += Math.Floor((DTR) * ((Food)gearsets[x][12]).dtrper); }

        if (SKS * ((Food)gearsets[x][12]).sksper > ((Food)gearsets[x][12]).sksmax) {
          SKS += ((Food)gearsets[x][12]).sksmax;
        } else { SKS += Math.Floor((SKS) * ((Food)gearsets[x][12]).sksper); }

        if (SPS * ((Food)gearsets[x][12]).spsper > ((Food)gearsets[x][12]).spsmax) {
          SPS += ((Food)gearsets[x][12]).spsmax;
        } else { SPS += Math.Floor((SPS) * ((Food)gearsets[x][12]).spsper); }
        //create object
        TempGearSet.wepdmg = WEP;
        TempGearSet.totaldex = DEX;
        TempGearSet.totalint = INT;
        TempGearSet.bonusdex = DEX - 274;
        TempGearSet.bonusint = INT - 274;
        TempGearSet.totalacc = ACC;
        TempGearSet.bonusacc = ACC - 341;
        TempGearSet.totalcrit = CRIT;
        TempGearSet.bonuscrit = CRIT - 341;
        TempGearSet.totaldtr = DTR;
        TempGearSet.bonusdtr = DTR - 202;
        TempGearSet.totalsks = SKS;
        TempGearSet.bonussks = SKS - 341;
        TempGearSet.bonussps = SPS - 341;
        TempGearSet.totalsps = SPS;

        //acc cap 
        double calcdacc = 0;
        if (TempGearSet.totalacc > ACCCAP) {
          calcdacc = ACCCAP - 341;
        } else { calcdacc = TempGearSet.bonusacc; }

        //dps score
        if (Job.Text == "Bard") { TempGearSet.dpsscore = TempGearSet.wepdmg * WEPWEIGHT + TempGearSet.bonusdex * MAINWEIGHT + calcdacc * ACCWEIGHT + TempGearSet.bonuscrit * CRITWEIGHT + TempGearSet.bonusdtr * DTRWEIGHT + TempGearSet.bonussks * SKSWEIGHT; }
        if (Job.Text == "BLM") { TempGearSet.dpsscore = TempGearSet.wepdmg * WEPWEIGHT + TempGearSet.bonusint * MAINWEIGHT + calcdacc * ACCWEIGHT + TempGearSet.bonuscrit * CRITWEIGHT + TempGearSet.bonusdtr * DTRWEIGHT + TempGearSet.bonussps * SPSWEIGHT; }
        GearSets.Add(TempGearSet);
      }

      GearSets = GearSets.OrderBy(x => x.dpsscore).ToList();


      Results.Text = "";
      var count = 1;
      for (var x = GearSets.Count - 1; x >= GearSets.Count - 10; x--) {

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
        Results.Text += "WepDmg: " + GearSets[x].wepdmg;
        Results.Text += Environment.NewLine;
        Results.Text += "Dex: " + GearSets[x].totaldex + " - Int: " + GearSets[x].totalint;
        Results.Text += Environment.NewLine;
        Results.Text += "Acc: " + GearSets[x].totalacc + " -  Crit: " + GearSets[x].totalcrit + " - Dtr: " + GearSets[x].totaldtr;
        Results.Text += Environment.NewLine;
        Results.Text += "Sks: " + GearSets[x].totalsks + " - Sps: " + GearSets[x].totalsps;
        Results.Text += Environment.NewLine;
        Results.Text += "Score: " + GearSets[x].dpsscore;
        Results.Text += Environment.NewLine;
        Results.Text += Environment.NewLine;

      }


    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      calculate();
      if (Job.Text != "Choose") { GearTab.Focus(); }
    }

    public void calculate() {
      WEPWEIGHT = Convert.ToDouble(WepWeight.Text);
      MAINWEIGHT = Convert.ToDouble(MainWeight.Text);
      CRITWEIGHT = Convert.ToDouble(CritWeight.Text);
      DTRWEIGHT = Convert.ToDouble(DetWeight.Text);
      SKSWEIGHT = Convert.ToDouble(SksWeight.Text);
      SPSWEIGHT = Convert.ToDouble(SpsWeight.Text);
      ACCWEIGHT = Convert.ToDouble(AccWeight.Text);
      ACCCAP = Convert.ToInt32(AccCap.Text);

      makelists();
    }

    private void BRD_Select(object sender, RoutedEventArgs e) {
      WepWeight.Text = "9.73";
      MainWeight.Text = "1.00";
      AccWeight.Text = "1.00";
      DetWeight.Text = "0.27";
      CritWeight.Text = "0.24";
      SksWeight.Text = "0.11";
      AccCap.Text = "498";
      SpsWeight.Text = "0.00";
    }

    private void BLM_Select(object sender, RoutedEventArgs e) {
      WepWeight.Text = "6.36";
      MainWeight.Text = "1.00";
      AccWeight.Text = "1.00";
      DetWeight.Text = "0.26";
      CritWeight.Text = "0.19";
      SksWeight.Text = "0.00";
      AccCap.Text = "470";
      SpsWeight.Text = "0.24";
    }



  }
}
