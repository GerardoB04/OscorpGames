using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Game
    {
        /// <summary>
        /// makes the game and the small mechanics within, like game over and how the snake can turn
        /// </summary>
        public int Rows { get; }
        public int Columns { get; }
        public GridValue[,] Grid { get; }
        public Direction Dir { get; private set; }
        public int Score { get; private set; }
        public bool GameOver { get; private set; }

        private readonly LinkedList<Position> _positions = new LinkedList<Position>();
        private readonly Random _random = new Random();

        public Game(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Grid = new GridValue[rows, columns];
            Dir = Direction.Right;

            AddSnake();
            AddFood();
        }

        private void AddSnake()
        {
            int r = Rows / 2;

            for (int c = 1; c <= 3; c++)
            {
                Grid[r, c] = GridValue.Snake;
                _positions.AddFirst(new Position(r, c));
            }
        }

        private IEnumerable<Position> EmptyPositions()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (Grid[r, c] == GridValue.Empty)
                    {
                        yield return new Position(r, c);
                    }
                }
            }
        }

        private void AddFood()
        {
            List<Position> empty = new List<Position>(EmptyPositions());

            if (empty.Count == 0) { return; }
            Position position = empty[_random.Next(empty.Count)];
            Grid[position.Row, position.Column] = GridValue.Food;
        }

        public Position HeadPosition()
        {
            return _positions.First.Value;
        }

        public Position BottomPosition() { return _positions.Last.Value; }
        public IEnumerable<Position> positions() { return _positions; }

        private void AddHead(Position position)
        {
            _positions.AddFirst(position);
            Grid[position.Row, position.Column] = GridValue.Snake;
        }
        private void RemoveTail()
        {
            Position tail = _positions.Last.Value;
            Grid[tail.Row, tail.Column] = GridValue.Empty;
            _positions.RemoveLast();
        }

        public void DirChange(Direction dir)
        {
            Dir = dir;
        }

        private bool OutsideGrid(Position pos)
        {
            return pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns;
        }
        // tail and head move simoulaniously so this makes sure that if tail is right infront of head and can move right before crashing into itself, it wont end the game
        private GridValue WillHit(Position newHeadPos)
        {
            if (OutsideGrid(newHeadPos))
            {
                return GridValue.Outside;
            }

            return Grid[newHeadPos.Row, newHeadPos.Column];
        }

        public void Move()
        {
            Position newHeadPos = HeadPosition().Translate(Dir);
            GridValue hit = WillHit(newHeadPos);

            if (hit == GridValue.Outside || hit == GridValue.Snake)
            {
                GameOver = true;
            }
            else if (hit == GridValue.Empty)
            {
                RemoveTail();
                AddHead(newHeadPos);
            }
            else if (hit == GridValue.Food)
            {
                AddHead(newHeadPos);
                Score++;
                AddFood();
            }
        }
    }
}
