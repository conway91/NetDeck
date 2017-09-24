using System;
using System.Collections.Generic;

namespace NetDeck.Cards
{
    internal static class CardValues
    {
        internal static KeyValuePair<char, string>[] StandardPlayingCardSuits = 
        {
            new KeyValuePair<char, string>('H', "Hearts"),
            new KeyValuePair<char, string>('C', "Clubs"),
            new KeyValuePair<char, string>('D', "Diamonds"),
            new KeyValuePair<char, string>('S', "Spades")
        };

        internal static Tuple<string, int, int>[] StandardPlayingCardValues =
        {
            Tuple.Create("2", 2, 1),
            Tuple.Create("3", 3, 2),
            Tuple.Create("4", 4, 3),
            Tuple.Create("5", 5, 4),
            Tuple.Create("6", 6, 5),
            Tuple.Create("7", 7, 6),
            Tuple.Create("8", 8, 7),
            Tuple.Create("9", 9, 8),
            Tuple.Create("10", 10, 9),
            Tuple.Create("J", 10, 10),
            Tuple.Create("Q", 10, 11),
            Tuple.Create("K", 10, 12),
            Tuple.Create("A", 11, 13),
        };
    }
}
