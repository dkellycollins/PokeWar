namespace PokeWarUI
{
    partial class BattleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerCard1 = new System.Windows.Forms.Button();
            this.UserPlayedCardBtn = new System.Windows.Forms.Button();
            this.ComputerPlayedCardBtn = new System.Windows.Forms.Button();
            this.PlayerCards = new System.Windows.Forms.GroupBox();
            this.PlayerCard2 = new System.Windows.Forms.Button();
            this.PlayerCard5 = new System.Windows.Forms.Button();
            this.PlayerCard4 = new System.Windows.Forms.Button();
            this.PlayerCard6 = new System.Windows.Forms.Button();
            this.PlayerCard3 = new System.Windows.Forms.Button();
            this.PlayerPic = new System.Windows.Forms.PictureBox();
            this.ComputerPic = new System.Windows.Forms.PictureBox();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.ComputerCardNumLbl = new System.Windows.Forms.Label();
            this.PlayerCardNumLbl = new System.Windows.Forms.Label();
            this.ComputerCardNumTB = new System.Windows.Forms.TextBox();
            this.PlayerCardNumTB = new System.Windows.Forms.TextBox();
            this.PlayerCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.Location = new System.Drawing.Point(6, 13);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard1.TabIndex = 1;
            this.PlayerCard1.UseVisualStyleBackColor = true;
            this.PlayerCard1.Click += new System.EventHandler(this.PlayerCard1_Click);
            // 
            // UserPlayedCardBtn
            // 
            this.UserPlayedCardBtn.Location = new System.Drawing.Point(161, 132);
            this.UserPlayedCardBtn.Name = "UserPlayedCardBtn";
            this.UserPlayedCardBtn.Size = new System.Drawing.Size(75, 90);
            this.UserPlayedCardBtn.TabIndex = 3;
            this.UserPlayedCardBtn.UseVisualStyleBackColor = true;
            // 
            // ComputerPlayedCardBtn
            // 
            this.ComputerPlayedCardBtn.Location = new System.Drawing.Point(242, 132);
            this.ComputerPlayedCardBtn.Name = "ComputerPlayedCardBtn";
            this.ComputerPlayedCardBtn.Size = new System.Drawing.Size(75, 90);
            this.ComputerPlayedCardBtn.TabIndex = 4;
            this.ComputerPlayedCardBtn.UseVisualStyleBackColor = true;
            // 
            // PlayerCards
            // 
            this.PlayerCards.Controls.Add(this.PlayerCard2);
            this.PlayerCards.Controls.Add(this.PlayerCard5);
            this.PlayerCards.Controls.Add(this.PlayerCard4);
            this.PlayerCards.Controls.Add(this.PlayerCard6);
            this.PlayerCards.Controls.Add(this.PlayerCard3);
            this.PlayerCards.Controls.Add(this.PlayerCard1);
            this.PlayerCards.Location = new System.Drawing.Point(3, 243);
            this.PlayerCards.Name = "PlayerCards";
            this.PlayerCards.Size = new System.Drawing.Size(479, 109);
            this.PlayerCards.TabIndex = 5;
            this.PlayerCards.TabStop = false;
            this.PlayerCards.Text = "Pokemon";
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Location = new System.Drawing.Point(84, 13);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard2.TabIndex = 6;
            this.PlayerCard2.UseVisualStyleBackColor = true;
            this.PlayerCard2.Click += new System.EventHandler(this.PlayerCard2_Click);
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.Location = new System.Drawing.Point(319, 13);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard5.TabIndex = 5;
            this.PlayerCard5.UseVisualStyleBackColor = true;
            this.PlayerCard5.Click += new System.EventHandler(this.PlayerCard5_Click);
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.Location = new System.Drawing.Point(241, 13);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard4.TabIndex = 4;
            this.PlayerCard4.UseVisualStyleBackColor = true;
            this.PlayerCard4.Click += new System.EventHandler(this.PlayerCard4_Click);
            // 
            // PlayerCard6
            // 
            this.PlayerCard6.Location = new System.Drawing.Point(398, 13);
            this.PlayerCard6.Name = "PlayerCard6";
            this.PlayerCard6.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard6.TabIndex = 3;
            this.PlayerCard6.UseVisualStyleBackColor = true;
            this.PlayerCard6.Click += new System.EventHandler(this.PlayerCard6_Click);
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.Location = new System.Drawing.Point(163, 13);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(75, 90);
            this.PlayerCard3.TabIndex = 2;
            this.PlayerCard3.UseVisualStyleBackColor = true;
            this.PlayerCard3.Click += new System.EventHandler(this.PlayerCard3_Click);
            // 
            // PlayerPic
            // 
            this.PlayerPic.Location = new System.Drawing.Point(3, 109);
            this.PlayerPic.Name = "PlayerPic";
            this.PlayerPic.Size = new System.Drawing.Size(100, 128);
            this.PlayerPic.TabIndex = 7;
            this.PlayerPic.TabStop = false;
            // 
            // ComputerPic
            // 
            this.ComputerPic.Location = new System.Drawing.Point(376, 109);
            this.ComputerPic.Name = "ComputerPic";
            this.ComputerPic.Size = new System.Drawing.Size(100, 128);
            this.ComputerPic.TabIndex = 8;
            this.ComputerPic.TabStop = false;
            // 
            // StatusTB
            // 
            this.StatusTB.Enabled = false;
            this.StatusTB.Location = new System.Drawing.Point(3, 3);
            this.StatusTB.Multiline = true;
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.Size = new System.Drawing.Size(479, 100);
            this.StatusTB.TabIndex = 9;
            // 
            // ComputerCardNumLbl
            // 
            this.ComputerCardNumLbl.AutoSize = true;
            this.ComputerCardNumLbl.Location = new System.Drawing.Point(326, 187);
            this.ComputerCardNumLbl.Name = "ComputerCardNumLbl";
            this.ComputerCardNumLbl.Size = new System.Drawing.Size(44, 13);
            this.ComputerCardNumLbl.TabIndex = 10;
            this.ComputerCardNumLbl.Text = "# Cards";
            // 
            // PlayerCardNumLbl
            // 
            this.PlayerCardNumLbl.AutoSize = true;
            this.PlayerCardNumLbl.Location = new System.Drawing.Point(109, 187);
            this.PlayerCardNumLbl.Name = "PlayerCardNumLbl";
            this.PlayerCardNumLbl.Size = new System.Drawing.Size(44, 13);
            this.PlayerCardNumLbl.TabIndex = 11;
            this.PlayerCardNumLbl.Text = "# Cards";
            // 
            // ComputerCardNumTB
            // 
            this.ComputerCardNumTB.Enabled = false;
            this.ComputerCardNumTB.Location = new System.Drawing.Point(323, 203);
            this.ComputerCardNumTB.Name = "ComputerCardNumTB";
            this.ComputerCardNumTB.Size = new System.Drawing.Size(47, 20);
            this.ComputerCardNumTB.TabIndex = 12;
            this.ComputerCardNumTB.Text = "0";
            // 
            // PlayerCardNumTB
            // 
            this.PlayerCardNumTB.Enabled = false;
            this.PlayerCardNumTB.Location = new System.Drawing.Point(108, 202);
            this.PlayerCardNumTB.Name = "PlayerCardNumTB";
            this.PlayerCardNumTB.Size = new System.Drawing.Size(47, 20);
            this.PlayerCardNumTB.TabIndex = 13;
            this.PlayerCardNumTB.Text = "0";
            // 
            // BattleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerCardNumTB);
            this.Controls.Add(this.ComputerCardNumTB);
            this.Controls.Add(this.PlayerCardNumLbl);
            this.Controls.Add(this.ComputerCardNumLbl);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.ComputerPic);
            this.Controls.Add(this.PlayerPic);
            this.Controls.Add(this.PlayerCards);
            this.Controls.Add(this.ComputerPlayedCardBtn);
            this.Controls.Add(this.UserPlayedCardBtn);
            this.Name = "BattleControl";
            this.Size = new System.Drawing.Size(485, 355);
            this.PlayerCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerCard1;
        private System.Windows.Forms.Button UserPlayedCardBtn;
        private System.Windows.Forms.Button ComputerPlayedCardBtn;
        private System.Windows.Forms.GroupBox PlayerCards;
        private System.Windows.Forms.Button PlayerCard2;
        private System.Windows.Forms.Button PlayerCard5;
        private System.Windows.Forms.Button PlayerCard4;
        private System.Windows.Forms.Button PlayerCard6;
        private System.Windows.Forms.Button PlayerCard3;
        private System.Windows.Forms.PictureBox PlayerPic;
        private System.Windows.Forms.PictureBox ComputerPic;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Label ComputerCardNumLbl;
        private System.Windows.Forms.Label PlayerCardNumLbl;
        private System.Windows.Forms.TextBox ComputerCardNumTB;
        private System.Windows.Forms.TextBox PlayerCardNumTB;
    }
}
