using System.Collections.Generic;
using CardLib;

namespace GameEngine
{
    public class PokeWar
    {
        private CardDeck _deck;
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public List<Card> GetAceCards()
        {
            List<Card> aces = new List<Card>(4);
            for (int i = 1; i <= 4; i++)
            {
                Card c = _deck.Find((Suit)i, 13);
                aces.Add(c);
            }
            return aces;
        }

        public PokeWar(Player p1, Player p2)
        {
            _deck = new CardDeck();
            GetAceCards();
            Player1 = p1;
            Player2 = p2;
        }

        public void Setup()
        {

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="UserSelectedCard"></param>
        /// <param name="CompSelectedCard"></param>
        public void PlayRound(Card UserSelectedCard, Card CompSelectedCard)
        {
            throw new System.NotImplementedException();
        }

        public void Cleanup()
        {

        }
    }
}
