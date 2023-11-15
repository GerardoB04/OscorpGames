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

        private void gameOneButton_Click(object sender, EventArgs e)
        {

        }
    }
}