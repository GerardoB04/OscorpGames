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

        int scoreCount, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY, redGhostX, redGhostY, yellowGhostX, yellowGhostY, totalCoins, timeSeconds, timeTicks;
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
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
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
            string filePath = "PacManScores.txt";
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("9999");
                    sw.WriteLine("9999");
                    sw.WriteLine("9999");
                }
            }
            readLowTimes();
            score.Text = "Score: 0";
            scoreCount = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 2;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 10;

            isGameOver = false;

            pacman.Location = new Point(40, 365);

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

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin")
                    {
                        totalCoins++;
                    }
                }
            }
            timer1.Start();
        }

        private void readLowTimes()
        {
            string[] lines = File.ReadAllLines("PacManScores.txt");

            LowTime1.Text = "1)" + lines[0];
            LowTime2.Text = "2)" + lines[1];
            LowTime3.Text = "3)" + lines[2];
        }
        private void writeLowTimes()
        {
            string[] lines = File.ReadAllLines("PacManScores.txt");

            int low1 = int.Parse(lines[0]);
            int low2 = int.Parse(lines[1]);
            int low3 = int.Parse(lines[2]);
            int[] times = { low1, low2, low3, timeSeconds };
            Array.Sort(times);
            using (StreamWriter sw = new StreamWriter("PacManScores.txt"))
            {
                sw.WriteLine(times[0]);
                sw.WriteLine(times[1]);
                sw.WriteLine(times[2]);
            }
        }

        private void gameOver(string message)
        {

            isGameOver = true;

            timer1.Stop();
            score.Text = "Score: " + scoreCount;
            writeLowTimes();
            timeSeconds = 0;
            timeTicks = 0;
            MessageBox.Show(message);
        }
        private bool IntersectsWithWall(PictureBox picture)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (picture.Bounds.IntersectsWith(x.Bounds))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTicks += 1;
            timeSeconds = timeTicks / (1000/timer1.Interval);
            time_Lbl.Text = "Time: " + timeSeconds;

            pacBBTop.Location = new Point(pacman.Location.X, pacman.Location.Y - 15);
            pacBBBottom.Location = new Point(pacman.Location.X, pacman.Location.Y + 64);
            pacBBLeft.Location = new Point(pacman.Location.X - 15, pacman.Location.Y);
            pacBBRight.Location = new Point(pacman.Location.X + 64, pacman.Location.Y);

            score.Text = "Score: " + scoreCount;
            if (goleft)
            {
                if (!IntersectsWithWall(pacBBLeft))
                {
                    pacman.Left -= playerSpeed;
                }
                if (pacman.Image != PacManResource.left) pacman.Image = PacManResource.left;
            }
            if (goright)
            {
                if (!IntersectsWithWall(pacBBRight))
                {
                    pacman.Left += playerSpeed;
                }
                if (pacman.Image != PacManResource.right) pacman.Image = PacManResource.right;
            }
            if (godown)
            {
                if (!IntersectsWithWall(pacBBBottom))
                {
                    pacman.Top += playerSpeed;
                }
                if (pacman.Image != PacManResource.down) pacman.Image = PacManResource.down;
            }
            if (goup)
            {
                if (!IntersectsWithWall(pacBBTop))
                {
                    pacman.Top -= playerSpeed;
                }
                if (pacman.Image != PacManResource.Up) pacman.Image = PacManResource.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = this.Width + 10;
            }
            if (pacman.Left > this.Width + 10)
            {
                pacman.Left = -10;
            }

            if (pacman.Top < -10)
            {
                pacman.Top = this.Height + 10;
            }
            if (pacman.Top > this.Height + 10)
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
            if (scoreCount == totalCoins)
            {
                gameOver("You Win!");
            }
        }

        private void PacManGame_Load(object sender, EventArgs e)
        {

        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}
