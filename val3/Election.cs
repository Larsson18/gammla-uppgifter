using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace val3
{
    public class Election
    {
        // skapar en bra List utav typen Party(klassen)
        public List<Party> Parties { get; set; } = new List<Party> { };


        public Party FindPartyByShort(string abbreviation) 
        {
            foreach (Party party in Parties)
            {
                if (party.Abbreviation.ToUpper().Equals(abbreviation.ToUpper()))
                {
                    return party;
                }
            }
            return null;
        }
    }
}
