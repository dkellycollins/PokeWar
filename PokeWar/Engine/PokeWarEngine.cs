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
        private static string[] AceCardNames = new string[]
        {
            "Gary Oak", //Fire
            "May", //Grass
            "Misty", //Water
            "Ash Ketchum", //Electric
        };

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public ImageManager ImageManager { get; private set; }

        private CardDeck _deck;
        private List<Card> _fieldCards;
        private IOutput _output;

        public PokeWarEngine(Player p1, Player p2, IOutput output)
        {
            Player1 = p1;
            Player2 = p2;
            ImageManager = new ImageManager();
            _output = output;
            _deck = new CardDeck();
            _fieldCards = new List<Card>();
        }

        /// <summary>
        /// Main method. Will play an entire game.
        /// </summary>
        public void Play()
        {
            selectAceCard(); //Select an ace card.
            setup(); //Setup the game.

            while (Player1.NumberOfCards > 0 && Player2.NumberOfCards > 0) //while there is no winner.
            {
                //Each player selects a card.
                Card player1Card = Player1.PlayCard();
                Card player2Card = Player2.PlayCard();
                _fieldCards.Add(player1Card);
                _fieldCards.Add(player2Card);

                _output.UpdateDisplay(string.Format("{0} played {1}", Player1.Name, player1Card.ToString()));
                _output.UpdateDisplay(string.Format("{0} played {1}", Player2.Name, player2Card.ToString()));

                int result = calculateResult(player1Card, player2Card);

                if (result == 3)
                {
                    //Joker played clear all cards.
                    _output.UpdateDisplay("Team Rocket is blasting off again!");
                    _fieldCards.Clear();
                }
                else if (result == 0)
                {
                    //Ranks are equal. Start/Continue war.
                    _output.UpdateDisplay("War! Select three cards.");
                    for (int i = 0; i < 3; i++)
                    {
                        _fieldCards.Add(Player1.PlayCard());
                        _fieldCards.Add(Player2.PlayCard());
                    }
                }
                else if (result == 1)
                {
                    finishRound(Player1, player1Card, player2Card);
                    //Player1 wins gets all cards on the field.
                }
                else
                {
                    finishRound(Player2, player1Card, player2Card);
                    //Player2 wins gets all cards on the field.
                }

                _output.UpdateDisplay(string.Format("{0} has {1} cards.", Player1.Name, Player1.NumberOfCards));
                _output.UpdateDisplay(string.Format("{0} has {1} cards.", Player2.Name, Player2.NumberOfCards));
            }

            endGame(); //handle win.
            cleanup();
        }

        private void finishRound(Player player, Card p1Card, Card p2Card)
        {
            _output.UpdateDisplay(string.Format("{0} wins the round.", player.Name));

            player.Deal(_fieldCards.ToArray());
            _fieldCards.Clear();
        }

        private void setup()
        {
            //Shuffles the deck thrice.
            _deck.Shuffle(3);

            //Splits the deck between the players.
            while(_deck.Size() > 0)
            {
                Card card = _deck.Draw();
                card.FaceUp = true;
                if (_deck.Size() % 2 == 0)
                    Player1.Deal(card);
                else
                    Player2.Deal(card);
            }
        }

        //Determines the winner from the two cards and returns a code.
        //3: A joker was played.
        //1: Player1 won.
        //-1: Player2 won.
        //0: Players tied.
        private int calculateResult(Card player1Card, Card player2Card)
        {
            if (player1Card.Suit == Suit.Joker || player2Card.Suit == Suit.Joker)
                return 3;

            int player1Rank = player1Card.Rank;
            int player2Rank = player2Card.Rank;

            if (player1Card.Suit == Player1.PlayerCard.Suit)
                player1Rank++;
            if (player2Card.Suit == Player2.PlayerCard.Suit)
                player2Rank++;

            switch (player1Card.Suit)
            {
                case Suit.Club:
                    if (player2Card.Suit == Suit.Heart)
                        player1Rank++;
                    else if (player2Card.Suit == Suit.Diamond)
                        player2Rank++;
                    break;
                case Suit.Diamond:
                    if (player2Card.Suit == Suit.Club)
                        player1Rank++;
                    else if (player2Card.Suit == Suit.Heart)
                        player2Rank++;
                    break;
                case Suit.Heart:
                    if (player2Card.Suit == Suit.Diamond)
                        player1Rank++;
                    else if (player2Card.Suit == Suit.Club)
                        player2Rank++;
                    break;
            }

            return player1Rank - player2Rank;
        }

        private void endGame()
        {
            if (Player1.NumberOfCards > 0)
                _output.UpdateDisplay(Player1.Name + " wins!");
            else
                _output.UpdateDisplay(Player2.Name + " wins!");
        }

        private void selectAceCard()
        {
            Card[] aces = new Card[4];
            for (int i = 1; i <= 4; i++)
            {
                aces[i-1] = _deck.Draw((Suit)i, 1);
            }

            int player1Selection = Player1.SelectAceCard();
            int player2Selection;
            if (Player2 is ComputerPlayer)
                player2Selection = (Player2 as ComputerPlayer).SelectAceCard((Suit)player1Selection + 1);
            else
                player2Selection = Player2.SelectAceCard();

            Player1.Name = AceCardNames[player1Selection];
            Player1.PlayerCard = aces[player1Selection];
            Player2.Name = AceCardNames[player2Selection];
            Player2.PlayerCard = aces[player2Selection];
        }

        private void cleanup()
        {
            Player1.Reset();
            Player2.Reset();
            _deck.ReturnAllCards();
            //ImageManager.Reset();
        }
    }
}
