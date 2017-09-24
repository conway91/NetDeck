using System;
using NetDeck.Decks;
using NUnit.Framework;

namespace NetDeck.TestProject.StandardDeckTest
{
    [TestFixture]
    public class when_a_standard_deck_deck_count_is_below_one
    {
        private StandardDeck _standardDeck;

        [SetUp]
        public void Init()
        {
            _standardDeck = new StandardDeck();
        }


        [Test]
        public void the_card_count_matches()
        {
            Assert.Throws<ArgumentException>(() => _standardDeck.SetAmountOfDecksToUse(0), $"Amount of decks to use must be more than 0. Value entered was '0'.");
        }
    }
}
