using System;
using System.Collections.Generic;
using Cards.Interfaces;
using NUnit.Framework;

namespace Cards.Tests
{
    [TestFixture]
    public class SuitTests
    {
        [Test]
        public void SuitShouldBeAnEnumerableOfCards()
        {
            var suit = new Suit(new List<ICard> { new Card(Rank.Ace, SuitType.Club) }, SuitType.Club);
            Assert.IsInstanceOf<IEnumerable<ICard>>(suit);
        }

        [Test]
        public void SuitShouldThrowIfSuitTypeIsSpecial()
        {
            Assert.Throws<ArgumentException>(() => new Suit(new List<ICard> { new Card(Rank.Ace, SuitType.Club) }, SuitType.Special));
        }

        [Test]
        public void SuitShouldThrowIfCardsIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Suit(null, SuitType.Club));
        }

        [Test]
        public void SuitShouldThrowIfCardsIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Suit(new List<ICard>(), SuitType.Club));
        }

        [Test]
        public void SuitShouldThrowIfAllCardsAreNotOfSuitType()
        {
            Assert.Throws<ArgumentException>(() => new Suit(new List<ICard> { new Card(Rank.Ace, SuitType.Club) }, SuitType.Heart));
        }
    }
}
