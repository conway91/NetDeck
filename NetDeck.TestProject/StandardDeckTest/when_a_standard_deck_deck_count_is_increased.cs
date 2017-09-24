using NetDeck.Decks;
using NUnit.Framework;

namespace NetDeck.Test.StandardDeckTest
{
    [TestFixture]
    public class when_a_standard_deck_deck_count_is_increased
    {
        private StandardDeck _standardDeck;
        private int _originalDeckSize;

        [SetUp]
        public void Init()
        {
            _standardDeck = new StandardDeck();
            _originalDeckSize = _standardDeck.CurrentCardCount();
            _standardDeck.SetAmountOfDecksToUse(2);
        }


        [Test]
        public void the_card_count_matches()
        {
            Assert.AreEqual((_originalDeckSize*2), _standardDeck.CurrentCardCount());
        }
    }
}
