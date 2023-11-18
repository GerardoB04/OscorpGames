using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscorpGames.Snake.Code
{
    internal partial class SnakeGame
    {
        private const int gridSize = 20;

        public List<Point> Snake { get; private set; }
        public Point Food { get; private set; }
        public Direction CurrentDirection { get; set; }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public SnakeGame()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            Snake = new List<Point> { new Point(gridSize / 2, gridSize / 2) };
            CurrentDirection = Direction.Right;
            SpawnFood();
        }

        public void CheckCollision()
        {
            // Check if snake head collides with its body
            Point head = Snake.First();
            if (Snake.Skip(1).Any(p => p == head))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            // Game over logic
            // ...
        }
    }
}
