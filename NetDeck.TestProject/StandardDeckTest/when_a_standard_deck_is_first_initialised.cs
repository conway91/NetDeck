using System.Collections.Generic;
using System.Linq;
using NetDeck.Cards;
using NetDeck.Decks;
using NUnit.Framework;

namespace NetDeck.Test.StandardDeckTest
{
    [TestFixture]
    public class when_a_standard_deck_is_first_initialised
    {
        private StandardDeck _standardDeck;

        [SetUp]
        public void Init()
        {
            _standardDeck = new StandardDeck();
        }

        [Test]
        public void it_should_contain_52_cards()
        {
            Assert.AreEqual(52, _standardDeck.CurrentCardCount());
        }

        [Test]
        public void all_deck_cards_should_be_unique()
        {
            var fullDeck = new List<StandardPlayingCard>();
            var deckCount = _standardDeck.CurrentCardCount();

            for (var i = 0; i < deckCount; i++)
            {
                fullDeck.Add(_standardDeck.DrawCard());
            }

            Assert.IsTrue(fullDeck.Distinct().Count() == deckCount);
        }
    }
}
