using NetDeck.Decks;
using NUnit.Framework;

namespace NetDeck.Test.StandardDeckTest
{
    [TestFixture]
    public class when_a_standard_deck_tries_to_draw_from_an_empty_deck
    {
        private StandardDeck _standardDeck;

        [SetUp]
        public void Init()
        {
            _standardDeck = new StandardDeck();
            var deckCount = _standardDeck.CurrentCardCount();

            for (var i = 0; i < deckCount; i++)
            {
                _standardDeck.DrawCard();
            }
        }


        [Test]
        public void the_proper_exception_is_thrown()
        {
            Assert.Throws<EmptyDeckException>(() => _standardDeck.DrawCard(), "Deck does not have any cards. Refresh deck before drawing a card.");
        }
    }
}
