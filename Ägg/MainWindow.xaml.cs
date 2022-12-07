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

namespace Ägg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int allEggs = 0, weight = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int totalEggs = int.Parse(txtInput.Text);
            int totalPackages = totalEggs / 12;
            double price = totalPackages * 12 * 3.56;

            txtResult.Text = $" Du ska leverera {totalPackages} st kartonger till ett pris av {price} kronor.";

            int brokenEgg = 0, notBrokenEgg = 0;

            bool[] isBroken = new bool[] { true, true, true, false, true, false,
            false, true, true, false, true, true, false, false, true, true, false,
            true, false, false, true, false, true, true, true, true, false, false,
            false, false, false, false, false, true, false, false, true, false,
            false, true, false, true, true, true, false, true, false, true, false,
            true, true, true, false, true, false, false, false, false, false, false,
            false, false, true, false, true, false, false, true, false, false, false,
            true, true, false, false, true, true, false, true, true, false, false,
            true, true, true, false, false, false, false, true };

            foreach (bool isEggBroken in isBroken)
            {
                if (isEggBroken == true)
                {
                    brokenEgg++;
                }
                else if (isEggBroken == false) 
                {
                    notBrokenEgg++;
                }
            }
            MessageBox.Show($"Utav {isBroken.Length} är {brokenEgg} st ägg trasiga och {notBrokenEgg} st hela.");

            CountEggs();
            
        }

        public int CountEggs() 
        {
            int eggs = 0;

            List<string> pinkCodes = new List<string>() {"1SE123-2", "0SE675-6",
            "2SE122-4", "0SE234-1", "0SE234-5", "2SE564-4", "0SE234-2", "1SE564-6",
            "2SE144-5", "0SE675-1", "1SE144-1", "2SE144-3", "1SE123-4", "2SE122-2",
            "1SE122-6", "0SE234-2", "2SE123-3", "1SE234-3", "1SE123-6", "1SE123-4",
            "0SE122-2", "1SE144-3", "0SE234-4", "0SE564-1", "0SE234-4", "2SE144-3",
            "2SE122-3", "1SE234-3", "1SE123-4", "1SE564-5", "1SE123-1", "2SE122-6",
            "0SE123-6", "1SE564-6", "1SE234-5", "1SE564-6", "2SE234-2", "1SE234-3",
            "0SE234-3", "2SE122-5", "2SE234-2", "2SE144-2", "2SE564-5", "1SE144-5",
            "1SE675-4", "1SE123-6", "2SE564-6", "1SE122-6", "1SE122-5", "2SE122-2",
            "1SE234-2", "0SE675-5", "2SE122-4", "1SE234-6", "0SE564-4", "1SE564-6",
            "2SE675-3", "1SE144-4", "2SE564-5", "0SE564-1", "1SE564-4", "1SE123-4",
            "1SE564-6", "2SE122-2", "1SE564-5", "2SE234-4", "1SE564-4", "2SE122-1",
            "2SE123-3", "2SE564-2", "2SE234-4", "1SE144-1", "1SE675-1", "0SE144-1",
            "2SE123-6", "0SE123-5", "2SE144-6", "0SE144-6", "1SE122-4", "1SE675-6",
            "0SE122-6", "2SE144-2", "2SE122-3", "1SE234-5", "1SE564-2", "1SE144-5",
            "0SE144-1", "1SE144-3", "1SE122-4", "1SE123-1"};
            foreach (string egg in pinkCodes)
            {
                if (egg.Contains("123"))
                {
                    eggs++;
                }
            }
            return eggs;
            
        }

        // jag har slagit ihopp uppgift 5 och 7 till en knapp för att enklare gå igenom metoderna
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            HenHouse henHouse = new HenHouse(250);
            henHouse.TotalEggs(allEggs);
        }

        private void btnEgg_Click(object sender, RoutedEventArgs e)
        {
            Egg egg = new Egg(weight);

            egg.LayEgg2();
        }
    }
}
