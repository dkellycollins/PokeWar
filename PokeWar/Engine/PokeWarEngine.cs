using System.Collections.Generic;
using CardLib;
using PokeWar.Engine.Players;

namespace PokeWar.Engine
{
    public class PokeWarEngine
    {
        private CardDeck _deck;
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        private List<Card> fieldCards;

        public List<Card> GetAceCards()
        {
            List<Card> aces = new List<Card>(4);
            for (int i = 1; i <= 4; i++)
            {
                Card c = _deck.Draw((Suit)i, 13);
                aces.Add(c);
            }
            return aces;
        }

        public PokeWarEngine(Player p1, Player p2)
        {
            _deck = new CardDeck();
            Player1 = p1;
            Player2 = p2;
        }

        private void setup()
        {
            //Shuffles the deck thrice.
            _deck.Shuffle(3);

            //Gets the Aces.
            List<Card> aces = GetAceCards();

            //Splits the deck between the players.
            for (int i = _deck.Size(); i >= 0; i-=2)
            {
                Player1.Deal(_deck.Draw());
                Player2.Deal(_deck.Draw());
            }
        }

        public void Play()
        {
            selectAceCard(); //Select an ace card.
            setup(); //Setup the game.

            while (Player1.NumberOfCards > 0 && Player2.NumberOfCards > 0) //while there is no winner.
            {
                //Each player selects a card.
                Card player1Card = Player1.PlayCard();
                Card player2Card = Player2.PlayCard();
                int player1Rank = (player1Card.Suit == Player1.PlayerCard.Suit) ? player1Card.Rank + 1 : player1Card.Rank;
                int player2Rank = (player2Card.Suit == Player2.PlayerCard.Suit) ? player2Card.Rank + 1 : player2Card.Rank;

                
                if (player1Card.Suit == Suit.Joker || player2Card.Suit == Suit.Joker)
                {
                    //Joker played clear all cards.
                    fieldCards.Clear();
                }
                else if (player1Rank == player2Rank)
                {
                    //Ranks are equal. Start/Continue war.
                    fieldCards.Add(player1Card);
                    fieldCards.Add(player2Card);
                    for (int i = 0; i < 3; i++)
                    {
                        fieldCards.Add(Player1.PlayCard());
                        fieldCards.Add(Player2.PlayCard());
                    }
                }
                else if (player1Rank > player2Rank)
                {
                    //Player1 wins gets all cards on the field.
                    Player1.Deal(player1Card);
                    Player1.Deal(player2Card);
                    Player1.Deal(fieldCards.ToArray());
                    fieldCards.Clear();
                }
                else
                {
                    //Player2 wins gets all cards on the field.
                    Player1.Deal(player1Card);
                    Player1.Deal(player2Card);
                    Player1.Deal(fieldCards.ToArray());
                    fieldCards.Clear();
                }
            }

            endGame(); //handle win.
        }

        public void Cleanup()
        {
            Player1.Hand.Equals(null);
            Player2.Hand.Equals(null);
            _deck.ReturnAllCards();
        }
    }
}
