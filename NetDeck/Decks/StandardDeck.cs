using System;
using System.Collections.Generic;
using NetDeck.Cards;
using NetDeck.Extensions;

namespace NetDeck.Decks
{
    public class StandardDeck
    {
        private int _amountOfDecks = 1;
        private readonly List<StandardPlayingCard> _deck = new List<StandardPlayingCard>();

        public StandardDeck()
        {
            RefeshDeck();
        }

        public void SetAmountOfDecksToUse(int amountOfDecksToUse)
        {
            if (amountOfDecksToUse < 1)
                throw new ArgumentException($"Amount of decks to use must be more than 0. Value entered was '{amountOfDecksToUse}'.", nameof(amountOfDecksToUse));

            _amountOfDecks = amountOfDecksToUse;
            RefeshDeck();
        }

        public int CurrentCardCount()
        {
            return _deck.Count;
        }

        public StandardPlayingCard DrawCard()
        {
            if (CurrentCardCount() == 0)
                throw new EmptyDeckException("Deck does not have any cards. Refresh deck before drawing a card.");

            return _deck.PopAt(0);
        }

        public void RefeshDeck()
        {
            _deck.Clear();

            for (var i = 0; i < _amountOfDecks; i++)
            {
                foreach (var suit in CardValues.StandardPlayingCardSuits)
                {
                    foreach (var value in CardValues.StandardPlayingCardValues)
                    {
                        var card = new StandardPlayingCard
                        {
                            Suit = suit.Key,
                            FullSuitName = suit.Value,
                            Rank = value.Item1,
                            Value = value.Item2,
                            RankPosition = value.Item3
                        };
                        _deck.Add(card);
                    }
                }
            }

            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            _deck.Shuffle();
        }
    }
}
