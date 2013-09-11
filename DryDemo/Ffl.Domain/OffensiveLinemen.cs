using System.Collections.Generic;

namespace Ffl.Domain
{
    public class OffensiveLinemen : RosterGroup<OffensiveLineman>
    {
        public OffensiveLinemen(IEnumerable<OffensiveLineman> players)
            : base(players)
        {
        }
    }
}