using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscorpGames.Snake.Code
{
    internal partial class InputHandler
    {
        public static void HandleInput(Keys key, SnakeGame snakeGame)
        {
            switch (key)
            {
                case Keys.Up:
                    if (snakeGame.CurrentDirection != SnakeGame.Direction.Down)
                        snakeGame.CurrentDirection = SnakeGame.Direction.Up;
                    break;
                case Keys.Down:
                    if (snakeGame.CurrentDirection != SnakeGame.Direction.Up)
                        snakeGame.CurrentDirection = SnakeGame.Direction.Down;
                    break;
                case Keys.Left:
                    if (snakeGame.CurrentDirection != SnakeGame.Direction.Right)
                        snakeGame.CurrentDirection = SnakeGame.Direction.Left;
                    break;
                case Keys.Right:
                    if (snakeGame.CurrentDirection != SnakeGame.Direction.Left)
                        snakeGame.CurrentDirection = SnakeGame.Direction.Right;
                    break;
            }
        }
    }
}
