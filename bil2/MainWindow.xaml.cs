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

namespace bil2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        int player1 = 0, player2 = 0, player3 = 0;

        public void RandomNumbers() 
        {
            int[] numbers = new int[3];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 9);
                lblCode1.Content = numbers[0];
                lblCode2.Content = numbers[1];
                lblCode3.Content = numbers[2];
            }
            if (chk1.IsChecked == false)
            {
                player1 += numbers[0];
            }
            if (chk2.IsChecked == false)
            {
                player2 += numbers[1];
            }
            if (chk3.IsChecked == false)
            {
                player3 += numbers[2];
                
            }
        }

        private void btnBet_Click(object sender, RoutedEventArgs e)
        {
            RandomNumbers();
            lblTotal1.Content = player1;
            lblTotal2.Content = player2;
            lblTotal3.Content = player3;

            Car car = new Car();
            { 
                
            }
        }



        public void AddCar()
        {
            

        }
    }
}
