using System;
using System.Collections.Generic;
using System.Linq;
using Cards.Interfaces;

namespace Cards
{
    public class Deck : IDeck
    {
        public Deck(IEnumerable<ICard> cards)
        {
            if (cards == null || !cards.Any())
            {
                throw new ArgumentException("Cards cannot be null or empty.", "cards");
            }

            Cards = cards;
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
    }
}
