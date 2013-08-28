namespace Ffl.Domain
{
    public abstract class Player : IPosition
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public abstract Position Position { get; }
    }
}