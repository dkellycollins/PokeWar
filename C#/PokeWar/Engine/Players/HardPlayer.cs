using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.Engine.Players
{
    /// <summary>
    /// A computer player that always selects the highest ranked card in their hand.
    /// </summary>
    public class HardPlayer : Player
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
