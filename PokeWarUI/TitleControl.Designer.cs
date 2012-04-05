namespace PokeWarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleControl));
            this.playButton = new System.Windows.Forms.Button();
            this.DesignerLbl = new System.Windows.Forms.Label();
            this.ArtworkLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(202, 240);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // DesignerLbl
            // 
            this.DesignerLbl.AutoSize = true;
            this.DesignerLbl.BackColor = System.Drawing.Color.Transparent;
            this.DesignerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignerLbl.Location = new System.Drawing.Point(90, 177);
            this.DesignerLbl.Name = "DesignerLbl";
            this.DesignerLbl.Size = new System.Drawing.Size(314, 13);
            this.DesignerLbl.TabIndex = 1;
            this.DesignerLbl.Text = "Game Design by Devin Kelly-Collins and Alex Donnally";
            // 
            // ArtworkLbl
            // 
            this.ArtworkLbl.AutoSize = true;
            this.ArtworkLbl.BackColor = System.Drawing.Color.Transparent;
            this.ArtworkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtworkLbl.Location = new System.Drawing.Point(125, 200);
            this.ArtworkLbl.Name = "ArtworkLbl";
            this.ArtworkLbl.Size = new System.Drawing.Size(235, 13);
            this.ArtworkLbl.TabIndex = 2;
            this.ArtworkLbl.Text = "Concept and Artwork by Sean Bodenistil";
            // 
            // TitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ArtworkLbl);
            this.Controls.Add(this.DesignerLbl);
            this.Controls.Add(this.playButton);
            this.Name = "TitleControl";
            this.Size = new System.Drawing.Size(485, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label DesignerLbl;
        private System.Windows.Forms.Label ArtworkLbl;
    }
}
