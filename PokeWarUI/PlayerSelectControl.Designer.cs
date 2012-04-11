namespace PokeWarUI
{
    partial class PlayerSelectControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSelectControl));
            this.Player1btn = new System.Windows.Forms.Button();
            this.Player2btn = new System.Windows.Forms.Button();
            this.Player3btn = new System.Windows.Forms.Button();
            this.Player4btn = new System.Windows.Forms.Button();
            this.OakPic = new System.Windows.Forms.PictureBox();
            this.DialogText = new System.Windows.Forms.TextBox();
            this.OakTitleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OakPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1btn
            // 
            this.Player1btn.Location = new System.Drawing.Point(53, 215);
            this.Player1btn.Name = "Player1btn";
            this.Player1btn.Size = new System.Drawing.Size(75, 90);
            this.Player1btn.TabIndex = 0;
            this.Player1btn.UseVisualStyleBackColor = true;
            this.Player1btn.Click += new System.EventHandler(this.Player1btn_Click);
            // 
            // Player2btn
            // 
            this.Player2btn.Location = new System.Drawing.Point(134, 215);
            this.Player2btn.Name = "Player2btn";
            this.Player2btn.Size = new System.Drawing.Size(75, 90);
            this.Player2btn.TabIndex = 1;
            this.Player2btn.UseVisualStyleBackColor = true;
            this.Player2btn.Click += new System.EventHandler(this.Player2btn_Click);
            // 
            // Player3btn
            // 
            this.Player3btn.Location = new System.Drawing.Point(215, 215);
            this.Player3btn.Name = "Player3btn";
            this.Player3btn.Size = new System.Drawing.Size(75, 90);
            this.Player3btn.TabIndex = 2;
            this.Player3btn.UseVisualStyleBackColor = true;
            this.Player3btn.Click += new System.EventHandler(this.Player3btn_Click);
            // 
            // Player4btn
            // 
            this.Player4btn.Location = new System.Drawing.Point(296, 215);
            this.Player4btn.Name = "Player4btn";
            this.Player4btn.Size = new System.Drawing.Size(75, 90);
            this.Player4btn.TabIndex = 3;
            this.Player4btn.UseVisualStyleBackColor = true;
            this.Player4btn.Click += new System.EventHandler(this.Player4btn_Click);
            // 
            // OakPic
            // 
            this.OakPic.Image = ((System.Drawing.Image)(resources.GetObject("OakPic.Image")));
            this.OakPic.Location = new System.Drawing.Point(162, 109);
            this.OakPic.Name = "OakPic";
            this.OakPic.Size = new System.Drawing.Size(100, 100);
            this.OakPic.TabIndex = 4;
            this.OakPic.TabStop = false;
            // 
            // DialogText
            // 
            this.DialogText.Location = new System.Drawing.Point(3, 3);
            this.DialogText.Multiline = true;
            this.DialogText.Name = "DialogText";
            this.DialogText.Size = new System.Drawing.Size(455, 87);
            this.DialogText.TabIndex = 5;
            // 
            // OakTitleLbl
            // 
            this.OakTitleLbl.AutoSize = true;
            this.OakTitleLbl.Location = new System.Drawing.Point(188, 93);
            this.OakTitleLbl.Name = "OakTitleLbl";
            this.OakTitleLbl.Size = new System.Drawing.Size(52, 13);
            this.OakTitleLbl.TabIndex = 6;
            this.OakTitleLbl.Text = "Prof. Oak";
            // 
            // PlayerSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OakTitleLbl);
            this.Controls.Add(this.DialogText);
            this.Controls.Add(this.OakPic);
            this.Controls.Add(this.Player4btn);
            this.Controls.Add(this.Player3btn);
            this.Controls.Add(this.Player2btn);
            this.Controls.Add(this.Player1btn);
            this.Name = "PlayerSelectControl";
            this.Size = new System.Drawing.Size(485, 355);
            ((System.ComponentModel.ISupportInitialize)(this.OakPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Player1btn;
        private System.Windows.Forms.Button Player2btn;
        private System.Windows.Forms.Button Player3btn;
        private System.Windows.Forms.Button Player4btn;
        private System.Windows.Forms.PictureBox OakPic;
        private System.Windows.Forms.TextBox DialogText;
        private System.Windows.Forms.Label OakTitleLbl;
    }
}
