namespace Ffl.Domain
{
    public class Roster
    {
        public Quarterbacks Quarterbacks { get; private set; }
        public OffensiveLinemen OffensiveLinemen { get; private set; }
        public DefensiveBacks DefensiveBacks { get; private set; }
        public SpecialTeamsPlayers SpecialTeamsPlayers { get; private set; } 

        public void ChangeQuarterbacks(Quarterbacks quarterbacks)
        {
            Quarterbacks = quarterbacks;
        }

        public void ChangeOffensiveLinemen(OffensiveLinemen offensiveLinemen)
        {
            OffensiveLinemen = offensiveLinemen;
        }

        public void ChangeSpecialTeams(SpecialTeamsPlayers specialTeamsPlayers)
        {
            SpecialTeamsPlayers = specialTeamsPlayers;
        }

        public void ChangeDefensiveBacks(DefensiveBacks defensiveBacks)
        {
            DefensiveBacks = defensiveBacks;
        }
    }
}
