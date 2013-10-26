using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardLib;

namespace PokeWar.Engine.Players
{
    public abstract class Player
    {
        //Maximun amount of the cards that can be in a hand.
        private const int HAND_SIZE = 6;

        //The cards that the play cannot see yet.
        private Stack<Card> _deck;

        /// <summary>
        /// Cards currently in hand.
        /// </summary>
        public List<Card> Hand { get; private set; }

        /// <summary>
        /// Name of player.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Card that represents this character.
        /// </summary>
        public Card PlayerCard { get; internal set; }

        /// <summary>
        /// Number of cards this player has.
        /// </summary>
        public int NumberOfCards
        {
            get
            {
                return Hand.Count + _deck.Count;
            }
        }

        /// <summary>
        /// Creates a new player.
        /// </summary>
        public Player()
        {
            _deck = new Stack<Card>();
            Hand = new List<Card>(HAND_SIZE);
        }

        /// <summary>
        /// Adds a card to Hand.
        /// </summary>
        /// <param name="card"></param>
        public void Deal(Card card)
        {
            if (Hand.Count < HAND_SIZE)
                Hand.Add(card);
            else
                _deck.Push(card);
        }

        /// <summary>
        /// Adds cards to the Hand
        /// </summary>
        /// <param name="cards">Cards to add.</param>
        public void Deal(Card[] cards)
        {
            foreach (Card card in cards)
                Deal(card);
        }

        public void Reset()
        {
            _deck.Clear();
            Hand.Clear();
            PlayerCard = null;
        }

        /// <summary>
        /// Gets the card the player wants to play.
        /// </summary>
        /// <returns></returns>
        public abstract Card PlayCard();

        public abstract int SelectAceCard();

        /// <summary>
        /// Handles getting a card from the hand and adding a new card if possible.
        /// </summary>
        /// <param name="index">index of the card in the hand.</param>
        /// <returns></returns>
        protected Card getFromHand(int index)
        {
            Card card = Hand[index];
            Hand.RemoveAt(index);
            if (_deck.Count > 0)
                Hand.Add(_deck.Pop());
            return card;
        }
    }
}
