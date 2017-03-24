using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game2 : Game, IPlayable
    {
        public Game2(params int[] values) : base(values) { }

        public virtual void Randomize()
        {
            int[] valuesAround = new int[4];
            int countOfWays = 0;
            Random ran = new Random();
            for (int i = 0; i < 50; i++)
            {
                Point zero = GetLocation(0);

                if (zero.X == 0)
                {
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = GameField[zero.X + 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y + 1];
                        countOfWays = 1;
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = GameField[zero.X + 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        countOfWays = 1;
                    }
                    else
                    {
                        valuesAround[0] = GameField[zero.X + 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        valuesAround[2] = GameField[zero.X, zero.Y + 1];
                        countOfWays = 2;
                    }
                }
                else if (zero.X == Size - 1)
                {
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y + 1];
                        countOfWays = 1;
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        countOfWays = 1;
                    }
                    else
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        valuesAround[2] = GameField[zero.X, zero.Y + 1];
                        countOfWays = 2;
                    }
                }
                else if (zero.X > 0 && zero.X < Size - 1)
                {
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y + 1];
                        valuesAround[2] = GameField[zero.X + 1, zero.Y];
                        countOfWays = 2;
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        valuesAround[2] = GameField[zero.X + 1, zero.Y];
                        countOfWays = 2;
                    }
                    else
                    {
                        valuesAround[0] = GameField[zero.X - 1, zero.Y];
                        valuesAround[1] = GameField[zero.X, zero.Y - 1];
                        valuesAround[2] = GameField[zero.X + 1, zero.Y];
                        valuesAround[3] = GameField[zero.X, zero.Y + 1];
                        countOfWays = 3;
                    }
                }
                Shift(valuesAround[ran.Next(0, countOfWays)]);
            }
        }

        public bool IsFinished()
        {
            int k = 1;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (GameField[x, y] != k && k < Size * Size)
                        return false;
                    k++;
                }
            }
            return true;
        }
    }
}
