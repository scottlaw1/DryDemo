using System.Collections.Generic;

namespace Ffl.Domain
{
    public class SpecialTeamsPlayers : RosterGroup<SpecialTeamsPlayer>
    {
        public SpecialTeamsPlayers(IEnumerable<SpecialTeamsPlayer> players) : base(players)
        {
        }
    }
}