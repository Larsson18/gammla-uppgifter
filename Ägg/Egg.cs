using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ägg
{
    public class Egg
    {
        Random random = new Random();
        public int Weight { get; set; }
        public Egg(int weight)
        { 
            Weight = weight;
        }

        public Egg LayEgg2() 
        {
            int eggOdds = random.Next(100);
            int weightOdds = random.Next(20, 80);
            

                if (eggOdds >= 1 && eggOdds <= 48)
                {
                    Weight = weightOdds;
                    return new Egg(Weight);
                
                }
                else return null;
            
        }
    }
}
