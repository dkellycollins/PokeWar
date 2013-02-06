using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace PokeWar.Engine.Players
{
    public class UserPlayer : Player
    {
        private IInput _input;

        public UserPlayer(IInput input)
            : base()
        {
            _input = input;
        }

        public override Card PlayCard()
        {
            string str1 = "Hand:  ";
            string str2 = "Index: ";
            int index = 0;
            foreach(Card card in Hand)
            {
                str1 += card.ToString() + " ";
                str2 += string.Format("## ", index++);
            }
            return getFromHand(_input.SelectCard(str1 + "\n" + str2 + 
                "\nEnter your selection: "));
        }

        public override int SelectAceCard()
        {
            return _input.SelectAceCard("Select an ace card (enter 1 - 4): ");
        }
    }
}
