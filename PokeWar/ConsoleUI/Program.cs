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
            ConsoleIO consoleIO = new ConsoleIO();

            UserPlayer player1 = new UserPlayer(consoleIO);
            ComputerPlayer player2 = new ComputerPlayer();
            
            PokeWarEngine game = new PokeWarEngine(player1, player2, consoleIO);

            while (true)
            {
                game.Play();
            }
        }
    }
}
