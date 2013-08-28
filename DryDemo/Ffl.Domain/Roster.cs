namespace Ffl.Domain
{
    public class Roster
    {
        public Quarterbacks Quarterbacks { get; private set; }
        public OffensiveLinemen OffensiveLinemen { get; private set; }
        
        public void ChangeQuarterbacks(Quarterbacks quarterbacks)
        {
            Quarterbacks = quarterbacks;
        }

        public void ChangeOffensiveLinemen(OffensiveLinemen offensiveLinemen)
        {
            OffensiveLinemen = offensiveLinemen;
        }
    }
}
