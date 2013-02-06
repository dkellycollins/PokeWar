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
        public void UpdateDisplay(string status)
        {
            Console.Out.WriteLine(status);
        }
    }
}
