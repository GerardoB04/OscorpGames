using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// establishes the GridValue for the entire game. Consists of empty == 1, snake == 2, food ==3, and outside (deadzone) == 4
    /// </summary>
    public enum GridValue
    {
        Empty,
        Snake,
        Food,
        Outside
    }
}
