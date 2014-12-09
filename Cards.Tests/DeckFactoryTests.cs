using System.Linq;
using NUnit.Framework;

namespace Cards.Tests
{
    [TestFixture]
    class DeckFactoryTests
    {
        [Test]
        public void BuildWith0JokersShouldReturn52Cards()
        {
            var deck = DeckFactory.Build(0);
            Assert.AreEqual(52, deck.Count());
        }

        [Test]
        public void BuildWithNJokersShouldNDistinguishableJokers()
        {
            int n = 4;
            var deck = DeckFactory.Build(n);

            Assert.AreEqual(52 + n , deck.Count());

            var jokers = deck.Where(x => x.Rank == Rank.Joker).Cast<Joker>().ToList();
            Assert.AreEqual(n, jokers.Count);

            foreach (var joker in jokers)
            {
                Assert.AreEqual(1, jokers.Count(x => x.JokerNumber == joker.JokerNumber));
            }
        }
    }
}
