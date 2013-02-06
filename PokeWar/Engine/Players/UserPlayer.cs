using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace PokeWar.Engine.Players
{
    public class UserPlayer : Player
    {
        private IOInterface io;

        public UserPlayer(string name, Card card, IOInterface io)
            : base(name, card)
        {
            this.io = io;
        }

        public override Card PlayCard()
        {
            displayHand();
            io.UpdateDisplay("Enter index of card to play: ");
            return getFromHand(io.SelectCard());
        }

        private void displayHand()
        {
            
        }
    }
}
