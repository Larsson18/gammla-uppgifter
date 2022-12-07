using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace val
{
    public class VoteCounter
    {
        public char Winner;

        public int WinningVote(int alternativeA, int alternativeB, int alternativeC) 
        {
            if (alternativeA > alternativeB && alternativeA > alternativeB)
            {

                return Winner = 'A';
            }
            else if (alternativeB > alternativeA && alternativeB > alternativeC)
            {
                return Winner = 'B';
            }
            else if (alternativeC > alternativeA && alternativeC > alternativeB)
            {
                return Winner = 'C';
            }
            else return Winner = 'X';
        }
    }
}
