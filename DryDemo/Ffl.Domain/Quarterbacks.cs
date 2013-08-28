using System.Collections.Generic;

namespace Ffl.Domain
{
    public class Quarterbacks: PositionGroup<Quarterback>
    {
        public Quarterbacks(IEnumerable<Quarterback> players)
            : base(players)
        {
        }
    }
}