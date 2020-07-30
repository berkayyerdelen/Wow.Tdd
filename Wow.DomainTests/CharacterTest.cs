using System;
using System.Collections.Generic;
using FluentAssertions;
using Wow.Domain.Abstract;
using Wow.Domain.Enums;
using Xunit;

namespace Wow.DomainTests
{
    public class CharacterTest
    {
        [Fact]
        public void Should_Create_Character_Return_Exception_On_Invoking_RacialSkill()
        {
            var character = new CharacterMock(Gender.Male, "Dualist", 10000);
            character.Gender.Should().Be(Gender.Male);
            character.Name.Should().Be("Dualist");
            character.HitPoints.Should().Be(10000);
            character.RacialSkills.Invoking(y => y.Count).Should().Throw<NullReferenceException>();
        }

        [Fact]
        public void Should_Create_Character_Without_Exception()
        {
            var character = new CharacterMock(Gender.Female, "Layala", 10000,
                ClassType.Priest,
                RaceType.BloodElf,
                1000,
                new List<string>()
                {
                    "Arcane Acuity","Arcane Affinity"
                });
            character.Gender.Should().Be(Gender.Female);
            character.RaceType.Should().Be(RaceType.BloodElf);
            character.ClassType.Should().Be(ClassType.Priest);
            character.RacialSkills.Count.Should().Be(2);
            character.HitPoints.Should().Be(10000);

        }

    }

    public class CharacterMock : Character
    {
        public CharacterMock(Gender gender, string name, double hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            Gender = gender;

        }

        public CharacterMock(Gender gender, string name, double hitPoints,
            ClassType classType, RaceType raceType, double mana,
            List<string> racialSkills)
        {
            Name = name;
            HitPoints = hitPoints;
            Gender = gender;
            ClassType = classType;
            RaceType = raceType;
            RacialSkills = racialSkills;
            Mana = mana;
        }
    }

}