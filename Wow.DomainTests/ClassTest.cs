using System.Collections.Generic;
using FluentAssertions;
using Wow.Domain.Abstract;
using Wow.Domain.Enums;
using Xunit;

namespace Wow.DomainTests
{
    public class ClassTest
    {
        [Fact]
        public void Should_Create_BloodElf_Rogue()
        {
            var bloodElfRogue = new ClassMock(new List<string>()
                    {"Arcane Affinity", "Arcane Torrent", "Arcane Acuity"},
                RaceType.BloodElf, ClassType.Rogue);

            bloodElfRogue.RacialSkills.Count.Should().Be(3);
            bloodElfRogue.ClassType.Should().Be(ClassType.Rogue);
            bloodElfRogue.RaceType.Should().Be(RaceType.BloodElf);

        }

        [Fact]
        public void Should_Create_NightElf_Druid()
        {
            var nightElfDruid = new ClassMock(new List<string>()
                    {"Wisp Spirit", "Touch of Elune", "Shadowmeld"," Quickness", "Nature Resistance"},
                RaceType.NightElf, ClassType.Druid);

            nightElfDruid.RacialSkills.Count.Should().Be(5);
            nightElfDruid.ClassType.Should().Be(ClassType.Druid);
            nightElfDruid.RaceType.Should().Be(RaceType.NightElf);

        }
    }

    public class ClassMock : Class
    {
        public ClassMock(List<string> racialSkills, RaceType raceType, ClassType classType)
        {
            RacialSkills = racialSkills;
            ClassType = classType;
            RaceType = raceType;
            
        }
    }
}