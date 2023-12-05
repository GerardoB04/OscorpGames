namespace OscorpGames
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //
        }

        private void OpenGame(Form game)
        {
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        // Minesweeper
        private void gameOneButton_Click(object sender, EventArgs e)
        {
            OpenGame(new Minesweeper());
        }

        // Snake
        private void gameTwoButton_Click(object sender, EventArgs e)
        {
            //OpenGame(new Snake());
        }

        // Pac-Man
        private void gameThreeButton_Click(object sender, EventArgs e)
        {
            OpenGame(new Pac_Man.PacManGame());
        }

        // Tetris
        private void gameFourButton_Click(object sender, EventArgs e)
        {
            OpenGame(new Tetris());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new Settings().ShowDialog();
        }
    }
}