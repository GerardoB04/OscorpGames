using OscorpGames.PacMan;
using System.Media;

namespace OscorpGames.Pac_Man
{
    public partial class PacManGame : Form
    {
        bool goup, godown, goleft, goright, isGameOver;

        int scoreCount, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY, redGhostX, redGhostY, yellowGhostX, yellowGhostY, totalCoins, timeSeconds, timeTicks;

        string filePath = "../../../PacMan/PacManScores.txt";

        SoundPlayer move = new SoundPlayer("../../../PacMan/Resources/move.wav");
        SoundPlayer coin = new SoundPlayer("../../../PacMan/Resources/coin.wav");
        SoundPlayer death = new SoundPlayer("../../../PacMan/Resources/death.wav");
        SoundPlayer win = new SoundPlayer("../../../PacMan/Resources/winav");
        SoundPlayer ghostBounce = new SoundPlayer("../../../PacMan/Resources/ghostBounce.wav");
        SoundPlayer pacWall = new SoundPlayer("../../../PacMan/Resources/pacWall.wav");
        public PacManGame()
        {
            InitializeComponent();
            pacBBBottom.Visible = false;
            pacBBLeft.Visible = false;
            pacBBRight.Visible = false;
            pacBBTop.Visible = false;

            pgBBBottom.Visible = false;
            pgBBLeft.Visible = false;
            pgBBRight.Visible = false;
            pgBBTop.Visible = false;

            rgBBBottom.Visible = false;
            rgBBLeft.Visible = false;
            rgBBRight.Visible = false;
            rgBBTop.Visible = false;
            resetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            move.Play();

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                if (pacman.Image != PacManResource.Up) { pacman.Image = PacManResource.Up; }
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                if (pacman.Image != PacManResource.down) { pacman.Image = PacManResource.down; }
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                if (pacman.Image != PacManResource.left) { pacman.Image = PacManResource.left; }
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                if (pacman.Image != PacManResource.right) { pacman.Image = PacManResource.right; }
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            move.Stop();
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

            if(Leaderboard.GetScores(Leaderboard.PACMAN_GAME_NAME) == new string[] { "0" })
            {
                Leaderboard.SaveScore(new string[] { "9999", "9999", "9999" }, Leaderboard.PACMAN_GAME_NAME);
            }

            readLowTimes();
            score.Text = "Score: 0";
            scoreCount = 0;


            redGhostX = new Random().Next(5, 11);
            redGhostY = 10 - redGhostX;
            pinkGhostX = new Random().Next(3, 6);
            pinkGhostY = 20 - pinkGhostX;

            yellowGhostSpeed = 2;
            playerSpeed = 15;

            isGameOver = false;

            pacman.Location = new Point(40, 365);

            redGhost.Location = new Point(redGhost.Location.X, redGhost.Location.Y);
            yellowGhost.Location = new Point(yellowGhost.Location.X, yellowGhost.Location.Y);
            pinkGhost.Location = new Point(pinkGhost.Location.X, pinkGhost.Location.Y);


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if (x.Tag as string == "coin")
                    {
                        totalCoins++;
                    }
                }
            }
            timer1.Start();
        }

        private void readLowTimes()
        {
            string[] lines = Leaderboard.GetScores(Leaderboard.PACMAN_GAME_NAME);

            LowTime1.Text = "1)" + lines[0];
            LowTime2.Text = "2)" + lines[1];
            LowTime3.Text = "3)" + lines[2];
        }
        private void writeLowTimes()
        {
            string[] lines = Leaderboard.GetScores(Leaderboard.PACMAN_GAME_NAME);

            int low1 = int.Parse(lines[0]);
            int low2 = int.Parse(lines[1]);
            int low3 = int.Parse(lines[2]);
            int[] times = { low1, low2, low3, timeSeconds };
            Array.Sort(times);

            Leaderboard.SaveScore(new string[] { times[0].ToString(), times[1].ToString(), times[2].ToString() }, Leaderboard.PACMAN_GAME_NAME);
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
                    if (x.Tag as string == "wall")
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
            timeSeconds = timeTicks / (1000 / timer1.Interval);
            time_Lbl.Text = "Time: " + timeSeconds;



            score.Text = "Score: " + scoreCount;
            if (goleft)
            {
                if (!IntersectsWithWall(pacBBLeft))
                {
                    pacman.Left -= playerSpeed;
                }
                else
                {
                    pacWall.Play();
                }
            }
            if (goright)
            {
                if (!IntersectsWithWall(pacBBRight))
                {
                    pacman.Left += playerSpeed;
                }
                else
                {
                    pacWall.Play();
                }
            }
            if (godown)
            {
                if (!IntersectsWithWall(pacBBBottom))
                {
                    pacman.Top += playerSpeed;
                }
                else
                {
                    pacWall.Play();
                }
            }
            if (goup)
            {
                if (!IntersectsWithWall(pacBBTop))
                {
                    pacman.Top -= playerSpeed;
                }
                else
                {
                    pacWall.Play();
                }
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
                    if (x.Tag as string == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            scoreCount += 1;
                            x.Visible = false;
                        }
                    }

                    if (x.Tag as string == "wall")
                    {
                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostY = -pinkGhostY;
                        }
                        if (redGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            redGhostX = -redGhostX;
                        }
                    }


                    if (x.Tag as string == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }

                    }
                }
            }


            // moving ghosts


            if (IntersectsWithWall(pgBBLeft) || IntersectsWithWall(pgBBRight))
            {
                pinkGhostX = -pinkGhostX;
            }

            if (IntersectsWithWall(pgBBTop) || IntersectsWithWall(pgBBBottom))
            {
                pinkGhostY = -pinkGhostY;
            }

            //red
            if (IntersectsWithWall(rgBBLeft) || IntersectsWithWall(rgBBRight))
            {
                redGhostX = -redGhostX;
            }

            if (IntersectsWithWall(rgBBTop) || IntersectsWithWall(rgBBBottom))
            {
                redGhostY = -redGhostY;
            }

            redGhost.Left += redGhostX;
            redGhost.Top += redGhostY;
            pinkGhost.Left += pinkGhostX;
            pinkGhost.Top += pinkGhostY;
            yellowGhost.Left += yellowGhostSpeed;
            yellowGhost.Top -= yellowGhostSpeed;

            //moving collision boxes
            pacBBTop.Location = new Point(pacman.Location.X, pacman.Location.Y - 15);
            pacBBBottom.Location = new Point(pacman.Location.X, pacman.Location.Y + 64);
            pacBBLeft.Location = new Point(pacman.Location.X - 15, pacman.Location.Y);
            pacBBRight.Location = new Point(pacman.Location.X + 64, pacman.Location.Y);

            pgBBTop.Location = new Point(pinkGhost.Location.X, pinkGhost.Location.Y - 15);
            pgBBBottom.Location = new Point(pinkGhost.Location.X, pinkGhost.Location.Y + 60);
            pgBBLeft.Location = new Point(pinkGhost.Location.X - 15, pinkGhost.Location.Y);
            pgBBRight.Location = new Point(pinkGhost.Location.X + 50, pinkGhost.Location.Y);

            rgBBTop.Location = new Point(redGhost.Location.X, redGhost.Location.Y - 15);
            rgBBBottom.Location = new Point(redGhost.Location.X, redGhost.Location.Y + 60);
            rgBBLeft.Location = new Point(redGhost.Location.X - 15, redGhost.Location.Y);
            rgBBRight.Location = new Point(redGhost.Location.X + 50, redGhost.Location.Y);


            //yellow
            if (yellowGhost.Left < -10)
            {
                yellowGhost.Left = this.Width + 10;
            }
            if (yellowGhost.Left > this.Width + 10)
            {
                yellowGhost.Left = -10;
            }

            if (yellowGhost.Top < -10)
            {
                yellowGhost.Top = this.Height + 10;
            }
            if (yellowGhost.Top > this.Height + 10)
            {
                yellowGhost.Top = -10;
            }

            //red
            if (redGhost.Left < -10)
            {
                redGhost.Left = this.Width + 10;
            }
            if (redGhost.Left > this.Width + 10)
            {
                redGhost.Left = -10;
            }

            if (redGhost.Top < -10)
            {
                redGhost.Top = this.Height + 10;
            }
            if (redGhost.Top > this.Height + 10)
            {
                redGhost.Top = -10;
            }
            //pink
            if (pinkGhost.Left < -10)
            {
                pinkGhost.Left = this.Width + 10;
            }
            if (pinkGhost.Left > this.Width + 10)
            {
                pinkGhost.Left = -10;
            }

            if (pinkGhost.Top < -10)
            {
                pinkGhost.Top = this.Height + 10;
            }
            if (pinkGhost.Top > this.Height + 10)
            {
                pinkGhost.Top = -10;
            }
            if (scoreCount >= totalCoins)
            {
                gameOver("You Win!");
            }
        }
    }
}
