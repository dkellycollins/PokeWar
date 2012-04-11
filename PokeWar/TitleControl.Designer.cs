namespace PokeWar
{
    partial class TitleControl
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
            this.playBtn = new System.Windows.Forms.Button();
            this.creatorsLbl = new System.Windows.Forms.Label();
            this.conceptLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(251, 254);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = true;
            // 
            // creatorsLbl
            // 
            this.creatorsLbl.AutoSize = true;
            this.creatorsLbl.Location = new System.Drawing.Point(183, 176);
            this.creatorsLbl.Name = "creatorsLbl";
            this.creatorsLbl.Size = new System.Drawing.Size(235, 13);
            this.creatorsLbl.TabIndex = 1;
            this.creatorsLbl.Text = "Created by DevinKelly-Collins and Alex Donnelly ";
            // 
            // conceptLbl
            // 
            this.conceptLbl.AutoSize = true;
            this.conceptLbl.Location = new System.Drawing.Point(195, 199);
            this.conceptLbl.Name = "conceptLbl";
            this.conceptLbl.Size = new System.Drawing.Size(201, 13);
            this.conceptLbl.TabIndex = 2;
            this.conceptLbl.Text = "Artwork and Concept by Sean Bodenistel";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(98, 40);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(409, 117);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "PokeWar";
            // 
            // TitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.conceptLbl);
            this.Controls.Add(this.creatorsLbl);
            this.Controls.Add(this.playBtn);
            this.Name = "TitleControl";
            this.Size = new System.Drawing.Size(623, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label creatorsLbl;
        private System.Windows.Forms.Label conceptLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}
