using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscorpGames {
	public partial class Minesweeper : Form {
		private Bitmap BOMB = new Bitmap("../../../Minesweeper/Images/Bomb.png");
		private Bitmap NO_BOMB = new Bitmap("../../../Minesweeper/Images/None.png");
		private Bitmap ONE_BOMB = new Bitmap("../../../Minesweeper/Images/One.png");
		private Bitmap TWO_BOMB = new Bitmap("../../../Minesweeper/Images/Two.png");
		private Bitmap THREE_BOMB = new Bitmap("../../../Minesweeper/Images/Three.png");
		private Bitmap FOUR_BOMB = new Bitmap("../../../Minesweeper/Images/Four.png");
		private Bitmap FIVE_BOMB = new Bitmap("../../../Minesweeper/Images/Five.png");
		private Bitmap SIX_BOMB = new Bitmap("../../../Minesweeper/Images/Six.png");
		private Bitmap SEVEN_BOMB = new Bitmap("../../../Minesweeper/Images/Seven.png");
		private Bitmap EIGHT_BOMB = new Bitmap("../../../Minesweeper/Images/Eight.png");

		private int width = 16, height = 9;
		private int numBombs = 600;
		private bool[,] mineField;

		public Minesweeper() {
			InitializeComponent();
			StartGame();
		}

		private void StartGame() {
			mineField = new bool[width, height];

			if(numBombs > ((width * height) * 0.9f)) {
				numBombs = (int) ((width * height) * 0.9f);
			}

			Random random = new Random();
			for(int i = 0; i < numBombs; i++) {
				int bombX = random.Next(0, width);
				int bombY = random.Next(0, height);

				if(mineField[bombX, bombY] == true) {
					numBombs -= 1;
					continue;
				}

				mineField[bombX, bombY] = true;
			}

			for(int i = 0; i < width; i++) {
				for(int j = 0; j < height; j++) {
					PictureBox pictureBox = new PictureBox();

					switch(CountSurroundingBombs(new int[] {i, j})) {
						case 0:
							pictureBox.Image = NO_BOMB;
							break;
						case 1:
							pictureBox.Image = ONE_BOMB;
							break;
						case 2:
							pictureBox.Image = TWO_BOMB;
							break;
						case 3:
							pictureBox.Image = THREE_BOMB;
							break;
						case 4:
							pictureBox.Image = FOUR_BOMB;
							break;
						case 5:
							pictureBox.Image = FIVE_BOMB;
							break;
						case 6:
							pictureBox.Image = SIX_BOMB;
							break;
						case 7:
							pictureBox.Image = SEVEN_BOMB;
							break;
						case 8:
							pictureBox.Image = EIGHT_BOMB;
							break;
					}

					if(mineField[i, j]) {
						pictureBox.Image = BOMB;
					}

					pictureBox.Size = new Size(NO_BOMB.Width, NO_BOMB.Height);
					pictureBox.Location = new Point(i * NO_BOMB.Width, j * NO_BOMB.Height);
					bombField.Controls.Add(pictureBox);
				}
			}
		}

		private int CountSurroundingBombs(int[] pos) {
			int bombs = 0;

			if(IsValidPosition(pos[0], pos[1] - 1) && mineField[pos[0], pos[1] - 1]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] + 1, pos[1] - 1) && mineField[pos[0] + 1, pos[1] - 1]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] + 1, pos[1]) && mineField[pos[0] + 1, pos[1]]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] + 1, pos[1] + 1) && mineField[pos[0] + 1, pos[1] + 1]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0], pos[1] + 1) && mineField[pos[0], pos[1] + 1]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] - 1, pos[1] + 1) && mineField[pos[0] - 1, pos[1] + 1]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] - 1, pos[1]) && mineField[pos[0] - 1, pos[1]]) {
				bombs += 1;
			}
			if(IsValidPosition(pos[0] - 1, pos[1] - 1) && mineField[pos[0] - 1, pos[1] - 1]) {
				bombs += 1;
			}

			return bombs;
		}

		private bool IsValidPosition(int x, int y) {
			if((x < 0 || x >= width) || (y < 0 || y >= height)) {
				return false;
			}
			return true;
		}
	}
}
