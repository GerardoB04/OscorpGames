using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscorpGames.Snake.Code
{
    internal partial class SnakeGame
    {
        public void CheckFood()
        {
            // Check if snake ate the food
            if (Snake.First() == Food)
            {
                SpawnFood();
            }
        }

        public void SpawnFood()
        {
            Random random = new Random();
            int x = random.Next(0, gridSize);
            int y = random.Next(0, gridSize);

            Food = new Point(x, y);

            // Ensure food is not spawned on the snake
            while (Snake.Contains(Food))
            {
                x = random.Next(0, gridSize);
                y = random.Next(0, gridSize);
                Food = new Point(x, y);
            }
        }
    }
}
