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

namespace val3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Election election = new Election();
        Party party = new Party();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Party party = new Party()
            { Name = txtName.Text, Abbreviation = txtAbbreviation.Text };
            
            election.Parties.Add(party);
            lstParties.ItemsSource = party;                                      
            

        }

        private void btnVotes_Click(object sender, RoutedEventArgs e)
        {
            party.NumberOfVotes = int.Parse(txtVotes.Text);
        }

        private void lstParties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
