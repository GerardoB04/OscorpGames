using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; // add this for the JPG compressor
using static System.Windows.Forms.LinkLabel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SnakeGame
{
    public partial class Snake : Form
    {
        private List<Circle> Snakesnake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;
        //bool isGamePaused = false;
        public Snake()
        {
            InitializeComponent();
            new Settings();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void snapButton_Click(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my Highscore is " + highScore;
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.Blue;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 32;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "SnakeGameScreenShot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // setting the directions
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions
            for (int i = Snakesnake.Count - 1; i >= 0; i--)
            {
                
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snakesnake[i].X--;
                            break;
                        case "right":
                            Snakesnake[i].X++;
                            break;
                        case "down":
                            Snakesnake[i].Y++;
                            break;
                        case "up":
                            Snakesnake[i].Y--;
                            break;
                    }
                    if (Snakesnake[i].X < 0)
                    {
                        Snakesnake[i].X = maxWidth;
                    }
                    if (Snakesnake[i].X > maxWidth)
                    {
                        Snakesnake[i].X = 0;
                    }
                    if (Snakesnake[i].Y < 0)
                    {
                        Snakesnake[i].Y = maxHeight;
                    }
                    if (Snakesnake[i].Y > maxHeight)
                    {
                        Snakesnake[i].Y = 0;
                    }
                    if (Snakesnake[i].X == food.X && Snakesnake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < Snakesnake.Count; j++)
                    {
                        if (Snakesnake[i].X == Snakesnake[j].X && Snakesnake[i].Y == Snakesnake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snakesnake[i].X = Snakesnake[i - 1].X;
                    Snakesnake[i].Y = Snakesnake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();
        }
        


        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColor;
            for (int i = 0; i < Snakesnake.Count; i++)
            {
                if (i == 0)
                { snakeColor = Brushes.Black; }
                else
                { snakeColor = Brushes.DarkGreen; }

                canvas.FillEllipse(snakeColor, new Rectangle
                    (Snakesnake[i].X * Settings.Width, Snakesnake[i].Y * Settings.Height, Settings.Width, Settings.Height));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
        }
        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snakesnake.Clear();

            startButton.Enabled = false;
            pauseButton.Enabled = false;
            snapButton.Enabled = false;

            score = 0;
            scoreLabel.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snakesnake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snakesnake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            gameTimer.Start();
        }
        private void EatFood()
        {
            score += 1;
            scoreLabel.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snakesnake[Snakesnake.Count - 1].X,
                Y = Snakesnake[Snakesnake.Count - 1].Y
            };
            Snakesnake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            snapButton.Enabled = true;
            if (score > highScore)
            {
                highScore = score;
                highScoreLabel.Text = "High Score: " + Environment.NewLine + highScore;
                highScoreLabel.ForeColor = Color.Maroon;
            }
        }
        //for whatever reason, game breaks when pause button is active
        private void Pause(object sender, EventArgs e)
        {
            //if (isGamePaused)
            //{
            //    // Resume the game
            //    gameTimer.Start(); // Assuming you are using a Timer for game updates
            //    isGamePaused = false;
            //    pauseButton.Text = "Pause"; // Update the button text to indicate it can be used to pause the game

            //}
            //else
            //{
            //    // Pause the game
            //    gameTimer.Stop();
            //    isGamePaused = true;
            //    pauseButton.Text = "Resume"; // Update the button text to indicate it can be used to resume the game
            //}
        }
    }
}