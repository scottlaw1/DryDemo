using System.Collections.Generic;

namespace Ffl.Domain
{
    public interface IRosterGroup<out TPlayer> : IValueObject
    {
        IEnumerable<TPlayer> Players { get; }
    }
}