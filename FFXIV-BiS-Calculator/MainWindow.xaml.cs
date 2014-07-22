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
using System.Diagnostics;
using System.Threading;
using avThreading;

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
    Item artemisbownovus = new ArtemisBowNovus();

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

    Item judgmentringofcasting = new JudgmentRingOfCasting();
    Item judgmentringofaiming = new JudgmentRingOfAiming();

    Item iolitering = new IoliteRing();
    Item iolitebracelet = new IoliteBracelet();
    Item ioliteearrings = new IoliteEarrings();
    Item iolitechoker = new IoliteChoker();
    Item iolitering2 = new IoliteRing2();

    Item sapphirering = new SapphireRing();
    Item sapphirering2 = new SapphireRing2();
    Item sapphirechoker = new SapphireChoker();
    Item sapphirebracelet = new SapphireBracelet();
    Item sapphireearrings = new SapphireEarrings();

    //****************************************************************************************
    // GearSet sorting
    //****************************************************************************************
    private int Partition(GearSet[] input, int low, int high) {
      GearSet pivot = input[high];
      int i = low - 1;

      for (int j = low; j < high; j++) {
        if (input[j].dpsscore < pivot.dpsscore 
          || (input[j].dpsscore == pivot.dpsscore && input[j].food.name.CompareTo(pivot.food.name) < 0) ) {
          i++;
          swap(input, i, j);
        }
      }
      swap(input, i + 1, high);
      return i + 1;
    }

    private void swap(GearSet[] ar, int a, int b) {
      var temp = ar[a];
      ar[a] = ar[b];
      ar[b] = temp;
    }

    private void QuicksortSequential(GearSet[] arr, int left, int right) {
      if (right > left) {
        int pivot = Partition(arr, left, right);
        QuicksortSequential(arr, left, pivot - 1);
        QuicksortSequential(arr, pivot + 1, right);
      }
    }

    private void QuicksortParallel(GearSet[] arr, int left, int right) {
      const int SEQUENTIAL_THRESHOLD = 2048;
      if (right > left) {
        if (right - left < SEQUENTIAL_THRESHOLD) {
          QuicksortSequential(arr, left, right);
        } else {
          int pivot = Partition(arr, left, right);
          Parallel.Invoke(
              () => QuicksortParallel(arr, left, pivot - 1),
              () => QuicksortParallel(arr, pivot + 1, right));
        }
      }
    }
    //****************************************************************************************

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
        if ((bool)i90neck.IsChecked) { necksl.Add(sapphirechoker); }

        if ((bool)highallaganearrings.IsChecked) { earringls.Add(highallaganearringsofcasting); }
        if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add(evenstarearrings); }
        if ((bool)i90earrings.IsChecked) { earringls.Add(sapphireearrings); }

        if ((bool)highallaganwrists.IsChecked) { wristsl.Add(highallaganbraceletsofcasting); }
        if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add(evenstararmillae); }
        if ((bool)i90wrist.IsChecked) { wristsl.Add(sapphirebracelet); }

        if ((bool)highallaganring.IsChecked) { ringsl.Add(highallaganringofcasting); }
        if ((bool)ilvl110soldring.IsChecked) { ringsl.Add(evenstarring); }
        if ((bool)ramuhring.IsChecked) { ringsl.Add(judgmentringofcasting); }
        if ((bool)i90ring.IsChecked) { ringsl.Add(sapphirering); ringsl.Add(sapphirering2); }

      }

      if (Job.Text == "Bard") {
        if ((bool)highallaganweapon.IsChecked) { weaponsl.Add(highallagancompositebow); }
        if ((bool)ilvl110soldweapon.IsChecked) { weaponsl.Add(rosenbogen); }
        if ((bool)novus.IsChecked) { weaponsl.Add(artemisbownovus); }

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
        if ((bool)i90neck.IsChecked) { necksl.Add(iolitechoker); }

        if ((bool)highallaganearrings.IsChecked) { earringls.Add(highallaganearringsofaiming); }
        if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add(auroralearrings); }
        if ((bool)i90earrings.IsChecked) { earringls.Add(ioliteearrings); }

        if ((bool)highallaganwrists.IsChecked) { wristsl.Add(highallaganbraceletsofaiming); }
        if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add(auroralwristlets); }
        if ((bool)i90ring.IsChecked) { wristsl.Add(iolitebracelet); }

        if ((bool)highallaganring.IsChecked) { ringsl.Add(highallaganringofaiming); }
        if ((bool)ilvl110soldring.IsChecked) { ringsl.Add(auroralring); }
        if ((bool)ramuhring.IsChecked) { ringsl.Add(judgmentringofaiming); }
        if ((bool)i90ring.IsChecked) { ringsl.Add(iolitering); ringsl.Add(iolitering2); }


      }

      if (Job.Text == "Choose") { return; }

      foods.Add(hqapkalluomelette);
      foods.Add(hqblacktrufflerisotto);
      foods.Add(hqdeviledeggs);
      foods.Add(hqlavatoadlegs);
      foods.Add(hqbuttonsinablanket);
      foods.Add(hqstuffedcabbage);
      //foods.Add(hqsachertorte);

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


      Classes_Enum CurrentJob = Classes_Enum.Undefined;
      if (Job.Text == "Bard")
        CurrentJob = Classes_Enum.Bard;
      if (Job.Text == "BLM")
        CurrentJob = Classes_Enum.BLM;

