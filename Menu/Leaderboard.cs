namespace OscorpGames
{
	public partial class Leaderboard : Form
	{
		public const string MINE_GAME_NAME = "Minesweeper";
		public const string PACMAN_GAME_NAME = "PacMan";
		public const string TETRIS_GAME_NAME = "Tetris";
		public const string SNAKE_GAME_NAME = "Snake";

		public Leaderboard(string game)
		{
			InitializeComponent();
		}

		public static void SaveScore(string[] scores, string gameName)
		{
			string path = "../../../" + gameName + "/Scores";
			if(!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			path += "/scores.csv";
			if(!File.Exists(path))
			{
				File.Create(path).Close();
			}
			StreamWriter sw = new StreamWriter(path);
			for(int i = 0; i < scores.Length; i++)
			{
				sw.Write(scores[i]);
				if(i < scores.Length - 1) 
				{
					sw.Write(',');
				}
			}
			sw.Close();
		}

		public static string[] GetScores(string gameName)
		{
			string path = "../../../" + gameName + "/Scores/score.csv";
			if(!File.Exists(path))
			{
				throw new Exception("Tried to get the scores for a game that has no scores");
			}

			StreamReader sr = new StreamReader(path);
			string[] scores = sr.ReadLine().Split(',');
			sr.Close();

			return scores;
		}
	}
}
