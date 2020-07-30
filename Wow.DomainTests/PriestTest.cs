using System;
using FluentAssertions;
using Wow.Domain.Entities;
using Wow.Domain.Enums;
using Xunit;

namespace Wow.DomainTests
{
    public class PriestTest
    {
        [Fact]
        public void Should_Create_Priest()
        {
            var aziel = new Priest()
            {
                Mana = 10000,
                ClassType = ClassType.Priest,
                RaceType = RaceType.BloodElf
            };
            
            aziel.Mana.Should().Be(10000);
            aziel.ClassType.Should().Be(ClassType.Priest);
            aziel.RaceType.Should().Be(RaceType.BloodElf);

        }

        [Fact]
        public void Should_Priest_Resurrect_Friend()
        {
            var aziel = new Priest()
            {
                Mana = 10000
            };
            aziel.Resurrection(5000);
            aziel.Mana.Should().Be(5000);
        }

        [Fact]
        public void Should_Priest_Not_Resurrect_Friend()
        {
            var aziel = new Priest(true)
            {
                Mana = 10000
            };
            aziel.Invoking(x => x.Resurrection(500)).Should().Throw<Exception>().
                WithMessage("You're still in combat!");
        }

        [Fact]
        public void Should_Priest_Have_Enough_Mana_For_Resurrection_Throw_Exception()
        {
            var aziel = new Priest(false)
            {
                Mana = 5000
            };
            aziel.Invoking(x => x.Resurrection(10000)).Should().Throw<Exception>()
                .WithMessage("You dont have enough mana for resurrection!");
        }



    }
}