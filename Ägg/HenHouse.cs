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

        //Här används int variabeln total hens för att gå ignom alla hönor och sedan lägger till dom i "hens" listan.
        public HenHouse(int totalHens) 
        {
            for (int i = 0; i < totalHens; i++)
            {
                hens.Add(new Hen());

            }
        }

        //eftersom metoden ska se till alla hönor lägger jag den i henHouse
        // jag återanvänder metoden från uppgift 6 för att gå igenom ifall äggen värps för varje höna
        
        //jag använder mig utav en for loop som går igenom alla höner via "hens.Count" och sedan kallar på metoden för den procentuella chansen att ett ägg kommer.
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
