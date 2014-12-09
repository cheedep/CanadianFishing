using System;
using System.Collections.Generic;
using System.Linq;
using Cards.Interfaces;

namespace Cards
{
    public class Suit : ISuit
    {
        public Suit(IEnumerable<ICard> cards, SuitType suitType)
        {
            if (suitType == SuitType.Special)
            {
                throw new ArgumentException("Cannot create a suit of type Special", "suitType");
            }
            if (cards == null || !cards.Any())
            {
                throw new ArgumentException("Cards cannot be null or empty", "cards");
            }
            if (!cards.All(c => c.SuitType == suitType))
            {
                throw new ArgumentException("All cards should be of the same suit", "cards");
            }

            Cards = cards;
            SuitType = suitType;
        }

        private IEnumerable<ICard> Cards { get; set; }

        public IEnumerator<ICard> GetEnumerator()
        {
            return Cards.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SuitType SuitType { get; private set; }
    }
}
