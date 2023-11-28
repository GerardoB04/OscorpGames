using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Position
    {
        /// <summary>
        /// gets the position of the snake from the head and tail to make sure that the snake can move along and be allowed for growth (through the fruit)
        /// </summary>
        public int Row { get; }
        public int Column { get; }
        public Position(int row, int column) {  Row = row; Column = column; }
        public Position Translate(Direction dir) { return new Position(Row + dir.RowOffest, Column + dir.ColumnOffest); }
        //ctrl + . for this again
        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position? left, Position? right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position? left, Position? right)
        {
            return !(left == right);
        }
    }
}
