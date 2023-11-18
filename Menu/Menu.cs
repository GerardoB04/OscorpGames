using OscorpGames.Pac_Man;

namespace OscorpGames {
	public partial class Menu : Form {
		public Menu() {
			InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void MainMenu_Load(object sender, EventArgs e) {
			//
		}

		private void OpenGame(Form game) {
			this.Hide();
			game.ShowDialog();
			this.Show();
		}

		private void gameOneButton_Click(object sender, EventArgs e) {
			OpenGame(new Minesweeper());
		}

		private void gameTwoButton_Click(object sender, EventArgs e) {
			//OpenGame(new Snake());
		}

		private void gameThreeButton_Click(object sender, EventArgs e) {
			OpenGame(new Pac_Man.Pac_Man());
		}

		private void gameFourButton_Click(object sender, EventArgs e) {
			OpenGame(new Tetris());
		}
	}
}