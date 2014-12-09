using System.Collections.Generic;

namespace Cards.Interfaces
{
    public interface ISuit : IEnumerable<ICard>
    {
        SuitType SuitType { get; }
    }
}
