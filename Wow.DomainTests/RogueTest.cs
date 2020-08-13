using System.Collections.Generic;
using FluentAssertions;
using Wow.Domain.Entities;
using Wow.Domain.Enums;
using Xunit;

namespace Wow.DomainTests
{
    public class RogueTest
    {
        [Fact]
        public void Should_Create_New_Rogue()
        {
            var ziq = new Rogue(false, true, 100,
                new Dictionary<string, bool>()
                {
                    {"Main Hand", true},
                    {"Off Hand", true}
                })
            {
                ClassType = ClassType.Rogue,
            };
            ziq.Poisons["Main Hand"].Should().Be(true);
            ziq.Poisons["Off Hand"].Should().Be(true);
            ziq.IsInCombat = false;
            ziq.IsInStealth = true;
            ziq.Energy = 100;
        }
    }
}