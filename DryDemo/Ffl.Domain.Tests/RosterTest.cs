using System.Collections.Generic;
using NUnit.Framework;

namespace Ffl.Domain.Tests
{
    [TestFixture]
    public class RosterTest
    {
        [Test]
        public void CanAddQuarterbacks()
        {
            var roster = new Roster();

            var qbsToAdd = new List<Quarterback>
            {
                new Quarterback {FirstName = "Robert", LastName = "Griffin", TeamName = "Washington Redskins"},
                new Quarterback {FirstName = "Kirk", LastName = "Cousins", TeamName = "Washington Redskins"},
                new Quarterback {FirstName = "Rex", LastName = "Grossman", TeamName = "Washington Redskins"},
                new Quarterback {FirstName = "Pat", LastName = "White", TeamName = "Washington Redskins"}
            };

            var quarterbacks = new Quarterbacks(qbsToAdd);

            roster.ChangeQuarterbacks(quarterbacks);

            Assert.AreEqual(quarterbacks, roster.Quarterbacks);
        }

        [Test]
        public void CanAddSpecialTeams()
        {
            var roster = new Roster();

            var specialsToAdd = new List<SpecialTeamsPlayer>
            {
                new Kicker {FirstName = "Kai", LastName = "Forbath", TeamName = "Washington Redskins"},
                new Punter {FirstName = "Sav", LastName = "Rocca", TeamName = "Washington Redskins"}
            };

            roster.ChangeSpecialTeams(new SpecialTeamsPlayers(specialsToAdd));
        }
    }
}
