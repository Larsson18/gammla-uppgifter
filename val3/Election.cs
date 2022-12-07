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

        // Denna metod tar med sig abbreviation 
        public Party FindPartyByShort(string abbreviation) 
        {
            // sedan går igenom en foreach loop som kollar igen alla "parties" inom listan party.
            foreach (Party party in Parties)
            {
                // Denna if sats kollar ifall abbreviation inom party listan och inputen i main window matchar.
                if (party.Abbreviation.ToUpper().Equals(abbreviation.ToUpper()))
                {
                    // ifall de matchar returnas party
                    return party;
                }
            }
            // annars returnas inget
            return null;
        }
    }
}
