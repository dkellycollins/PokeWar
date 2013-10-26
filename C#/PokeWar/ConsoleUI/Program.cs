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
#if DEBUG
            IOHelper ioHelper = new IOHelper("Log.txt");
#else
            IOHelper ioHelper = new IOHelper("Log.txt");
#endif

            DebugPlayer player1 = new DebugPlayer(new ConsoleInput(ioHelper));
            ComputerPlayer player2 = new ComputerPlayer();
            
            PokeWarEngine game = new PokeWarEngine(player1, player2, new ConsoleOutput(ioHelper));

            do
            {
                game.Play();
            } while (ioHelper.ReadChar("Play again? (y/n) ", new char[] { 'y', 'n' }) == 'y');

            ioHelper.Dispose();
        }
    }
}
