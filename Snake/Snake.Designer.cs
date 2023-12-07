namespace SnakeGame
{
    partial class Snake
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            startButton = new Button();
            pauseButton = new Button();
            picCanvas = new Panel();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreLabel = new Label();
            highScoreLabel = new Label();
            snapButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.DeepSkyBlue;
            startButton.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(588, 147);
            startButton.Name = "startButton";
            startButton.Size = new Size(153, 64);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartGame;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.PaleGreen;
            pauseButton.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pauseButton.Location = new Point(588, 217);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(153, 64);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += Pause;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.ActiveBorder;
            picCanvas.Location = new Point(12, 147);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(570, 570);
            picCanvas.TabIndex = 2;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 40;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(620, 377);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(89, 19);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Score: 0";
            // 
            // highScoreLabel
            // 
            highScoreLabel.AutoSize = true;
            highScoreLabel.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            highScoreLabel.Location = new Point(623, 19);
            highScoreLabel.MaximumSize = new Size(109, 90);
            highScoreLabel.MinimumSize = new Size(109, 19);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(109, 38);
            highScoreLabel.TabIndex = 3;
            highScoreLabel.Text = "High Score:\r\n";
            // 
            // snapButton
            // 
            snapButton.BackColor = Color.IndianRed;
            snapButton.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            snapButton.Location = new Point(588, 287);
            snapButton.Name = "snapButton";
            snapButton.Size = new Size(153, 64);
            snapButton.TabIndex = 4;
            snapButton.Text = "Snap";
            snapButton.UseVisualStyleBackColor = false;
            snapButton.Click += snapButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SpringGreen;
            label1.Font = new Font("Unispace", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(580, 115);
            label1.TabIndex = 5;
            label1.Text = "S N A K E";
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(752, 729);
            Controls.Add(highScoreLabel);
            Controls.Add(snapButton);
            Controls.Add(scoreLabel);
            Controls.Add(picCanvas);
            Controls.Add(pauseButton);
            Controls.Add(startButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1022, 1017);
            MinimumSize = new Size(198, 193);
            Name = "Snake";
            Text = "Snake";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button pauseButton;
        private Panel picCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreLabel;
        private Label highScoreLabel;
        private Button snapButton;
        private Label label1;
    }
}