using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ägg
{
    public class HenHouse
    {
        int allEggs = 0;
        public List<Hen> hens = new List<Hen>();
        public string Stall { get; set; }
        Hen Hen { get; set; } = new Hen();


        public HenHouse() { }

        public HenHouse(int totalHens) 
        {
            for (int i = 0; i < totalHens; i++)
            {
                hens.Add(new Hen());

            }
        }

        //eftersom metoden ska se till alla hönor lägger jag den i henHouse
        // jag återanvänder metoden från uppgift 6 för att gå igenom ifall äggen värps för varje höna
        public int TotalEggs(int allEggs)
        {
            for (int i = 0; i < hens.Count; i++)
            {
                if (Hen.LayEgg() == 1)
                {
                    allEggs++;

                }
                
            }
            return allEggs;
        }
    }
    
}
