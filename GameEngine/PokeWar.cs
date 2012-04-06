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
                Card c = _deck.Remove((Suit)i, 13);
                aces.Add(c);
            }
            return aces;
        }

        public PokeWar(Player p1, Player p2)
        {
            _deck = new CardDeck();
            Player1 = p1;
            Player2 = p2;
        }

        public void Setup()
        {
            //Shuffles the deck thrice.
            _deck.Shuffle(3);

            //Gets the Aces.
            List<Card> aces = GetAceCards();

            //Splits the deck between the players.
            for (int i = _deck.Size(); i >= 0; i-=2)
            {
                Player1.Hand.Add(_deck.Draw());
                Player2.Hand.Add(_deck.Draw());
            }
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
            Player1.Hand.Equals(null);
            Player2.Hand.Equals(null);
            _deck.ReturnAllCards();
        }
    }
}
