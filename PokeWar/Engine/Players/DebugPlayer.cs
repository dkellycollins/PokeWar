using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace PokeWar.Engine.Players
{
    /// <summary>
    /// A user player that allows for extra input.
    /// </summary>
    public class DebugPlayer : Player
    {
        private IInput _input;

        public DebugPlayer(IInput input)
            : base()
        {
            _input = input;
        }

        public override Card PlayCard()
        {
            string str1 = "Hand:  ";
            foreach(Card card in Hand)
            {
                str1 += card.ToString() + " ";
            }
            return getFromHand(_input.SelectCard(str1 + "\nEnter your selection: "));
        }

        public override int SelectAceCard()
        {
            return _input.SelectAceCard("Select an ace card (enter 0 - 3): ");
        }
    }
}
