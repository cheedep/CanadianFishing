using System;
using Cards.Interfaces;
using NUnit.Framework;

namespace Cards.Tests
{
    [TestFixture]
    class CardTests
    {
        [Test]
        public void CardShouldbeOfTypeICard()
        {
            var card = new Card(Rank.Ace, SuitType.Club);
            Assert.IsInstanceOf<ICard>(card);
        }

        [Test]
        public void CardShouldThrowArgumentExceptionIfRankIsJoker()
        {
            Assert.Throws<ArgumentException>(() => new Card(Rank.Joker, SuitType.Club));
        }

        [Test]
        public void CardShouldThrowArgumentExceptionIfSuitTypeIsSpecial()
        {
            Assert.Throws<ArgumentException>(() => new Card(Rank.Ace, SuitType.Special));
        }
    }
}
