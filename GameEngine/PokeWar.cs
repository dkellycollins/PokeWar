using System.Collections.Generic;
using CardLib;

namespace GameEngine
{
    public class PokeWar
    {
        private CardDeck _deck;
        private Player _player1;
        private Player _player2;

        public static List<Card> GetAceCards()
        {
            return null;
        }

        public PokeWar(Player p1, Player p2)
        {
            _deck = new CardDeck();
            //TODO remove the 4 ace cards
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
