using System.Collections.Generic;

namespace Ffl.Domain
{
    public interface IPositionGroup<out TPlayer> : IValueObject
    {
        IEnumerable<TPlayer> Players { get; }
    }
}