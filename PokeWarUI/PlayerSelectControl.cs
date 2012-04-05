using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardLib;

namespace PokeWarUI
{
    public partial class PlayerSelectControl : PokeWarControl
    {
        private string[] trainerNames = new string[] {
            "Gary Oak",
            "Dawn",
            "Misty",
            "Ash"
        };
        private string oakSpeech = "Hello there! Welcome to the world of pokémon! My name is Oak! People call me the pokémon Prof! This world is inhabited by creatures called pokémon! For some people, pokémon are pets. Others use them for fights. Myself...I study pokémon as a profession. Erm... Who are you again?";

        public PlayerSelectControl()
        {
            InitializeComponent();
        }

        private void Player1btn_Click(object sender, EventArgs e)
        {
            GameData.CreateNewGame(
                new GameEngine.Player(trainerNames[0], new Card(Suit.Ace, 13)),
                new GameEngine.Player(trainerNames[1], new Card(Suit.Club, 13))
                );
        }

        private void Player2btn_Click(object sender, EventArgs e)
        {

        }

        private void Player3btn_Click(object sender, EventArgs e)
        {

        }

        private void Player4btn_Click(object sender, EventArgs e)
        {

        }
    }
}
