using System.Collections.Generic;
using CardLib;

namespace GameEngine
{
    public class PokeWar
    {
        private CardDeck _deck;
        private Player _player1;
        private Player _player2;

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
            //TODO remove the 4 ace cards
            GetAceCards();
            _player1 = p1;
            _player2 = p2;
        }

        public void Setup()
        {

        }

        public void PlayTurn()
        {

        }

        public void Cleanup()
        {

        }
    }
}
