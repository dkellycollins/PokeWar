using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEngine;
using CardLib;

namespace PokeWarUI
{
    public partial class BattleControl : PokeWarControl
    {
        private PokeWar Game;
        private Player User;
        private Player Comp;
        private Card UserSelectedCard;
        private Card CompSelectedCard;
        private List<Button> PlayerHandDisplay;
        private String statusMessage;

        public BattleControl()
        {
            InitializeComponent();
            Game = GameData.Game;
            User = Game.Player1;
            Comp = Game.Player2;
            PlayerPic.Image = User.PlayerCard.FrontImage;
            ComputerPic.Image = User.PlayerCard.FrontImage;
            PlayerHandDisplay = new List<Button>() {
                this.PlayerCard1, 
                this.PlayerCard2, 
                this.PlayerCard3, 
                this.PlayerCard4, 
                this.PlayerCard5, 
                this.PlayerCard6 
            };
            Game.Setup();
            statusMessage = Comp.Name + " wants to fight!";
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            int numCards = Math.Min(User.Hand.Count, PlayerHandDisplay.Count);
            for (int i = 0; i < numCards; i++)
            {
                PlayerHandDisplay[i].Image = User.Hand[i].FrontImage;
            }
            PlayerCardNumTB.Text = User.Hand.Count.ToString();
            ComputerCardNumTB.Text = Comp.Hand.Count.ToString();
            StatusTB.Text = statusMessage;
            statusMessage = "";
        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {
           playUserCard(0);
        }

        private void PlayerCard2_Click(object sender, EventArgs e)
        {
            playUserCard(1);
        }

        private void PlayerCard3_Click(object sender, EventArgs e)
        {
            playUserCard(2);
        }

        private void PlayerCard4_Click(object sender, EventArgs e)
        {
            playUserCard(3);
        }

        private void PlayerCard5_Click(object sender, EventArgs e)
        {
            playUserCard(4);
        }

        private void PlayerCard6_Click(object sender, EventArgs e)
        {
            playUserCard(5);
        }

        private void playUserCard(int choice)
        {
            UserSelectedCard = User.Hand[choice];
            PlayerHandDisplay[choice].Image = null;
            UserPlayedCardBtn.Image = UserSelectedCard.FrontImage;
            statusMessage += User.Name + " played " + UserSelectedCard.ToString();
            playComputerCard();
        }

        private void playComputerCard()
        {
            Card pickedCard = Comp.Hand[0];
            for (int i = 1; i < Comp.Hand.Count; i++)
            {
                if (Comp.Hand[i].Rank > pickedCard.Rank)
                {
                    pickedCard = Comp.Hand[i];
                }
            }
            Game.PlayRound(UserSelectedCard, CompSelectedCard);
            UpdateDisplay();
        }
    }
}
