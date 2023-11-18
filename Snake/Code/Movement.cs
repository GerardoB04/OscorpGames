using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscorpGames.Snake.Code
{
    internal partial class SnakeGame
    {
        public void MoveSnake()
        {
            Point head = Snake.First();

            switch (CurrentDirection)
            {
                case Direction.Up:
                    head.Y = (head.Y - 1 + gridSize) % gridSize;
                    break;
                case Direction.Down:
                    head.Y = (head.Y + 1) % gridSize;
                    break;
                case Direction.Left:
                    head.X = (head.X - 1 + gridSize) % gridSize;
                    break;
                case Direction.Right:
                    head.X = (head.X + 1) % gridSize;
                    break;
            }
            
            //collision\\
            Snake.Insert(0, head);

            // Check if snake ate itself
            if (Snake.Count > 1 && Snake.Skip(1).Any(p => p == head))
            {
                GameOver();
            }

            // Check if snake is out of bounds
            if (head.X < 0 || head.X >= gridSize || head.Y < 0 || head.Y >= gridSize)
            {
                GameOver();
            }

            // Check if snake ate the food
            if (head == Food)
            {
                SpawnFood();
            }
            else
            {
                Snake.RemoveAt(Snake.Count - 1);
            }
        }
    }
}
