using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVBISCALC
{
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

public class JudgmentRingOfCasting : Item {
  public JudgmentRingOfCasting() {
    name = "Judgment Ring of Casting";
    INT = 16;
    CRIT = 17;
    DTR = 9;
    DEF = 1;
    MDEF = 1;
    slot = "ring";
    ilvl = 100;
  }
}

public class SapphireRing : Item {
  public SapphireRing() {
    name = "Sapphire Ring";
    INT = 13;
    SPS = 16;
    DTR = 11;
    CRIT = 16;
    ACC = 9;
    DEF = 1;
    MDEF = 1;
    slot = "ring";
    ilvl = 100;
  }
}

public class SapphireRing2 : Item {
  public SapphireRing2() {
    name = "Sapphire Ring ";
    INT = 13;
    SPS = 16;
    DTR = 11;
    CRIT = 9;
    ACC = 16;
    DEF = 1;
    MDEF = 1;
    slot = "ring";
    ilvl = 100;
  }
}

public class SapphireChoker : Item {
  public SapphireChoker() {
    name = "Sapphire Choker";
    INT = 13;
    SPS = 16;
    DTR = 11;
    CRIT = 9;
    ACC = 16;
    DEF = 1;
    MDEF = 1;
    slot = "neck";
    ilvl = 100;
  }
}

public class SapphireBracelet : Item {
  public SapphireBracelet() {
    name = "Sapphire Bracelet";
    INT = 13;
    SPS = 16;
    DTR = 11;
    CRIT = 9;
    ACC = 16;
    DEF = 1;
    MDEF = 1;
    slot = "wrist";
    ilvl = 100;
  }
}

public class SapphireEarrings : Item {
  public SapphireEarrings() {
    name = "Sapphire Earrings";
    INT = 13;
    SPS = 16;
    DTR = 11;
    CRIT = 9;
    ACC = 16;
    DEF = 1;
    MDEF = 1;
    slot = "earrings";
    ilvl = 100;
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

public class ArtemisBowNovus : Item {
  public ArtemisBowNovus() {
    name = "Artemis Bow Novus";
    WEP = 46;
    DEX = 42;
    DTR = 31;
    ACC = 44;

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

public class IoliteRing : Item {
  public IoliteRing() {
    name = "Iolite Ring";
    DEX = 13;
    ACC = 16;
    CRIT = 16;
    DTR = 11;
  }
}

public class IoliteRing2 : Item {
  public IoliteRing2() {
    name = "Iolite Ring ";
    DEX = 13;
    ACC = 16;
    CRIT = 16;
    DTR = 11;
  }
}

public class IoliteBracelet : Item {
  public IoliteBracelet() {
    name = "Iolite Bracelet";
    DEX = 13;
    ACC = 16;
    SKS = 9;
    CRIT = 16;
    DTR = 11;
  }
}

public class IoliteEarrings : Item {
  public IoliteEarrings() {
    name = "Iolite Earrings";
    DEX = 13;
    ACC = 16;
    SKS = 9;
    CRIT = 16;
    DTR = 11;
  }
}

public class IoliteChoker : Item {
  public IoliteChoker() {
    name = "Iolite Choker";
    DEX = 13;
    ACC = 16;
    SKS = 9;
    CRIT = 16;
    DTR = 11;
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

public class JudgmentRingOfAiming : Item {
  public JudgmentRingOfAiming() {
    name = "Judgment Ring of Aiming";
    DEX = 16;
    CRIT = 17;
    SKS = 12;
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

  public class Bard : Job {


  }
}
