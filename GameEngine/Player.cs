using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardLib;

namespace GameEngine
{
    public class Player
    {
        private string p;
        private Card card;

        public Player(string p, Card card)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.card = card;
        }
    }
}
