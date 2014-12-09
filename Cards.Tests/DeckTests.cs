using System;
using System.Collections.Generic;
using Cards.Interfaces;
using NUnit.Framework;

namespace Cards.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void DeckShouldbeAnEnumerableOfCards()
        {
            var deck = new Deck(new List<Card>{new Card(Rank.Ace, SuitType.Heart)});
            Assert.IsInstanceOf<IEnumerable<ICard>>(deck);
        }

        [Test]
        public void DeckShouldThrowIfCardsIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Deck(null));
        }

        [Test]
        public void DeckShouldThrowArgumentExceptionIfNoCards()
        {
            Assert.Throws<ArgumentException>(() => new Deck(new List<Card>()));
        }
    }
}
