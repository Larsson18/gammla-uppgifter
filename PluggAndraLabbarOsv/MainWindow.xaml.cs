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
        // skapar en int vilket kommer ifrån txtTotal, sedan visar lbl släppvagnens vikter efter totalvikten-totalvikten
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int totalWeight = int.Parse(txtTotal.Text);
            lblB.Content = $"{3500 - totalWeight}";
            lblUtökad.Content = $"{4250 - totalWeight}";
        }

        // idenna sats används en string vilket representerar txtRegnumber som sedan används inom ISSevenChracters vilket ger true/false och sedan visar 
        private void txtControll_Click(object sender, RoutedEventArgs e)
        {
            string regNumber = txtRegNumber.Text;
            // if !(INTe)Issevenchracters
            if (!IsSevenCharacters(regNumber))
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken");
            }
        }
        // regnummret får värdet true ifall längden är 7 annars false
        public bool IsSevenCharacters(string regNumber) 
        {
            if (regNumber.Length ==7)
            {
                return true;
            }
            return false;
        }

        //
        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            //metoden GetRandomLetters kallas med en string vid namn letters. 
            string letters = GetRandomLetters();
            // en random skapas för att ge ett slumpmäsigt tal till regplåten
            Random random = new Random();
            int number = random.Next(0, 10);
            string regPlate = $"{letters} {number.ToString("D3")}";
            lblRandom.Content = regPlate;

            // if number(= det random nummret) = currentnumber vilket används som en counter med startvärdet längst upp.
            
            if (number == currentNumber +1)
            {
                currentNumber++;
                lblLastResult.Content = regPlate;
            }

        }
        // skapar en random med bokstäver inom en regplåt.
        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            // for loopen tar fram 3st random bokstäver för plåten.
            for (int i = 0; i < 3; i++)
            {
                //sedan läggs dessa 3st randoms in i variabeln letters 
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }


    }
}
