namespace OscorpGames {
	partial class Main {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			gameThreeButton = new Button();
			titleLabel = new Label();
			gameOneButton = new Button();
			gameTwoButton = new Button();
			gameFourButton = new Button();
			exitButton = new Button();
			creatorLabel1 = new Label();
			creatorLabel2 = new Label();
			teamMemberLabel5 = new Label();
			teamMemberLabel4 = new Label();
			teamMemberLabel3 = new Label();
			teamMemberLabel2 = new Label();
			teamMemberLabel1 = new Label();
			SuspendLayout();
			// 
			// gameThreeButton
			// 
			gameThreeButton.Location = new Point(212, 465);
			gameThreeButton.Name = "gameThreeButton";
			gameThreeButton.Size = new Size(188, 85);
			gameThreeButton.TabIndex = 0;
			gameThreeButton.Text = "Game3";
			gameThreeButton.UseVisualStyleBackColor = true;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
			titleLabel.Location = new Point(254, 49);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new Size(481, 106);
			titleLabel.TabIndex = 1;
			titleLabel.Text = "MINIGAMES";
			// 
			// gameOneButton
			// 
			gameOneButton.Location = new Point(212, 249);
			gameOneButton.Name = "gameOneButton";
			gameOneButton.Size = new Size(188, 85);
			gameOneButton.TabIndex = 2;
			gameOneButton.Text = "Game1";
			gameOneButton.UseVisualStyleBackColor = true;
			// 
			// gameTwoButton
			// 
			gameTwoButton.Location = new Point(603, 249);
			gameTwoButton.Name = "gameTwoButton";
			gameTwoButton.Size = new Size(188, 85);
			gameTwoButton.TabIndex = 3;
			gameTwoButton.Text = "Game2";
			gameTwoButton.UseVisualStyleBackColor = true;
			// 
			// gameFourButton
			// 
			gameFourButton.Location = new Point(603, 465);
			gameFourButton.Name = "gameFourButton";
			gameFourButton.Size = new Size(188, 85);
			gameFourButton.TabIndex = 4;
			gameFourButton.Text = "Game4";
			gameFourButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(883, 761);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(112, 34);
			exitButton.TabIndex = 5;
			exitButton.Text = "Exit";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += exitButton_Click;
			// 
			// creatorLabel1
			// 
			creatorLabel1.AutoSize = true;
			creatorLabel1.Location = new Point(12, 612);
			creatorLabel1.Name = "creatorLabel1";
			creatorLabel1.Size = new Size(113, 25);
			creatorLabel1.TabIndex = 6;
			creatorLabel1.Text = "CREATED BY:";
			// 
			// creatorLabel2
			// 
			creatorLabel2.AutoSize = true;
			creatorLabel2.Location = new Point(12, 762);
			creatorLabel2.Name = "creatorLabel2";
			creatorLabel2.Size = new Size(113, 25);
			creatorLabel2.TabIndex = 7;
			creatorLabel2.Text = "CREATED BY:";
			// 
			// teamMemberLabel5
			// 
			teamMemberLabel5.AutoSize = true;
			teamMemberLabel5.Location = new Point(12, 737);
			teamMemberLabel5.Name = "teamMemberLabel5";
			teamMemberLabel5.Size = new Size(173, 25);
			teamMemberLabel5.TabIndex = 8;
			teamMemberLabel5.Text = "GERARDO BARAJAS";
			// 
			// teamMemberLabel4
			// 
			teamMemberLabel4.AutoSize = true;
			teamMemberLabel4.Location = new Point(12, 712);
			teamMemberLabel4.Name = "teamMemberLabel4";
			teamMemberLabel4.Size = new Size(117, 25);
			teamMemberLabel4.TabIndex = 9;
			teamMemberLabel4.Text = "CURTIS LANE";
			// 
			// teamMemberLabel3
			// 
			teamMemberLabel3.AutoSize = true;
			teamMemberLabel3.Location = new Point(12, 687);
			teamMemberLabel3.Name = "teamMemberLabel3";
			teamMemberLabel3.Size = new Size(149, 25);
			teamMemberLabel3.TabIndex = 10;
			teamMemberLabel3.Text = "WYATT CROCKER";
			// 
			// teamMemberLabel2
			// 
			teamMemberLabel2.AutoSize = true;
			teamMemberLabel2.Location = new Point(12, 662);
			teamMemberLabel2.Name = "teamMemberLabel2";
			teamMemberLabel2.Size = new Size(163, 25);
			teamMemberLabel2.TabIndex = 11;
			teamMemberLabel2.Text = "SURYA NANDEESH";
			// 
			// teamMemberLabel1
			// 
			teamMemberLabel1.AutoSize = true;
			teamMemberLabel1.Location = new Point(12, 637);
			teamMemberLabel1.Name = "teamMemberLabel1";
			teamMemberLabel1.Size = new Size(133, 25);
			teamMemberLabel1.TabIndex = 12;
			teamMemberLabel1.Text = "COLLIN GREISS";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1007, 807);
			Controls.Add(teamMemberLabel1);
			Controls.Add(teamMemberLabel2);
			Controls.Add(teamMemberLabel3);
			Controls.Add(teamMemberLabel4);
			Controls.Add(teamMemberLabel5);
			Controls.Add(creatorLabel2);
			Controls.Add(creatorLabel1);
			Controls.Add(exitButton);
			Controls.Add(gameFourButton);
			Controls.Add(gameTwoButton);
			Controls.Add(gameOneButton);
			Controls.Add(titleLabel);
			Controls.Add(gameThreeButton);
			Name = "Main";
			Text = "Minigames";
			Load += MainMenu_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button gameThreeButton;
		private Label titleLabel;
		private Button gameOneButton;
		private Button gameTwoButton;
		private Button gameFourButton;
		private Button exitButton;
		private Label creatorLabel1;
		private Label creatorLabel2;
		private Label teamMemberLabel5;
		private Label teamMemberLabel4;
		private Label teamMemberLabel3;
		private Label teamMemberLabel2;
		private Label teamMemberLabel1;
	}
}