using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeWar.Engine;

namespace PokeWar.ConsoleUI
{
    public class ConsoleInput : IInput
    {
        private IOHelper _ioHelper;

        public ConsoleInput(IOHelper ioHelper)
        {
            _ioHelper = ioHelper;
        }

        public int SelectAceCard(string msg)
        {
            return _ioHelper.ReadInt(msg, 0, 3); 
        }

        public int SelectCard(string msg)
        {
            return _ioHelper.ReadInt(msg, 0, 5);
        }
    }
}
