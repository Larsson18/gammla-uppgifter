using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ägg
{
    public class Hen
    {
        Random random = new Random();
        public string Hönsras { get; set; }
        public string Vikt { get; set; }


        // eftersom metoden har med hönan att göra lägger jag den i denna klass
        // jag skapar en random int som går in i en if-sats där ett procentuellt värde avgör ifall den returnar ett ägg eller inte.
        public int LayEgg() 
        {
            int eggOdds = random.Next(100);
            if (eggOdds >= 1 && eggOdds <= 48)
            {
                return 1;
            }
            else return 0;
        }
    }
}
