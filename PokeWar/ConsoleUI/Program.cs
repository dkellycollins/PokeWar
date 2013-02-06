using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeWar.Engine;
using PokeWar.Engine.Players;

namespace PokeWar.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugPlayer player1 = new DebugPlayer(new ConsoleInput());
            ComputerPlayer player2 = new ComputerPlayer();
            
            PokeWarEngine game = new PokeWarEngine(player1, player2, new ConsoleOutput());

            while (true)
            {
                game.Play();
            }
        }
    }
}
