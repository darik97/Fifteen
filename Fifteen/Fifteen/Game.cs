using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game
    {
        public readonly Point[] Arr;
        public readonly ArrayOfCells Matrix;
        public readonly int Size;

        public Game(params int[] values)
        {
            double length = Math.Sqrt(values.Length);
            Size = Convert.ToInt32(length);

            if (Math.Abs(Size - length) != 0)
            {
                throw new System.ArgumentException("Неправильное заполнение поля!");
            }

            Matrix = new ArrayOfCells(Size);
            Arr = new Point[values.Length];

            int k = 0;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Matrix[x, y] = values[k];
                    if (k == values.Length)
                        k = 0;
                    Arr[values[k]] = new Point(x, y);
                    k++;
                }
            }

        }

        public Point GetLocation(int value)
        {
            return Arr[value];
        }

        public void Shift(int value)
        {
            Point valueLocation = GetLocation(value);
            int x = valueLocation.X;
            int y = valueLocation.Y;

            Point zeroLocation = GetLocation(0);
            int x0 = zeroLocation.X;
            int y0 = zeroLocation.Y;

            Point temp = new Point(-1, -1);

            if (Math.Abs(x - x0) == 1 && Math.Abs(y - y0) == 0 ||
                Math.Abs(y - y0) == 1 && Math.Abs(x - x0) == 0)
            {
                Matrix[x0, y0] = value;
                Matrix[x, y] = 0;
                temp = Arr[0];
                Arr[0] = Arr[value];
                Arr[value] = temp;
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }
        }

        public void Print()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Console.Write(Matrix[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
