using Wow.Domain.Enums;

namespace Wow.Domain.Abstract
{
    public abstract class Character : Class
    {
        public string Name { get; set; }
        public double HitPoints { get; set; }
        public double Mana { get; set; }
        public Gender Gender { get; set; }

        protected Character(string name, double hitPoints, Gender gender)
        {
            Name = name;
            HitPoints = hitPoints;
            Gender = gender;
        }

        protected Character()
        {
            
        }
       
    }
}