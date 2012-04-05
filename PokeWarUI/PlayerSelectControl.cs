using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardLib;
using GameEngine;
using System.Threading;

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
        private Thread DialogThread = null;
        
        public PlayerSelectControl()
        {
            InitializeComponent();
            this.DialogText.Text = oakSpeech;
        }

        private void PlayerSelectControl_OnShow(object sender, EventArgs e)
        {
            DialogThread = new Thread(DisplayOakSpeech);
            DialogThread.Start();
        }

        private void DisplayOakSpeech()
        {
            for (int i = 0; i < oakSpeech.Length; i++)
            {
                this.DialogText.Text += oakSpeech[i];
                Thread.Sleep(2000);
            }
        }

        private void Player1btn_Click(object sender, EventArgs e)
        {
            //if (DialogThread.IsAlive)
            //    DialogThread.Abort();

            GameData.CreateNewGame(
                new Player(trainerNames[0], new Card(Suit.Club, 13)),
                new Player(trainerNames[1], new Card(Suit.Diamond, 13))
            );
            OnControlComplete();
        }

        private void Player2btn_Click(object sender, EventArgs e)
        {
            //if (DialogThread.IsAlive)
            //    DialogThread.Abort();

            GameData.CreateNewGame(
                new Player(trainerNames[1], new Card(Suit.Diamond, 13)),
                new Player(trainerNames[2], new Card(Suit.Heart, 13))
            );
            OnControlComplete();
        }

        private void Player3btn_Click(object sender, EventArgs e)
        {
            //if (DialogThread.IsAlive)
            //    DialogThread.Abort();

            GameData.CreateNewGame(
                new Player(trainerNames[2], new Card(Suit.Heart, 13)),
                new Player(trainerNames[3], new Card(Suit.Spade, 13))
            );
            OnControlComplete();
        }

        private void Player4btn_Click(object sender, EventArgs e)
        {
            //if (DialogThread.IsAlive)
            //    DialogThread.Abort();

            GameData.CreateNewGame(
                new Player(trainerNames[3], new Card(Suit.Heart, 13)),
                new Player(trainerNames[0], new Card(Suit.Spade, 13))
            );
            OnControlComplete();
        }
    }
}
