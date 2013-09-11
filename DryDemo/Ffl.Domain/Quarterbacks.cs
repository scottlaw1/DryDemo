using System.Collections.Generic;

namespace Ffl.Domain
{
    public class Quarterbacks: RosterGroup<Quarterback>
    {
        public Quarterbacks(IEnumerable<Quarterback> players)
            : base(players)
        {
        }
    }
}