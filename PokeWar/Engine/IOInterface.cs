using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.Engine
{
    interface IOInterface
    {
        PokeWarEngine Game { set; }
        void UpdateDisplay(string status);
        int SelectCard();
    }
}
