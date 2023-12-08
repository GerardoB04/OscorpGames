using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Direction
    {
        /// <summary>
        /// makes it so that the snake will move in the grid fromat with some works to make sure it doesnt instantly swap 180 degrees
        /// </summary>
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);

        public int RowOffest { get; }
        public int ColumnOffest { get; }

        private Direction(int rowOffest, int columnOffest)
        {
            RowOffest = rowOffest;
            ColumnOffest = columnOffest;
        }
        //used ctrl + . to get these (no way i would have otherwise lol)
        public Direction Opposite()
        {
            return new Direction(-RowOffest, -ColumnOffest);
        }

        public override bool Equals(object? obj)
        {
            return obj is Direction direction &&
                   RowOffest == direction.RowOffest &&
                   ColumnOffest == direction.ColumnOffest;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffest, ColumnOffest);
        }

        public static bool operator ==(Direction? left, Direction? right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction? left, Direction? right)
        {
            return !(left == right);
        }
    }
}
