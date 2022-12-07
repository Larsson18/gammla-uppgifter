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

namespace val
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // en int för varje val alternativ skapas samt en klass "VoteCounter"
        int alternativeA =0, alternativeB = 0, alternativeC = 0;
        VoteCounter voteCounter = new VoteCounter();

        private void btnWinner_Click(object sender, RoutedEventArgs e)
        {
            // en metod inom klassen voteCounter kallas på
            voteCounter.WinningVote(alternativeA, alternativeB, alternativeC);

            // ifall return = X blev det oavgjort vilket visas inom en messagebox
            if (voteCounter.Winner == 'X')
            {
                MessageBox.Show("Det går inte att avgöra vinnande alternativ");
            }
            else
            {
                MessageBox.Show($"Alternativ {voteCounter.Winner} fick flest röster");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVote_Click(object sender, RoutedEventArgs e)
        {
            if (rdbtn1.IsChecked == true)
            {
                alternativeA++;
            }
            else if (rdbtn2.IsChecked == true) 
            {
                alternativeB++;
            }
            else if (rdbtn3.IsChecked==true)
            {
                alternativeC++;
            }



        }
    }
}
