namespace Cards.Interfaces
{
    public interface ICard
    {
        Rank Rank { get; }
        SuitType SuitType { get; }
    }
}
