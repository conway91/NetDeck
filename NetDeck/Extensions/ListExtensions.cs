﻿using System;
using System.Collections.Generic;

namespace NetDeck.Extensions
{
    internal static class ListExtensions
    {
        private static readonly Random Rng = new Random();

        internal static T PopAt<T>(this List<T> list, int index)
        {
            var r = list[index];
            list.RemoveAt(index);
            return r;
        }

        internal static void Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = Rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
