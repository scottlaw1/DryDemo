namespace Ffl.Domain
{
    public abstract class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public abstract Position Position { get; }
    }
}