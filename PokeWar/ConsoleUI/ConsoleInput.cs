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
        public int SelectAceCard(string msg)
        {
            Console.Out.Write(msg);
            return Int32.Parse(Console.In.ReadLine());
        }

        public int SelectCard(string msg)
        {
            Console.Out.Write(msg);
            return Int32.Parse(Console.In.ReadLine());
        }
    }
}
