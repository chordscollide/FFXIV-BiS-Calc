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

    public void makelists() {
      //initialize variables
      List<string> weaponsl = new List<string>();
      List<string> headsl = new List<string>();
      List<string> bodiesl = new List<string>();
      List<string> handsl = new List<string>();
      List<string> beltsl = new List<string>();
      List<string> pantsl = new List<string>();
      List<string> feetl = new List<string>();
      List<string> necksl = new List<string>();
      List<string> earringls = new List<string>();
      List<string> wristsl = new List<string>();
      List<string> ringsl = new List<string>();

      //add checked items to lists
      if ((bool)highallaganweapon.IsChecked) { weaponsl.Add("highallaganweapon"); }
      if ((bool)ilvl110soldweapon.IsChecked) { weaponsl.Add("ilvl110soldweapon"); }
      if ((bool)ilvl100soldweapon.IsChecked) { weaponsl.Add("ilvl100soldweapon"); }
      if ((bool)allaganweapon.IsChecked) { weaponsl.Add("allaganweapon"); }
      if ((bool)zenithweapon.IsChecked) { weaponsl.Add("zenithweapon"); }
      if ((bool)ilvl100leviweapon.IsChecked) { weaponsl.Add("ilvl100leviweapon"); }
      if ((bool)ilvl95leviweapon.IsChecked) { weaponsl.Add("ilvl95leviweapon"); }
      if ((bool)atmaweapon.IsChecked) { weaponsl.Add("atmaweapon"); }
      if ((bool)animusweapon.IsChecked) { weaponsl.Add("animusweapon"); }

      if ((bool)highallaganhead.IsChecked) { headsl.Add("highallaganhead"); }
      if ((bool)ilvl110soldhead.IsChecked) { headsl.Add("ilvl110soldhead"); }
      if ((bool)ilvl100soldhead.IsChecked) { headsl.Add("ilvl100soldhead"); }
      if ((bool)allaganhead.IsChecked) { headsl.Add("allaganhead"); }
      if ((bool)mythhead.IsChecked) { headsl.Add("mythhead"); }

      if ((bool)highallaganbody.IsChecked) { bodiesl.Add("highallaganbody"); }
      if ((bool)ilvl110soldbody.IsChecked) { bodiesl.Add("ilvl110soldbody"); }
      if ((bool)ilvl100soldbody.IsChecked) { bodiesl.Add("ilvl100soldbody"); }
      if ((bool)allaganbody.IsChecked) { bodiesl.Add("allaganbody"); }
      if ((bool)mythbody.IsChecked) { bodiesl.Add("mythbody"); }

      if ((bool)highallaganhands.IsChecked) { handsl.Add("highallaganhands"); }
      if ((bool)ilvl110soldhands.IsChecked) { handsl.Add("ilvl110soldhands"); }
      if ((bool)ilvl100soldhands.IsChecked) { handsl.Add("ilvl100soldhands"); }
      if ((bool)allaganhands.IsChecked) { handsl.Add("allaganhands"); }
      if ((bool)mythhands.IsChecked) { handsl.Add("mythhands"); }

      if ((bool)highallaganbelt.IsChecked) { beltsl.Add("highallaganbelt"); }
      if ((bool)ilvl110soldbelt.IsChecked) { beltsl.Add("ilvl110soldbelt"); }
      if ((bool)ilvl100soldbelt.IsChecked) { beltsl.Add("ilvl100soldbelt"); }
      if ((bool)allaganbelt.IsChecked) { beltsl.Add("allaganblelt"); }
      if ((bool)mythbelt.IsChecked) { beltsl.Add("mythbelt"); }

      if ((bool)highallaganpants.IsChecked) { pantsl.Add("highallaganpants"); }
      if ((bool)ilvl110soldpants.IsChecked) { pantsl.Add("ilvl110soldpants"); }
      if ((bool)ilvl100soldpants.IsChecked) { pantsl.Add("ilvl100soldpants"); }
      if ((bool)allaganpants.IsChecked) { pantsl.Add("allaganpants"); }
      if ((bool)mythpants.IsChecked) { pantsl.Add("mythpants"); }

      if ((bool)highallaganfeet.IsChecked) { feetl.Add("highallaganfeet"); }
      if ((bool)ilvl110soldfeet.IsChecked) { feetl.Add("ilvl100soldfeet"); }
      if ((bool)ilvl100soldfeet.IsChecked) { feetl.Add("ilvl100soldfeet"); }
      if ((bool)allaganfeet.IsChecked) { feetl.Add("allaganfeet"); }
      if ((bool)mythfeet.IsChecked) { feetl.Add("mythfeet"); }

      if ((bool)highallaganneck.IsChecked) { necksl.Add("highallaganneck"); }
      if ((bool)ilvl110soldneck.IsChecked) { necksl.Add("ilvl110soldneck"); }
      if ((bool)ilvl100soldneck.IsChecked) { necksl.Add("ilvl100soldneck"); }
      if ((bool)allaganneck.IsChecked) { necksl.Add("allaganneck"); }
      if ((bool)mythneck.IsChecked) { necksl.Add("mythneck"); }
      if ((bool)moogleneck.IsChecked) { necksl.Add("moogleneck"); }

      if ((bool)highallaganearrings.IsChecked) { earringls.Add("highallaganearrings"); }
      if ((bool)ilvl110soldearrings.IsChecked) { earringls.Add("ilvl110soldearrings"); }
      if ((bool)ilvl100soldearrings.IsChecked) { earringls.Add("ilvl100soldearrings"); }
      if ((bool)allaganearrings.IsChecked) { earringls.Add("allaganearrings"); }
      if ((bool)mythearrings.IsChecked) { earringls.Add("mythearrings"); }
      if ((bool)titanearrings.IsChecked) { earringls.Add("titanearrings"); }

      if ((bool)highallaganwrists.IsChecked) { wristsl.Add("highallaganwrists"); }
      if ((bool)ilvl110soldwrists.IsChecked) { wristsl.Add("ilvl110soldwrists"); }
      if ((bool)ilvl100soldwrists.IsChecked) { wristsl.Add("ilvl100soldwrists"); }
      if ((bool)allaganwrists.IsChecked) { wristsl.Add("allaganwrists"); }
      if ((bool)mythwrists.IsChecked) { wristsl.Add("mythwrists"); }
      if ((bool)ifritwrists.IsChecked) { wristsl.Add("ifritwirsts"); }

      if ((bool)highallaganring.IsChecked) { ringsl.Add("highallaganring"); }
      if ((bool)ilvl110soldring.IsChecked) { ringsl.Add("ilvl110soldring"); }
      if ((bool)ilvl100soldring.IsChecked) { ringsl.Add("ilvl100soldring"); }
      if ((bool)allaganring.IsChecked) { ringsl.Add("allaganring"); }
      if ((bool)mythring.IsChecked) { ringsl.Add("mythring"); }
      if ((bool)garudaring.IsChecked) { ringsl.Add("garudaring"); }

      //convert to arrays
      string[] weaponsarr = weaponsl.ToArray();
      string[] headsarr = headsl.ToArray();
      string[] bodiesarr = bodiesl.ToArray();
      string[] handsarr = handsl.ToArray();
      string[] beltsarr = beltsl.ToArray();
      string[] pantsarr = pantsl.ToArray();
      string[] feetarr = feetl.ToArray();
      string[] necksarr = necksl.ToArray();
      string[] earringsarr = earringls.ToArray();
      string[] wristsarr = wristsl.ToArray();
      string[] ringsarr = ringsl.ToArray();
      string[] foodarr = { "buttonsinablanket", "apkalluomelette" };

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
                     from food in foodarr
                     select new[] { weapon, head, body, hands, belt, pants, feet, neck, earrings, wrists, ring1, ring2, food };

      GearSets.Text = "";
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
