using System;
using System.Collections.Generic;
using System.Linq;
using Cards.Interfaces;

namespace Cards
{
    public class DeckFactory
    {
        public static Deck Build(int numberOfJokers)
        {
            var cards = new List<ICard>();

            var suits = Enum.GetValues(typeof(SuitType));
            var ranks = Enum.GetValues(typeof(Rank));

            foreach (SuitType suit in suits)
            {
                if (suit == SuitType.Special)
                {
                    continue;
                }

                foreach (Rank rank in ranks)
                {
                    if (rank == Rank.Joker)
                    {
                        continue;
                    }

                    cards.Add(new Card(rank, suit));
                }
            }

            for (int i = 0; i < numberOfJokers; i++)
            {
                cards.Add(new Joker(i + 1));
            }

            return new Deck(cards);
        }
    }
}
