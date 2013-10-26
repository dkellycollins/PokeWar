using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeWar.Engine;

namespace PokeWar.ConsoleUI
{
    public class ConsoleOutput : IOutput
    {
        private IOHelper _ioHelper;

        public ConsoleOutput(IOHelper ioHelper)
        {
            _ioHelper = ioHelper;
        }

        public void UpdateDisplay(string status)
        {
            _ioHelper.WriteString(status);
        }
    }
}
