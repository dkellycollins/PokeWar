using System.Collections.Generic;
using CardLib;
using PokeWar.Engine.Players;

namespace PokeWar.Engine
{
    /// <summary>
    /// Main controlling class for the pokewar game.
    /// </summary>
    public class PokeWarEngine
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public ImageManager ImageManager { get; private set; }
        public IOInterface IO { get; private set; }

        private CardDeck _deck;
        private List<Card> fieldCards;        

        public PokeWarEngine(Player p1, Player p2, IOInterface io)
        {
            _deck = new CardDeck();
            Player1 = p1;
            Player2 = p2;
            IO = io;
            ImageManager = new ImageManager();
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
                int result = calculateResult(player1Card, player2Card);


                if (result == 0)
                {
                    //Joker played clear all cards.
                    fieldCards.Clear();
                }
                else if (result == 3)
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
                else if (result == 1)
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

        private List<Card> getAceCards()
        {
            List<Card> aces = new List<Card>(4);
            for (int i = 1; i <= 4; i++)
            {
                Card c = _deck.Draw((Suit)i, 13);
                aces.Add(c);
            }
            return aces;
        }

        private void setup()
        {
            //Shuffles the deck thrice.
            _deck.Shuffle(3);

            //Splits the deck between the players.
            for (int i = _deck.Size(); i >= 0; i-=2)
            {
                Player1.Deal(_deck.Draw());
                Player2.Deal(_deck.Draw());
            }
        }

        //Determines the winner from the two cards and returns a code.
        //0: A joker was played.
        //1: Player1 won.
        //2: Player2 won.
        //3: Players tied.
        private int calculateResult(Card player1Card, Card player2Card)
        {
            throw new System.NotImplementedException();
        }

        private void endGame()
        {
            throw new System.NotImplementedException();
        }

        private void selectAceCard()
        {
            
        }

        public void Cleanup()
        {
            Player1.Hand.Equals(null);
            Player2.Hand.Equals(null);
            _deck.ReturnAllCards();
        }
    }
}
