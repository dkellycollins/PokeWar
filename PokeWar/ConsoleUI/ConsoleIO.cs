using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeWar.Engine;

namespace PokeWar.ConsoleUI
{
    public class ConsoleIO : IOInterface
    {
        public void UpdateDisplay(string status)
        {
            Console.Out.WriteLine(status);
        }

        public int SelectAceCard()
        {
            Console.Out.Write("Select your ace card (enter 1 - 4): ");
            return Int32.Parse(Console.In.ReadLine());
        }

        public int SelectCard()
        {
            Console.Out.Write("Select a card (1 - 6): ");
            return Int32.Parse(Console.In.ReadLine());
        }
    }
}
