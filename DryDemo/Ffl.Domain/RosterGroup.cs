using System;
using System.Collections.Generic;
using System.Linq;

namespace Ffl.Domain
{
    public abstract class RosterGroup<TPlayer> : IRosterGroup<TPlayer>, IEquatable<RosterGroup<TPlayer>>
    {
        public bool Equals(RosterGroup<TPlayer> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Players, other.Players);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RosterGroup<TPlayer>) obj);
        }

        public override int GetHashCode()
        {
            return (Players != null ? Players.GetHashCode() : 0);
        }

        private List<TPlayer> players = new List<TPlayer>(); 

        public IEnumerable<TPlayer> Players
        {
            get { return players.AsReadOnly(); } 
            private set { players = value.ToList(); }
        }

        protected RosterGroup(IEnumerable<TPlayer> players)
        {
            if (players != null) this.players.AddRange(players);
        } 
    }
}