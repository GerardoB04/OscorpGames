namespace OscorpGames {
	partial class Minesweeper {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			bombField = new GroupBox();
			restartButton = new Button();
			widthAdjuster = new NumericUpDown();
			heightAdjuster = new NumericUpDown();
			widthLabel = new Label();
			heightLabel = new Label();
			bombAdjuster = new NumericUpDown();
			bombLabel = new Label();
			winLoseLabel = new Label();
			bombsLeftLabel = new Label();
			bombsLabel = new Label();
			timer = new System.Windows.Forms.Timer(components);
			timeLabel = new Label();
			timeLeftLabel = new Label();
			scoreLabel = new Label();
			scoreLeftLabel = new Label();
			((System.ComponentModel.ISupportInitialize) widthAdjuster).BeginInit();
			((System.ComponentModel.ISupportInitialize) heightAdjuster).BeginInit();
			((System.ComponentModel.ISupportInitialize) bombAdjuster).BeginInit();
			SuspendLayout();
			// 
			// bombField
			// 
			bombField.Location = new Point(75, 173);
			bombField.Name = "bombField";
			bombField.Size = new Size(640, 320);
			bombField.TabIndex = 0;
			bombField.TabStop = false;
			// 
			// restartButton
			// 
			restartButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
			restartButton.Location = new Point(676, 12);
			restartButton.Name = "restartButton";
			restartButton.Size = new Size(112, 34);
			restartButton.TabIndex = 1;
			restartButton.Text = "Restart Game";
			restartButton.UseVisualStyleBackColor = true;
			restartButton.Click += restartButton_Click;
			// 
			// widthAdjuster
			// 
			widthAdjuster.Location = new Point(676, 52);
			widthAdjuster.Name = "widthAdjuster";
			widthAdjuster.Size = new Size(112, 31);
			widthAdjuster.TabIndex = 2;
			widthAdjuster.ValueChanged += widthAdjuster_Updated;
			// 
			// heightAdjuster
			// 
			heightAdjuster.Location = new Point(676, 89);
			heightAdjuster.Name = "heightAdjuster";
			heightAdjuster.Size = new Size(112, 31);
			heightAdjuster.TabIndex = 3;
			heightAdjuster.ValueChanged += heightAdjuster_Updated;
			// 
			// widthLabel
			// 
			widthLabel.AutoSize = true;
			widthLabel.Location = new Point(610, 54);
			widthLabel.Name = "widthLabel";
			widthLabel.Size = new Size(60, 25);
			widthLabel.TabIndex = 0;
			widthLabel.Text = "Width";
			// 
			// heightLabel
			// 
			heightLabel.AutoSize = true;
			heightLabel.Location = new Point(605, 91);
			heightLabel.Name = "heightLabel";
			heightLabel.Size = new Size(65, 25);
			heightLabel.TabIndex = 0;
			heightLabel.Text = "Height";
			// 
			// bombAdjuster
			// 
			bombAdjuster.Location = new Point(676, 126);
			bombAdjuster.Name = "bombAdjuster";
			bombAdjuster.Size = new Size(112, 31);
			bombAdjuster.TabIndex = 4;
			bombAdjuster.ValueChanged += bombAdjuster_Updated;
			// 
			// bombLabel
			// 
			bombLabel.AutoSize = true;
			bombLabel.Location = new Point(602, 128);
			bombLabel.Name = "bombLabel";
			bombLabel.Size = new Size(68, 25);
			bombLabel.TabIndex = 0;
			bombLabel.Text = "Bombs";
			// 
			// winLoseLabel
			// 
			winLoseLabel.AutoSize = true;
			winLoseLabel.Location = new Point(75, 91);
			winLoseLabel.MaximumSize = new Size(400, 0);
			winLoseLabel.Name = "winLoseLabel";
			winLoseLabel.Size = new Size(23, 25);
			winLoseLabel.TabIndex = 0;
			winLoseLabel.Text = "#";
			// 
			// bombsLeftLabel
			// 
			bombsLeftLabel.AutoSize = true;
			bombsLeftLabel.Location = new Point(159, 16);
			bombsLeftLabel.Name = "bombsLeftLabel";
			bombsLeftLabel.Size = new Size(23, 25);
			bombsLeftLabel.TabIndex = 0;
			bombsLeftLabel.Text = "#";
			// 
			// bombsLabel
			// 
			bombsLabel.AutoSize = true;
			bombsLabel.Location = new Point(75, 16);
			bombsLabel.Name = "bombsLabel";
			bombsLabel.Size = new Size(87, 25);
			bombsLabel.TabIndex = 0;
			bombsLabel.Text = "Flags left:";
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 1000;
			timer.Tick += timer_Tick;
			// 
			// timeLabel
			// 
			timeLabel.AutoSize = true;
			timeLabel.Location = new Point(281, 16);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(54, 25);
			timeLabel.TabIndex = 0;
			timeLabel.Text = "Time:";
			// 
			// timeLeftLabel
			// 
			timeLeftLabel.AutoSize = true;
			timeLeftLabel.Location = new Point(341, 16);
			timeLeftLabel.Name = "timeLeftLabel";
			timeLeftLabel.Size = new Size(23, 25);
			timeLeftLabel.TabIndex = 0;
			timeLeftLabel.Text = "#";
			// 
			// scoreLabel
			// 
			scoreLabel.AutoSize = true;
			scoreLabel.Location = new Point(443, 16);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(60, 25);
			scoreLabel.TabIndex = 0;
			scoreLabel.Text = "Score:";
			// 
			// scoreLeftLabel
			// 
			scoreLeftLabel.AutoSize = true;
			scoreLeftLabel.Location = new Point(509, 16);
			scoreLeftLabel.Name = "scoreLeftLabel";
			scoreLeftLabel.Size = new Size(23, 25);
			scoreLeftLabel.TabIndex = 0;
			scoreLeftLabel.Text = "#";
			// 
			// Minesweeper
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 512);
			Controls.Add(scoreLeftLabel);
			Controls.Add(scoreLabel);
			Controls.Add(timeLeftLabel);
			Controls.Add(timeLabel);
			Controls.Add(bombsLabel);
			Controls.Add(bombsLeftLabel);
			Controls.Add(winLoseLabel);
			Controls.Add(bombLabel);
			Controls.Add(bombAdjuster);
			Controls.Add(heightLabel);
			Controls.Add(widthLabel);
			Controls.Add(heightAdjuster);
			Controls.Add(widthAdjuster);
			Controls.Add(restartButton);
			Controls.Add(bombField);
			Name = "Minesweeper";
			Text = "Minesweeper";
			FormClosed += minesweeper_Closed;
			((System.ComponentModel.ISupportInitialize) widthAdjuster).EndInit();
			((System.ComponentModel.ISupportInitialize) heightAdjuster).EndInit();
			((System.ComponentModel.ISupportInitialize) bombAdjuster).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox bombField;
		private Button restartButton;
		private NumericUpDown widthAdjuster;
		private NumericUpDown heightAdjuster;
		private Label widthLabel;
		private Label heightLabel;
		private NumericUpDown bombAdjuster;
		private Label bombLabel;
		private Label winLoseLabel;
		private Label bombsLeftLabel;
		private Label bombsLabel;
		private System.Windows.Forms.Timer timer;
		private Label timeLabel;
		private Label timeLeftLabel;
		private Label scoreLabel;
		private Label scoreLeftLabel;
	}
}