using SnakeGame;

namespace OscorpGames
{
	public partial class Menu : Form {
		public Menu() {
			InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void OpenGame(Form game) {
			this.Hide();
			game.ShowDialog();
			this.Show();
		}

		// Minesweeper
		private void gameOneButton_Click(object sender, EventArgs e) {
			OpenGame(new Minesweeper());
		}

		// Snake
		private void gameTwoButton_Click(object sender, EventArgs e) {
			OpenGame(new Snake());
		}

		// Pac-Man
		private void gameThreeButton_Click(object sender, EventArgs e) {
			OpenGame(new Pac_Man.PacManGame());
		}

		// Tetris
		private void gameFourButton_Click(object sender, EventArgs e) {
			OpenGame(new Tetris());
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
			new Settings().ShowDialog();
		}

		private void minesweeperToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new Leaderboard(Leaderboard.MINE_GAME_NAME);
			if(!form.IsDisposed) {
				form.ShowDialog();
			}
		}

		private void snakeToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new Leaderboard(Leaderboard.SNAKE_GAME_NAME);
			if(!form.IsDisposed) {
				form.ShowDialog();
			}
		}

		private void pacManToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new Leaderboard(Leaderboard.PACMAN_GAME_NAME);
			if(!form.IsDisposed) {
				form.ShowDialog();
			}
		}

		private void tetrisToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new Leaderboard(Leaderboard.TETRIS_GAME_NAME);
			if(!form.IsDisposed) {
				form.ShowDialog();
			}
		}
	}
}