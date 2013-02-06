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
    }
}
