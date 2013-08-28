using System.Collections.Generic;

namespace Ffl.Domain
{
    public class OffensiveLinemen : PositionGroup<OffensiveLineman>
    {
        public OffensiveLinemen(IEnumerable<OffensiveLineman> players)
            : base(players)
        {
        }
    }
}