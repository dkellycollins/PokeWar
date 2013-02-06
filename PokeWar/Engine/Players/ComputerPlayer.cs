using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace PokeWar.Engine.Players
{
    public class ComputerPlayer : Player
    {
        public override Card PlayCard()
        {
            return getFromHand(0);
        }

        public override int SelectAceCard()
        {
            return SelectAceCard(Suit.Club);
        }

        public int SelectAceCard(Suit suit)
        {
            switch (suit)
            {
                case Suit.Club:
                    return 1;
                case Suit.Diamond:
                    return 0;
                case Suit.Heart:
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
