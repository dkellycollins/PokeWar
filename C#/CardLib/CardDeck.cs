using System;
using System.Collections.Generic;
namespace CardLib
{
    public class CardDeck
    {
        private List<Card> deck = new List<Card>();
        private int topCard;

        /// <summary>
        /// Creates a new deck of cards.
        /// </summary>
        /// <param name="addJokers">If true, two joker cards will be added to the deck.</param>
        public CardDeck(bool addJokers = true)
        {
            deck = new List<Card>(52);
            for(int i = 1; i <= 4; i++)
            {
                for(int a = 1; a <= 13; a++)
                {
                    Card c = new Card((Suit)i, a);
                    deck.Add(c);
                }
            }

            if (addJokers)
            {
                deck.Add(new Card(Suit.Joker, 0));
                deck.Add(new Card(Suit.Joker, 0));
            }

            topCard = deck.Count - 1;
        }

        /// <summary>
        /// Draws a single card from the deck.
        /// </summary>
        /// <returns>The drawn card.</returns>
        public Card Draw()
        {
            if (topCard < 0)
                throw new InvalidOperationException("There are no cards to draw!");

            return deck[topCard--];
        }

        /// <summary>
        /// Draws the given number of cards from the deck.
        /// </summary>
        /// <param name="numCards">Number of cards to draw.</param>
        /// <returns>An array of cards.</returns>
        public Card[] Draw(int numCards)
        {
            Card[] cards = new Card[numCards];
            for(int i = 0; i < numCards; i++)
            {
                cards[i] = Draw();
            }
            return cards;
        }

        /// <summary>
        /// Draws a certain card from the deck.
        /// </summary>
        /// <param name="s">Suit of card.</param>
        /// <param name="r">Rank of card.</param>
        /// <returns>Drawn card.</returns>
        public Card Draw(Suit s, int r)
        {
            int index = deck.FindIndex(item => item.Suit.Equals(s) && item.Rank.Equals(r));

            //Swap cards so that the one we want is the next one drawn.
            Card temp = deck[topCard];
            deck[topCard] = deck[index];
            deck[index] = temp;

            return Draw();
        }

        /// <summary>
        /// Shuffles the deck.
        /// </summary>
        /// <param name="count">The number of times to shuffle the deck.</param>
        public void Shuffle(int count = 1)
        {
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

        /// <summary>
        /// Puts all cards back in play and set FaceUp = false for all cards.
        /// </summary>
        public void ReturnAllCards()
        {
            topCard = deck.Count - 1;
            deck.ForEach((x) => x.FaceUp = false);
        }

        /// <summary>
        /// Returns the numbers of cards left in the deck.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return topCard + 1;
        }
    }
}
