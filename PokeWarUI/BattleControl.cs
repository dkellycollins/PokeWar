using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEngine;

namespace PokeWarUI
{
    public partial class BattleControl : PokeWarControl
    {
        private PokeWar Game;
        private Player User;
        private Player Comp;
        private List<Button> PlayerHand;

        public BattleControl()
        {
            InitializeComponent();
            Game = GameData.Game;
            User = Game.Player1;
            Comp = Game.Player2;
            PlayerPic.Image = User.PlayerCard.FrontImage;
            ComputerPic.Image = User.PlayerCard.FrontImage;
            PlayerHand = new List<Button>() {
                this.PlayerCard1, 
                this.PlayerCard2, 
                this.PlayerCard3, 
                this.PlayerCard4, 
                this.PlayerCard5, 
                this.PlayerCard6 
            };
            Game.Setup();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            int numCards = Math.Min(User.Hand.Count, 6);
            for (int i = 0; i < numCards; i++)
            {
                PlayerHand[i].Image = User.Hand[i].FrontImage;
            }
            PlayerCardNumTB.Text = User.Hand.Count;
            ComputerCardNumTB.Text = Comp.Hand.Count;
            //TODO Add a message to the StatusTB.
        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard2_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard4_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard5_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCard6_Click(object sender, EventArgs e)
        {

        }
    }
}
