using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.Engine.Players
{
    /// <summary>
    /// Computer player that always selects the lowest ranked card in their hand.
    /// </summary>
    public class EasyPlayer : Player
    {
        public override CardLib.Card PlayCard()
        {
            throw new NotImplementedException();
        }

        public override int SelectAceCard()
        {
            throw new NotImplementedException();
        }
    }
}
