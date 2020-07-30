using System.Collections.Generic;
using Wow.Domain.Enums;

namespace Wow.Domain.Abstract
{
    public abstract class Class
    {
        public List<string> RacialSkills { get; set; }
        public ClassType ClassType { get;  set; }
        public RaceType RaceType { get; set; }

        protected Class()
        {
            
        }

        protected Class(List<string> racialSkills, ClassType classType, RaceType raceType)
        {
            RacialSkills = racialSkills;
            ClassType = classType;
            RaceType = raceType;
        }
     
    }
}