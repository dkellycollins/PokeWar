using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine;

namespace PokeWarUI
{
    public static class GameData
    {
        public static PokeWar Game { get; private set; }

        public static PokeWar CreateNewGame(Player user, Player computer)
        {
            Game = new PokeWar(user, computer);
            return Game;
        }
    }
}
