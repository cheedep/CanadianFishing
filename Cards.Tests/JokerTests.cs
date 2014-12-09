using Cards.Interfaces;
using NUnit.Framework;

namespace Cards.Tests
{
    [TestFixture]
    public class JokerTests
    {
        [Test]
        public void JokerShouldBeOfTypeICard()
        {
            var joker = new Joker(1);
            Assert.IsInstanceOf<ICard>(joker);
        }

        [Test]
        public void JokerShouldBeOfTypeIJoker()
        {
            var joker = new Joker(1);
            Assert.IsInstanceOf<IJoker>(joker);
        }

        [Test]
        public void JokerShouldbeOfRankJoker()
        {
            var joker = new Joker(1);
            Assert.AreEqual(Rank.Joker, joker.Rank);
        }

        [Test]
        public void JokerShouldbeOfSuitTypeSpecial()
        {
            var joker = new Joker(1);
            Assert.AreEqual(SuitType.Special, joker.SuitType);
        }
    }
}
