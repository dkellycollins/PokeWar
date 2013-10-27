using System.Drawing;
using System.IO;

namespace CardLib
{
    /// <summary>
    /// Represents the suit of the cards.
    /// </summary>
    public enum Suit
    {
        Heart = 1,
        Diamond = 2,
        Club = 3,
        Spade = 4,
        Joker = 5
    }

    /// <summary>
    /// Contains information on a playing card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Suit of the card.
        /// </summary>
        public Suit Suit { get; private set; }

        /// <summary>
        /// Rank of the card. Ace would be 1 and King is 13.
        /// </summary>
        public int Rank { get; private set; }

        /// <summary>
        /// Stores if this card is face up or face down.
        /// </summary>
        public bool FaceUp { get; set; }

        /// <summary>
        /// Crates a card with FaceUp = false.
        /// </summary>
        /// <param name="s">The Suit</param>
        /// <param name="r">The Rank</param>
        public Card(Suit s, int r)
        {
            Suit = s;
            Rank = r;
            FaceUp = false;
        }

        /// <summary>
        /// Creates a card.
        /// </summary>
        /// <param name="s">Suit</param>
        /// <param name="r">Rank</param>
        /// <param name="faceup">If this card is face up.</param>
        public Card(Suit s, int r, bool faceup)
        {
            Suit = s;
            Rank = r;
            FaceUp = faceup;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="c">Card to copy</param>
        public Card(Card c)
        {
            this.Suit = c.Suit;
            this.Rank = c.Rank;
            this.FaceUp = c.FaceUp;
        }

#region Overrides

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;

            if(obj is Card)
                return this.Equals(obj as Card);
            return false;
        }

        public bool Equals(Card c)
        {
            if (c == null)
                return false;

            if (c.Suit == this.Suit && c.Rank == this.Rank)
                return true;
            return false;
        }

        //TODO
        //public override int GetHashCode() {}

        private static string[] suitConverter = { "H", "D", "C", "S" };
        private static string[] rankConverter = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

        public override string ToString()
        {
            string str;

            if (FaceUp)
            {
                if (Suit == Suit.Joker)
                    str = "JK";
                else
                    str = suitConverter[(int)Suit - 1] + rankConverter[Rank - 1];
            }
            else
            {
                str = "XX";
            }

            return str;
        }

#endregion
    }
}
