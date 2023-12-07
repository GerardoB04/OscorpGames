namespace OscorpGames
{
    partial class Leaderboard
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			scoresLabel = new Label();
			scoreBarsPictureBox = new PictureBox();
			gameNameLabel = new Label();
			scoreLabel1 = new Label();
			scoreLabel2 = new Label();
			scoreLabel3 = new Label();
			closeButton = new Button();
			((System.ComponentModel.ISupportInitialize) scoreBarsPictureBox).BeginInit();
			SuspendLayout();
			// 
			// scoresLabel
			// 
			scoresLabel.AutoSize = true;
			scoresLabel.Font = new Font("Segoe UI", 35F);
			scoresLabel.Location = new Point(390, 9);
			scoresLabel.Name = "scoresLabel";
			scoresLabel.Size = new Size(285, 93);
			scoresLabel.TabIndex = 0;
			scoresLabel.Text = "SCORES";
			// 
			// scoreBarsPictureBox
			// 
			scoreBarsPictureBox.Image = Properties.Resources.ScoreBars;
			scoreBarsPictureBox.Location = new Point(286, 198);
			scoreBarsPictureBox.Name = "scoreBarsPictureBox";
			scoreBarsPictureBox.Size = new Size(508, 467);
			scoreBarsPictureBox.TabIndex = 1;
			scoreBarsPictureBox.TabStop = false;
			// 
			// gameNameLabel
			// 
			gameNameLabel.Anchor = AnchorStyles.None;
			gameNameLabel.AutoSize = true;
			gameNameLabel.Font = new Font("Segoe UI", 35F);
			gameNameLabel.Location = new Point(487, 102);
			gameNameLabel.Name = "gameNameLabel";
			gameNameLabel.Size = new Size(81, 93);
			gameNameLabel.TabIndex = 0;
			gameNameLabel.Text = "#";
			gameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// scoreLabel1
			// 
			scoreLabel1.AutoSize = true;
			scoreLabel1.Location = new Point(514, 668);
			scoreLabel1.Name = "scoreLabel1";
			scoreLabel1.Size = new Size(23, 25);
			scoreLabel1.TabIndex = 0;
			scoreLabel1.Text = "#";
			// 
			// scoreLabel2
			// 
			scoreLabel2.AutoSize = true;
			scoreLabel2.Location = new Point(366, 668);
			scoreLabel2.Name = "scoreLabel2";
			scoreLabel2.Size = new Size(23, 25);
			scoreLabel2.TabIndex = 0;
			scoreLabel2.Text = "#";
			// 
			// scoreLabel3
			// 
			scoreLabel3.AutoSize = true;
			scoreLabel3.Location = new Point(661, 668);
			scoreLabel3.Name = "scoreLabel3";
			scoreLabel3.Size = new Size(23, 25);
			scoreLabel3.TabIndex = 0;
			scoreLabel3.Text = "#";
			// 
			// closeButton
			// 
			closeButton.Location = new Point(934, 687);
			closeButton.Name = "closeButton";
			closeButton.Size = new Size(112, 34);
			closeButton.TabIndex = 1;
			closeButton.Text = "Close";
			closeButton.UseVisualStyleBackColor = true;
			closeButton.Click += closeButton_Click;
			// 
			// Leaderboard
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1058, 733);
			Controls.Add(closeButton);
			Controls.Add(scoreLabel3);
			Controls.Add(scoreLabel2);
			Controls.Add(scoreLabel1);
			Controls.Add(gameNameLabel);
			Controls.Add(scoreBarsPictureBox);
			Controls.Add(scoresLabel);
			Name = "Leaderboard";
			Text = "Leaderboard";
			((System.ComponentModel.ISupportInitialize) scoreBarsPictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label scoresLabel;
		private PictureBox scoreBarsPictureBox;
		private Label gameNameLabel;
		private Label scoreLabel1;
		private Label scoreLabel2;
		private Label scoreLabel3;
		private Button closeButton;
	}
}