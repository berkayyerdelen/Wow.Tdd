using System;
using Wow.Domain.Abstract;

namespace Wow.Domain.Entities
{
    public class Priest : Character
    {
        public bool IsinCombat { get; set; }

        public Priest()
        {

        }
        public Priest(bool isInCombat)
        {
            IsinCombat = isInCombat;
        }
        public void Resurrection(double resurrectionCost)
        {
            if (IsinCombat)
            {
                throw new Exception("You're still in combat!");
            }

            if (resurrectionCost > Mana)
            {
                throw new Exception("You dont have enough mana for resurrection!");
            }
            Mana -= resurrectionCost;

        }

    }
}