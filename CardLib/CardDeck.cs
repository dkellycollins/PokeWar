using System;
using System.Collections.Generic;
namespace CardLib
{
    public class CardDeck
    {
        private List<Card> deck = new List<Card>();
        private int topCard;

        public CardDeck()
        {
            //Makes a deck
            deck = new List<Card>(52);
            for(int i = 1; i <= 4; i++)
            {
                for(int a = 1; a <= 13; a++)
                {
                    Card c = new Card((Suit)i, a);
                    c.SetImageSources(
                        DeckSettings.Default.FrontImgBaseName + c.ToString() + DeckSettings.Default.ImageExtention, 
                        DeckSettings.Default.BackImgSource + DeckSettings.Default.ImageExtention);
                    deck.Add(c);
                }
            }
        }

        public Card Draw()
        {
            if (topCard == 0)
                throw new InvalidOperationException("There are not cards to draw!");

            Card draw = new Card(deck[topCard]);
            topCard--;
            return draw;
        }

        public void Shuffle(int count)
        {   //Returns all Cards, the shuffles them count number of times.
            ReturnAllCards();
            System.Random random = new System.Random();
            for (int a = 0; a < count; a++)
            {
                for (int i = 0; i < deck.Count; i++)
                {
                    int j = random.Next(deck.Count);
                    Card temp = deck[i];
                    deck[i] = deck[j];
                    deck[j] = temp;
                }
            }
        }

        public void ReturnAllCards()
        {
            topCard = 51;
        }

        public Card Find(Suit s, int r)
        {
            int index = deck.FindIndex(item => item.Suit.Equals(s) && item.Rank.Equals(r));
            Card c = deck[index];
            Card temp = deck[topCard];
            deck[topCard] = c;
            deck[index] = temp;
            return deck[topCard--];
        }
    }
}
