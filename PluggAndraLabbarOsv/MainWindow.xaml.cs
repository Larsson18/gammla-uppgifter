using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace PluggAndraLabbarOsv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentNumber = 000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int totalWeight = int.Parse(txtTotal.Text);
            lblB.Content = $"{3500 - totalWeight}";
            lblUtökad.Content = $"{4250 - totalWeight}";
        }

        private void txtControll_Click(object sender, RoutedEventArgs e)
        {
            string regNumber = txtRegNumber.Text;

            if (!IsSevenCharacters(regNumber))
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken");
            }
        }

        public bool IsSevenCharacters(string regNumber) 
        {
            if (regNumber.Length ==7)
            {
                return true;
            }
            return false;
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            string letters = GetRandomLetters();
            Random random = new Random();
            int number = random.Next(0, 10);
            string regPlate = $"{letters} {number.ToString("D3")}; 
            lblRandom.Content = regPlate;
            if (number == currentNumber +1)
            {
                currentNumber++;
                lblLastResult.Content = regPlate;
            }

        }
        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }


    }
}
