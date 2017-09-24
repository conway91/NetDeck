using System.Collections.Generic;
using System.Linq;
using NetDeck.Cards;
using NetDeck.Decks;
using NUnit.Framework;

namespace NetDeck.Test.StandardDeckTest
{
    [TestFixture]
    public class when_a_standard_deck_is_refreshed
    {
        private StandardDeck _standardDeck;
        private int _fullDeckCount;

        [SetUp]
        public void Init()
        {
            _standardDeck = new StandardDeck();
            _fullDeckCount = _standardDeck.CurrentCardCount();

            for (var i = 0; i < 10; i++)
            {
                _standardDeck.DrawCard();
            }

            _standardDeck.RefeshDeck();
        }


        [Test]
        public void the_card_count_is_back_to_the_full_total()
        {
            Assert.AreEqual(_fullDeckCount, _standardDeck.CurrentCardCount());
        }

        [Test]
        public void all_deck_cards_are_unique()
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
