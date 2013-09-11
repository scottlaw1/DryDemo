using System.Collections.Generic;

namespace Ffl.Domain
{
    public class SkillPlayers : RosterGroup<SkillPlayer>
    {
        public SkillPlayers(IEnumerable<SkillPlayer> players) : base(players)
        {
        }
    }
}
