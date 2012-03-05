using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    deck[(i * a) - 1] = new Card((Suit)i, a);
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
