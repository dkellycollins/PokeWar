using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardDeck
{
    public enum Suit
    {
        Heart = 1,
        Diamond = 2,
        Club = 3,
        Spade = 4
    }

    public class Card
    {
        public Suit Suit { get; private set; }
        public int Rank { get; private set; }
        public bool FaceUp { get; set; }
        private string frontImgSource;
        private string backImgSource;

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
            frontImgSource = null;
            backImgSource = null;
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

        public Image GetFrontImage()
        {
            return null;
        }

        public Image GetBackImage()
        {
            return null;
        }


#region Override

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

        private const string[] suitConverter = { "H", "D", "C", "S" };
        private const string[] rankConverter = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

        public override string ToString()
        {
            if (FaceUp)
                return suitConverter[(int)Suit - 1] + rankConverter[Rank - 1];
            return "XX";
        }

#endregion
    }
}
