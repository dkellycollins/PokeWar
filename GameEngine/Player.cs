using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardLib;

namespace GameEngine
{
    public class Player
    {
        public string Name { get; private set; }
        public Card PlayerCard { get; private set; }
        public List<Card> Hand { get; private set; }

        public Player(string p, Card card)
        {
            Name = p;
            PlayerCard = card;
        }

        /// <summary>
        /// Adds a card to Hand.
        /// </summary>
        /// <param name="c"></param>
        public void Deal(Card c)
        {
            Hand.Add(c);
        }

    }
}
