using System.Drawing;
using System.IO;

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
        public Image FrontImage { get; private set; }
        public Image BackImage { get; private set; }
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
        /// Creates a card with the images.
        /// </summary>
        /// <param name="s">Suit</param>
        /// <param name="r">Rank</param>
        /// <param name="f">Front Image URL</param>
        /// <param name="b">Back Image URL</param>
        public Card(Suit s, int r, string f, string b)
        {
            Suit = s;
            Rank = r;
            FaceUp = false;
            frontImgSource = f;
            backImgSource = b;
            loadImages();
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
            this.frontImgSource = c.frontImgSource;
            this.backImgSource = c.backImgSource;
            loadImages();
        }

        /// <summary>
        /// Sets the image sources and attempts to load the images.
        /// </summary>
        /// <param name="f">Front Image URL</param>
        /// <param name="b">Back Image URL</param>
        public void SetImageSources(string f, string b)
        {
            frontImgSource = f;
            backImgSource = b;
            loadImages();
        }

        private void loadImages()
        {
            try
            {
                if (frontImgSource != null)
                    FrontImage = Image.FromFile(frontImgSource);
            }
            catch (FileNotFoundException e) { FrontImage = null; }
            try
            {
                if (backImgSource != null)
                    BackImage = Image.FromFile(backImgSource);
            }
            catch (FileNotFoundException e) { BackImage = null; }
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
