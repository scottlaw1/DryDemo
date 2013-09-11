using System.Collections.Generic;

namespace Ffl.Domain
{
    public class DefensiveBacks : RosterGroup<DefensiveBack>
    {
        public DefensiveBacks(IEnumerable<DefensiveBack> players) : base(players)
        {
        }
    }
}