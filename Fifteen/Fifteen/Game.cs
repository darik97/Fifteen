using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game
    {
        public readonly Point[] Arr;
        public readonly int[,] Matrix;
        public readonly int Size;

        public Game(params int[] values)
        {
            Size = Convert.ToInt32(Math.Sqrt(values.Length));

            if (Math.Pow(Size, 2) - values.Length != 0)
            {
                throw new System.ArgumentException("Неправильное заполнение поля!\n");
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0 && values[i] > values.Length - 1 && values[i] != i + 1)
                {
                    throw new System.ArgumentException("Неправильное заполнение поля!\n");
                }
            }
            Matrix = new int[Size, Size];
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

        public virtual void Shift(int value)
        {
            if (value >= 0 && value < Arr.Length)
            {
                Point valueLocation = GetLocation(value);
                Point zeroLocation = GetLocation(0);

                if (Math.Abs(valueLocation.X - zeroLocation.X) == 1 && Math.Abs(valueLocation.Y - zeroLocation.Y) == 0 ||
                    Math.Abs(valueLocation.X - zeroLocation.X) == 0 && Math.Abs(valueLocation.Y - zeroLocation.Y) == 1)
                {
                    Change(zeroLocation, valueLocation);
                }
                else
                {
                    throw new ArgumentException("Невозможный ход!\n");
                }
            }
            else
            {
                throw new ArgumentException("Недопустимое значение!\n");
            }
        }

        public int this[int x, int y]
        {
            get
            {
                return Matrix[x, y];
            }
            set
            {
                Matrix[x, y] = value;
            }
        }

        public void Change(Point p0, Point p)
        {
            var t = Matrix[p0.X, p0.Y];
            Matrix[p0.X, p0.Y] = Matrix[p.X, p.Y];
            Matrix[p.X, p.Y] = t;
            Point temp = Arr[t];
            Arr[t] = Arr[Matrix[p0.X, p0.Y]];
            Arr[Matrix[p0.X, p0.Y]] = temp;
        }

        public static Game FromCSV(string file)
        {
            string[] lines = File.ReadAllLines(file);
            int size = lines.Length;
            string temp;
            int[] numbers = new int[size * size];
            int k = 0;

            for (int i = 0; i < size; i++)
            {
                if (lines[i].Length != size)
                    return null;
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = lines[i].Substring(0, lines[i].IndexOf(',')).Trim();
                    numbers[k] = Convert.ToInt32(temp);
                    lines[i] = lines[i].Substring(lines[i].IndexOf(','));
                    k++;
                }
            }
            return new Game(numbers);
        }
    }
}
