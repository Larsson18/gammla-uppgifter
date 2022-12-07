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

namespace val2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalChairs = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

            bool[] checkedValues = new bool[]
            {
                (bool)chkModeraterna.IsChecked,
                (bool)chkCenterpartiet.IsChecked,
                (bool)chkLiberalerna.IsChecked,
                (bool)chkKristdemokraterna.IsChecked,
                (bool)chkSocialdemokraterna.IsChecked,
                (bool)chkVänsterpartiet.IsChecked,
                (bool)chkMiljöpartiet.IsChecked,
                (bool)chkSveriedemokraterna.IsChecked
            };

            ChairCount(checkedValues);
            lblResult.Content = $"Resultat: {totalChairs} av 349. Majoritet? {IsMajority()}";


        }
        public int ChairCount(bool[] checkedValues) 
        {
            int[] chairs = new int[] { 70, 31, 20, 22, 100, 28, 16, 62 };
            for (int i = 0; i < chairs.Length; i++)
            {
                if (checkedValues[i])
                {
                    totalChairs += chairs[i];
                }
            }
            return totalChairs;

        }

        public string IsMajority() 
        {
            if (totalChairs >=174)
            {
                return "Ja";
            }
            return "Nej";        
        }
    }
}
