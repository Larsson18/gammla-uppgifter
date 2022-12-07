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
        CarRegister carRegister = new CarRegister();
        public MainWindow()
        {
            InitializeComponent();
        }

        int player1 = 0, player2 = 0, player3 = 0;

        public void RandomNumbers() 
        {
            // en array utav 3st int skapas vilket kommer representera vår regplåt
            int[] numbers = new int[3];

            Random random = new Random();
            // en for loop som går igenom alla värden (i) inom numbers.Length
            for (int i = 0; i < numbers.Length; i++)
            {
                // för varje numbers(3st) skapas en ny slumpmäsig int som bli värden för fack 1,2,3
                numbers[i] = random.Next(0, 9);
                lblCode1.Content = numbers[0];
                lblCode2.Content = numbers[1];
                lblCode3.Content = numbers[2];
            }
            //if-satsen kollar ifall checkboxen för en spelare är klickade ifall de är klickade kommer poäng ej räknas, annars räknar den ihopp det som vanligt.
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // skapar ett nytt objekt (bil) med värden
            Car car = new Car()
            {
                Color = txtColor.Text,
                LicensePlate = txtReg.Text,
                Make = txtMake.Text,
                Model = txtModel.Text
            };
            // kallar på resultatet utav en metod
            bool result = carRegister.AddCar(car);
        }

        private void btnBet_Click(object sender, RoutedEventArgs e)
        {
            // Själva knappen som sedan kallar på metoden RandomNumbers och sedan ger labels sina värden efter.
            RandomNumbers();
            lblTotal1.Content = player1;
            lblTotal2.Content = player2;
            lblTotal3.Content = player3;

            

        
        }




    }
}