/*
 * //      int num_Threads = Environment.ProcessorCount;
      int test_count = 0;
      using (new avForThread(0, 100, 4,
         delegate(int start, int end)
         {
           for (int x = start; x < end; x++)
           {
             lock (cs)
             {
               test_count++;
             }
           }
         })
       ) ;*/

      Stopwatch Timer = new Stopwatch();
      Timer.Start();

      int TotalSets = gearsets.Count;
      GearSet[] GearSets = new GearSet[TotalSets];

      Parallel.For(0, TotalSets, delegate(int x)
      {
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

              List<Item> ringtemp = new List<Item>();

              ringtemp.Add(TempGearSet.ring1);
              ringtemp.Add(TempGearSet.ring2);

              ringtemp = ringtemp.OrderBy(o => o.name).ToList();

              TempGearSet.ring1 = ringtemp[0];
              TempGearSet.ring2 = ringtemp[1];

              double WEP = 0;
              double DEX = 274;
              double INT = 274;
              double ACC = 341;
              double CRIT = 341;
              double DTR = 202;
              double SKS = 341;
              double SPS = 341;

              //sum of stats
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


              // dps-score
              switch (CurrentJob) {
                case Classes_Enum.Bard:
                  TempGearSet.dpsscore = TempGearSet.wepdmg * WEPWEIGHT + TempGearSet.bonusdex * MAINWEIGHT + calcdacc * ACCWEIGHT + TempGearSet.bonuscrit * CRITWEIGHT + TempGearSet.bonusdtr * DTRWEIGHT + TempGearSet.bonussks * SKSWEIGHT;
                  break;
                case Classes_Enum.BLM:
                  TempGearSet.dpsscore = TempGearSet.wepdmg * WEPWEIGHT + TempGearSet.bonusint * MAINWEIGHT + calcdacc * ACCWEIGHT + TempGearSet.bonuscrit * CRITWEIGHT + TempGearSet.bonusdtr * DTRWEIGHT + TempGearSet.bonussps * SPSWEIGHT;
                  break;
              }

              GearSets[x] = TempGearSet;
            }
      );

      QuicksortParallel(GearSets, 0, TotalSets - 1);
//      GearSets = GearSets.OrderBy(x => x.dpsscore).ThenBy(x => x.food.name).ToArray();

      Timer.Stop(); // done
      TimeSpan ts = Timer.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
          ts.Hours, ts.Minutes, ts.Seconds,
          ts.Milliseconds / 10);

      Results.Text = "";
      var count = 1;
      Results.Text += "Total Gear Sets: " + TotalSets;
      Results.Text += Environment.NewLine;
      Results.Text += Environment.NewLine;

      for (var x = TotalSets - 1; x >= 0 && count <= 10; x--) {
        if (x > 0 && GearSets[x].dpsscore == GearSets[x - 1].dpsscore && GearSets[x].food.name == GearSets[x - 1].food.name)
          continue; // skip the duplicate entry

        Results.Text += "Gear Set: " + count;
        count++;
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

      Results.Text += "BiS calc: " + elapsedTime;
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
