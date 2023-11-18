using OscorpGames.Pac_Man;

namespace OscorpGames {
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
            game.ShowDialog();
        }

        private void creatorLabel2_Click(object sender, EventArgs e)
        {

        }


        //minesweeper
        private void gameOneButton_Click(object sender, EventArgs e)
        {

        }

        //snake
        private void gameTwoButton_Click(object sender, EventArgs e)
        {

        }

        //pac man
        private void gameThreeButton_Click(object sender, EventArgs e)
        {
            var pacMan = new PacManGame();
            pacMan.Show();
        }

        //tetris
        private void gameFourButton_Click(object sender, EventArgs e)
        {

        }
    }
}