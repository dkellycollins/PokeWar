namespace CardDeck
{
    public class CardDeck
    {
        private Card[] deck;
        private int topCard;

        public CardDeck()
        {
            deck = new Card[52];
            for(int i = 1; i <= 4; i++)
            {
                for(int a = 1; a <= 13; a++)
                {
                    Card c = new Card((Suit)i, a);
                    c.SetImageSources(
                        DeckSettings.Default.FrontImgBaseName + c.ToString() + DeckSettings.Default.ImageExtention, 
                        DeckSettings.Default.BackImgSource + DeckSettings.Default.ImageExtention);
                    deck[(i * a) - 1] = c;
                }
            }
            topCard = 52;
        }

        public Card Draw()
        {
            return null;
        }

        public void Shuffle(int count)
        {

        }

        public void ReturnAllCards()
        {

        }
    }
}
