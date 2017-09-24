using System;

namespace NetDeck.Cards
{
    public class StandardPlayingCard
    {
        /// <summary>
        /// 
        /// </summary>
        public Char Suit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FullSuitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RankPosition { get; set; }
    }
}
