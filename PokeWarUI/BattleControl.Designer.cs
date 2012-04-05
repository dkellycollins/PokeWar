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
            this.Userbtn = new System.Windows.Forms.Button();
            this.ComputerBtn = new System.Windows.Forms.Button();
            this.UserPlayedCardBtn = new System.Windows.Forms.Button();
            this.ComputerPlayedCardBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Userbtn
            // 
            this.Userbtn.Location = new System.Drawing.Point(3, 262);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Size = new System.Drawing.Size(75, 90);
            this.Userbtn.TabIndex = 1;
            this.Userbtn.UseVisualStyleBackColor = true;
            // 
            // ComputerBtn
            // 
            this.ComputerBtn.Location = new System.Drawing.Point(407, 3);
            this.ComputerBtn.Name = "ComputerBtn";
            this.ComputerBtn.Size = new System.Drawing.Size(75, 90);
            this.ComputerBtn.TabIndex = 2;
            this.ComputerBtn.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(84, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PlayerCards";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComputerCards";
            // 
            // BattleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComputerPlayedCardBtn);
            this.Controls.Add(this.UserPlayedCardBtn);
            this.Controls.Add(this.ComputerBtn);
            this.Controls.Add(this.Userbtn);
            this.Name = "BattleControl";
            this.Size = new System.Drawing.Size(485, 355);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Userbtn;
        private System.Windows.Forms.Button ComputerBtn;
        private System.Windows.Forms.Button UserPlayedCardBtn;
        private System.Windows.Forms.Button ComputerPlayedCardBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
