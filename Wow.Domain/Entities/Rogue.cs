using System.Collections.Generic;
using Wow.Domain.Abstract;

namespace Wow.Domain.Entities
{
    public class Rogue: Class
    {
        public bool IsInCombat { get; set; }
        public bool IsInStealth { get; set; }
        public int Energy { get; set; }
        public  Dictionary<string,bool> Poisons { get; set; }

        public Rogue()
        {
            
        }

        public bool Sap(bool isInStealth, int energy)
        {
            
        }

        public Rogue(bool ısInCombat, bool ısInStealth, int energy, Dictionary<string, bool> poisons)
        {
            IsInCombat = ısInCombat;
            IsInStealth = ısInStealth;
            Energy = energy;
            Poisons = poisons;
        }
    }
}