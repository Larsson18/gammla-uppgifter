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
            // en array utav bools som visar ifall en checkbox är ikryssad (true/false)
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

        // en metod för att räkna mandat ( eller generellt värde utav en string utifrån en annan) 
        
        public int ChairCount(bool[] checkedValues) 
        {   
            // int chairs är en array med mandat(värde) för varje index vilket även anhör index inom checkedvalues 
            int[] chairs = new int[] { 70, 31, 20, 22, 100, 28, 16, 62 };
            
            // en for loop som går igenom chairs.Length ( arrayen) och kollar efter värdet (i)
            for (int i = 0; i < chairs.Length; i++)
            {
                //if-satsen visar att ifall ett parti är checkat kommer den gå ner och lägga till värdet (i) som är kopplat till det indexet
                
                if (checkedValues[i])
                {
                    totalChairs += chairs[i];
                }
            }
            // returnar totalchairs==mandaten
            return totalChairs;

        }

        // en simpel metod för att kolla ifall den totala summan är= eller större än 174
        // vilket sedan returnar Ja eller Nej
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
