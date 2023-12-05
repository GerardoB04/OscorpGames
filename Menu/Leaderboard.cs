namespace OscorpGames
{
	public partial class Leaderboard : Form
	{
		public const string MINE_GAME_NAME = "Minesweeper";
		public const string PACMAN_GAME_NAME = "PacMan";
		public const string SNAKE_GAME_NAME = "Snake";
		public const string TETRIS_GAME_NAME = "Tetris";

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
				if(scores[i] == string.Empty)
				{
					i += 1;
					continue;
				}
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
			string path = "../../../" + gameName + "/Scores/scores.csv";
			if(!File.Exists(path))
			{
				throw new Exception("Tried to get the scores for a game that has no scores");
			}

			StreamReader sr = new StreamReader(path);
			string[] scores = sr.ReadLine().Split(',');
			sr.Close();

			return scores;
		}

		private static Dictionary<string, string[]> GetAllScores()
		{
			Dictionary<string, string[]> allScores = new Dictionary<string, string[]>();

			if(ScoresExist(MINE_GAME_NAME))
			{
				allScores[MINE_GAME_NAME] = GetScores(MINE_GAME_NAME);
			}
			if(ScoresExist(PACMAN_GAME_NAME))
			{
				allScores[PACMAN_GAME_NAME] = GetScores(PACMAN_GAME_NAME);
			}
			if(ScoresExist(SNAKE_GAME_NAME))
			{
				allScores[SNAKE_GAME_NAME] = GetScores(SNAKE_GAME_NAME);
			}
			if(ScoresExist(TETRIS_GAME_NAME))
			{
				allScores[TETRIS_GAME_NAME] = GetScores(TETRIS_GAME_NAME);
			}

			return allScores;
		}

		private static bool ScoresExist(string gameName)
		{
			string path = "../../../" + gameName + "/Scores";
			if(!Directory.Exists(path))
			{
				return false;
			}
			path += "/scores.csv";
			if(!File.Exists(path))
			{
				return false;
			}
			return true;
		}

		public static bool IsHighestScore(string score, string gameName)
		{
			decimal scoreDecimal = decimal.Parse(score);

			string[] scores = GetScores(gameName);
			decimal[] scoresDecimal = new decimal[scores.Length];

			for(int i = 0; i < scores.Length; i++)
			{
				scoresDecimal[i] = decimal.Parse(scores[i]);
			}

			foreach(decimal numericScore in scoresDecimal)
			{
				if(numericScore > scoreDecimal)
				{
					return true;
				}
			}
			return false;
		}
	}
}
