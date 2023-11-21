//#define _DEBUG
#define _RELEASE

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
		private Bitmap FLAG = new Bitmap("../../../Minesweeper/Images/Flag.png");
		private Bitmap BOMB = new Bitmap("../../../Minesweeper/Images/Bomb.png");
		private Bitmap UNKNOWN = new Bitmap("../../../Minesweeper/Images/Unknown.png");
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
		private int numBombs = 30;
		private bool[,] mineField;
		private PictureBox[,] tiles;

		public Minesweeper() {
			InitializeComponent();
			StartGame();
		}

		private void StartGame() {
			mineField = new bool[width, height];
			tiles = new PictureBox[width, height];

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

					pictureBox.Image = UNKNOWN;
					pictureBox.Size = new Size(NO_BOMB.Width, NO_BOMB.Height);
					pictureBox.Location = new Point(i * NO_BOMB.Width, j * NO_BOMB.Height);

					pictureBox.Click += tile_Click;

					bombField.Controls.Add(pictureBox);
					tiles[i, j] = pictureBox;
				}
			}

			#if _DEBUG
			for(int i = 0; i < width; i++) {
				for(int j = 0; j < height; j++) {
					PictureBox tile = tiles[i, j];
					if(mineField[i, j]) {
						tile.Image = BOMB;
					} else {
						tile.Image = ConvertIntToBitmap(CountSurroundingBombs(new Point(tile.Location.X / 32, tile.Location.Y / 32)));
					}
				}
			}
			#elif _RELEASE
			for(int i = 0; i < width; i++) {
				for(int j = 0; j < height; j++) {
					if(CountSurroundingBombs(new Point(i, j)) == 0 && !mineField[i, j]) {
						RevealEmptyTiles(new Point(i, j));
						return;
					}
				}
			}
			#endif
		}

		private int CountSurroundingBombs(Point location) {
			PictureBox?[] tiles = GetSurroundingTiles(location);
			int bombs = 0;

			foreach(PictureBox? tile in tiles) {
				if(tile != null) {
					if(mineField[tile.Location.X / 32, tile.Location.Y / 32]) {
						bombs += 1;
					}
				}
			}

			return bombs;
		}

		private PictureBox?[] GetSurroundingTiles(Point location) {
			PictureBox?[] tiles = new PictureBox[8];

			for(int i = 0; i < 8; i++) {
				tiles[i] = null;
			}

			if(IsValidPosition(location.X, location.Y - 1)) {
				tiles[0] = this.tiles[location.X, location.Y - 1];
			}
			if(IsValidPosition(location.X + 1, location.Y - 1)) {
				tiles[1] = this.tiles[location.X + 1, location.Y - 1];
			}
			if(IsValidPosition(location.X + 1, location.Y)) {
				tiles[2] = this.tiles[location.X + 1, location.Y];
			}
			if(IsValidPosition(location.X + 1, location.Y + 1)) {
				tiles[3] = this.tiles[location.X + 1, location.Y + 1];
			}
			if(IsValidPosition(location.X, location.Y + 1)) {
				tiles[4] = this.tiles[location.X, location.Y + 1];
			}
			if(IsValidPosition(location.X - 1, location.Y + 1)) {
				tiles[5] = this.tiles[location.X - 1, location.Y + 1];
			}
			if(IsValidPosition(location.X - 1, location.Y)) {
				tiles[6] = this.tiles[location.X - 1, location.Y];
			}
			if(IsValidPosition(location.X - 1, location.Y - 1)) {
				tiles[7] = this.tiles[location.X - 1, location.Y - 1];
			}

			return tiles;
		}

		private bool IsValidPosition(int x, int y) {
			if((x < 0 || x >= width) || (y < 0 || y >= height)) {
				return false;
			}
			return true;
		}

		private void tile_Click(object sender, EventArgs e) {
			PictureBox tile = (PictureBox) sender;

			switch(((MouseEventArgs) e).Button) {
				case MouseButtons.Left:
					if(tile.Image != FLAG) {
						Point location = tile.Location;
						location.X /= 32;
						location.Y /= 32;

						if(mineField[location.X, location.Y]) {
							tile.Image = BOMB;
						} else {
							tile.Image = ConvertIntToBitmap(CountSurroundingBombs(new Point(location.X, location.Y)));
							RevealEmptyTiles(location);
						}
					}
					break;
				case MouseButtons.Right:
					if(tile.Image == UNKNOWN) {
						tile.Image = FLAG;
						numBombs -= 1;
					} else if(tile.Image == FLAG) {
						tile.Image = UNKNOWN;
						numBombs += 1;
					}
					break;
			}
		}

		/*
		private void MoveBomb(int x, int y) {
			if(mineField[x, y]) {
				mineField[x, y] = false;

				Random random = new Random();
				while(true) {
					int bombX = random.Next(0, width);
					int bombY = random.Next(0, height);

					if(bombX == x && bombY == y) {
						continue;
					}
					if(mineField[bombX, bombY]) {
						continue;
					}

					mineField[bombX, bombY] = true;
					break;
				}
			}
		}
		*/

		private void RevealEmptyTiles(Point startingLocation) {
			if(CountSurroundingBombs(startingLocation) == 0) {
				PictureBox?[] tiles = GetSurroundingTiles(startingLocation);

				foreach(PictureBox? currentTile in tiles) {
					if(currentTile != null) {
						Point currentTileLocation = currentTile.Location;
						currentTileLocation.X /= 32;
						currentTileLocation.Y /= 32;
						if(!mineField[currentTileLocation.X, currentTileLocation.Y]) {
							if(CountSurroundingBombs(currentTileLocation) == 0 && currentTile.Image != NO_BOMB) {
								currentTile.Image = NO_BOMB;
								RevealEmptyTiles(currentTileLocation);
							} else {
								currentTile.Image = ConvertIntToBitmap(CountSurroundingBombs(currentTileLocation));
							}
						}
					}
				}
			}
		}

		private Bitmap ConvertIntToBitmap(int numBombs) {
			switch(numBombs) {
				case 1:
					return ONE_BOMB;
				case 2:
					return TWO_BOMB;
				case 3:
					return THREE_BOMB;
				case 4:
					return FOUR_BOMB;
				case 5:
					return FIVE_BOMB;
				case 6:
					return SIX_BOMB;
				case 7:
					return SEVEN_BOMB;
				case 8:
					return EIGHT_BOMB;
				default:
					return NO_BOMB;
			}
		}
	}
}
