using OscorpGames.PacMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscorpGames.Pac_Man
{
    public partial class PacManGame : Form
    {
        bool goup, godown, goleft, goright, isGameOver;

        int scoreCount, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY, redGhostX, redGhostY, yellowGhostX, yellowGhostY;
        public PacManGame()
        {
            InitializeComponent();

            resetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {

            score.Text = "Score: 0";
            scoreCount = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 2;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 10;

            isGameOver = false;

            pacman.Left = 102;
            pacman.Top = 604;

            redGhost.Left = 612;
            redGhost.Top = 345;

            yellowGhost.Left = 497;
            yellowGhost.Top = 492;

            pinkGhost.Left = 755;
            pinkGhost.Top = 82;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }


            timer1.Start();
        }

        private void gameOver(string message)
        {

            isGameOver = true;

            timer1.Stop();

            score.Text = "Score: " + scoreCount;

            MessageBox.Show(message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Text = "Score: " + scoreCount;
            if (goleft)
            {
                pacman.Left -= playerSpeed;
                //pacman.Location = new Point(pacman.Location.X - playerSpeed, pacman.Location.Y);
                if(pacman.Image != PacManResource.left) pacman.Image = PacManResource.left;
            }
            if (goright)
            {
                pacman.Left += playerSpeed;
                //pacman.Location = new Point(pacman.Location.X + playerSpeed, pacman.Location.Y);
                if (pacman.Image != PacManResource.right) pacman.Image = PacManResource.right;
            }
            if (godown)
            {
                pacman.Top += playerSpeed;
                //pacman.Location = new Point(pacman.Location.X, pacman.Location.Y + playerSpeed);
                if (pacman.Image != PacManResource.down) pacman.Image = PacManResource.down;
            }
            if (goup)
            {
                pacman.Top -= playerSpeed;
                //pacman.Location = new Point(pacman.Location.X, pacman.Location.Y - playerSpeed);
                if (pacman.Image != PacManResource.Up) pacman.Image = PacManResource.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 1328;
            }
            if (pacman.Left > 1328)
            {
                pacman.Left = -10;
            }

            if (pacman.Top < -10)
            {
                pacman.Top = 732;
            }
            if (pacman.Top > 732)
            {
                pacman.Top = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            scoreCount += 1;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }


                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                            pinkGhostY = -pinkGhostY;
                        }
                        if (redGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            redGhostX = -redGhostX;
                            redGhostY = -redGhostY;
                            redGhostSpeed *= -1;
                        }
                    }


                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }

                    }
                }
            }


            // moving ghosts

            redGhost.Left -= redGhostSpeed;
            redGhost.Top += redGhostSpeed;

            yellowGhost.Left += yellowGhostSpeed;
            yellowGhost.Top -= yellowGhostSpeed;

            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;


            //yellow
            if (yellowGhost.Left < -10)
            {
                yellowGhost.Left = 1328;
            }
            if (yellowGhost.Left > 1328)
            {
                yellowGhost.Left = -10;
            }

            if (yellowGhost.Top < -10)
            {
                yellowGhost.Top = 732;
            }
            if (yellowGhost.Top > 732)
            {
                yellowGhost.Top = 0;
            }

            //red
            if (redGhost.Left < -10)
            {
                redGhost.Left = 1328;
            }
            if (redGhost.Left > 1328)
            {
                redGhost.Left = -10;
            }

            if (redGhost.Top < -10)
            {
                redGhost.Top = 732;
            }
            if (redGhost.Top > 732)
            {
                redGhost.Top = 0;
            }
            //pink
            if (pinkGhost.Left < -10)
            {
                pinkGhost.Left = 1328;
            }
            if (pinkGhost.Left > 1328)
            {
                pinkGhost.Left = -10;
            }

            if (pinkGhost.Top < -10)
            {
                pinkGhost.Top = 732;
            }
            if (pinkGhost.Top > 732)
            {
                pinkGhost.Top = 0;
            }
            if (scoreCount == 56)
            {
                gameOver("You Win!");
            }
        }
    }
}
