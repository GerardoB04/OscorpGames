namespace OscorpGames {
	partial class Menu {
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
        private void InitializeComponent()
        {
            gameThreeButton = new Button();
            titleLabel = new Label();
            gameOneButton = new Button();
            gameTwoButton = new Button();
            gameFourButton = new Button();
            exitButton = new Button();
            creatorLabel1 = new Label();
            teamMemberLabel5 = new Label();
            teamMemberLabel4 = new Label();
            teamMemberLabel3 = new Label();
            teamMemberLabel2 = new Label();
            teamMemberLabel1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            highScoresToolStripMenuItem = new ToolStripMenuItem();
            minesweeperToolStripMenuItem = new ToolStripMenuItem();
            snakeToolStripMenuItem = new ToolStripMenuItem();
            pacManToolStripMenuItem = new ToolStripMenuItem();
            tetrisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gameThreeButton
            // 
            gameThreeButton.Location = new Point(212, 465);
            gameThreeButton.Name = "gameThreeButton";
            gameThreeButton.Size = new Size(188, 85);
            gameThreeButton.TabIndex = 0;
            gameThreeButton.Text = "Pac-Man";
            gameThreeButton.UseVisualStyleBackColor = true;
            gameThreeButton.Click += gameThreeButton_Click;
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
            gameOneButton.Text = "Minesweeper";
            gameOneButton.UseVisualStyleBackColor = true;
            gameOneButton.Click += gameOneButton_Click;
            // 
            // gameTwoButton
            // 
            gameTwoButton.Location = new Point(603, 249);
            gameTwoButton.Name = "gameTwoButton";
            gameTwoButton.Size = new Size(188, 85);
            gameTwoButton.TabIndex = 3;
            gameTwoButton.Text = "Snake";
            gameTwoButton.UseVisualStyleBackColor = true;
            gameTwoButton.Click += gameTwoButton_Click;
            // 
            // gameFourButton
            // 
            gameFourButton.Location = new Point(603, 465);
            gameFourButton.Name = "gameFourButton";
            gameFourButton.Size = new Size(188, 85);
            gameFourButton.TabIndex = 4;
            gameFourButton.Text = "Tetris";
            gameFourButton.UseVisualStyleBackColor = true;
            gameFourButton.Click += gameFourButton_Click;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1007, 33);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(270, 34);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { highScoresToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // highScoresToolStripMenuItem
            // 
            highScoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { minesweeperToolStripMenuItem, snakeToolStripMenuItem, pacManToolStripMenuItem, tetrisToolStripMenuItem });
            highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            highScoresToolStripMenuItem.Size = new Size(270, 34);
            highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // minesweeperToolStripMenuItem
            // 
            minesweeperToolStripMenuItem.Name = "minesweeperToolStripMenuItem";
            minesweeperToolStripMenuItem.Size = new Size(270, 34);
            minesweeperToolStripMenuItem.Text = "Minesweeper";
            // 
            // snakeToolStripMenuItem
            // 
            snakeToolStripMenuItem.Name = "snakeToolStripMenuItem";
            snakeToolStripMenuItem.Size = new Size(270, 34);
            snakeToolStripMenuItem.Text = "Snake";
            // 
            // pacManToolStripMenuItem
            // 
            pacManToolStripMenuItem.Name = "pacManToolStripMenuItem";
            pacManToolStripMenuItem.Size = new Size(270, 34);
            pacManToolStripMenuItem.Text = "Pac-Man";
            // 
            // tetrisToolStripMenuItem
            // 
            tetrisToolStripMenuItem.Name = "tetrisToolStripMenuItem";
            tetrisToolStripMenuItem.Size = new Size(270, 34);
            tetrisToolStripMenuItem.Text = "Tetris";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 807);
            Controls.Add(teamMemberLabel1);
            Controls.Add(teamMemberLabel2);
            Controls.Add(teamMemberLabel3);
            Controls.Add(teamMemberLabel4);
            Controls.Add(teamMemberLabel5);
            Controls.Add(creatorLabel1);
            Controls.Add(exitButton);
            Controls.Add(gameFourButton);
            Controls.Add(gameTwoButton);
            Controls.Add(gameOneButton);
            Controls.Add(titleLabel);
            Controls.Add(gameThreeButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Minigames";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
		private Label teamMemberLabel5;
		private Label teamMemberLabel4;
		private Label teamMemberLabel3;
		private Label teamMemberLabel2;
		private Label teamMemberLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem highScoresToolStripMenuItem;
        private ToolStripMenuItem minesweeperToolStripMenuItem;
        private ToolStripMenuItem snakeToolStripMenuItem;
        private ToolStripMenuItem pacManToolStripMenuItem;
        private ToolStripMenuItem tetrisToolStripMenuItem;
    }
}