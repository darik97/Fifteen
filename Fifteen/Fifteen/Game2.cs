using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game2 : Game
    {
        public Game2(params int[] values) : base(values) { }

        public void Rand()
        {
            int[] valuesAround = new int[4];
            Random ran = new Random();
            for (int i = 0; i < 50; i++)
            {
                Point zero = GetLocation(0);

                if (zero.X == 0)
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = Matrix[zero.X + 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y + 1];
                        base.Shift(valuesAround[ran.Next(0, 1)]);
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = Matrix[zero.X + 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        base.Shift(valuesAround[ran.Next(0, 1)]);
                    }
                    else
                    {
                        valuesAround[0] = Matrix[zero.X + 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        valuesAround[2] = Matrix[zero.X, zero.Y + 1];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                if (zero.X == Size - 1)
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y + 1];
                        base.Shift(valuesAround[ran.Next(0, 1)]);
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        base.Shift(valuesAround[ran.Next(0, 1)]);
                    }
                    else
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        valuesAround[2] = Matrix[zero.X, zero.Y + 1];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                if (zero.X > 0 && zero.X < Size - 1)
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y + 1];
                        valuesAround[2] = Matrix[zero.X + 1, zero.Y];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        valuesAround[2] = Matrix[zero.X + 1, zero.Y];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                if (zero.X > 0 && zero.X < Size - 1)
                    if (zero.Y == 0)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y + 1];
                        valuesAround[2] = Matrix[zero.X + 1, zero.Y];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                    else if (zero.Y == Size - 1)
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X, zero.Y - 1];
                        valuesAround[2] = Matrix[zero.X + 1, zero.Y];
                        base.Shift(valuesAround[ran.Next(0, 2)]);
                    }
                    else
                    {
                        valuesAround[0] = Matrix[zero.X - 1, zero.Y];
                        valuesAround[1] = Matrix[zero.X + 1, zero.Y];
                        valuesAround[2] = Matrix[zero.X, zero.Y - 1];
                        valuesAround[3] = Matrix[zero.X, zero.Y + 1];
                        base.Shift(valuesAround[ran.Next(0, 3)]);
                    }
            }
        }

        public bool IsWin()
        {
            int k = 1;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (Matrix[x, y] != k && k < Size * Size)
                        return false;
                    k++;
                }
            }
            return true;
        }
    }
}
