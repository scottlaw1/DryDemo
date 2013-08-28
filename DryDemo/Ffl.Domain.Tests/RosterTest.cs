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
                new Quarterback {FirstName = "Robert", LastName = "Griffin", Team = "Washington Redskins"},
                new Quarterback {FirstName = "Kirk", LastName = "Cousins", Team = "Washington Redskins"},
                new Quarterback {FirstName = "Rex", LastName = "Grossman", Team = "Washington Redskins"}
            };

            var quarterbacks = new Quarterbacks(qbsToAdd);

            roster.ChangeQuarterbacks(quarterbacks);

            Assert.AreEqual(quarterbacks, roster.Quarterbacks);
        }
    }
}
