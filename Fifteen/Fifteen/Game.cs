﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game
    {
        public readonly Cell Arr;
        public readonly int Size;

        public Game(params int[] values)
        {
            double length = Math.Sqrt(values.Length);
            this.Size = Convert.ToInt32(length);
            Console.WriteLine(length + " " + Size);

            if(Math.Abs(Size - length) != 0)
            {
                throw new System.ArgumentException("Неправильное заполнение поля!");
            }

            Arr = new Cell(Size);

            int k = 0;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Arr[x, y] = values[k];
                    k++;
                }
            }
        }

        public void Print()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Console.Write(Arr[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[] GetLocation(int value)
        {
            int[] mas = { -1, -1};

            for (int x = 0; x < Size; x++)
                for (int y = 0; y < Size; y++)
                    if (Arr[x, y] == value)
                    {
                        mas[0] = x;
                        mas[1] = y;
                    }
            if (mas[0] < 0)
            {
                Console.WriteLine("Такого значения не существует");
            }
            return mas;
        }

        public void Shift(int value)
        {
            int[] valueLocation = GetLocation(value);
            int x = valueLocation[0];
            int y = valueLocation[1];

            int[] zeroLocation = GetLocation(0);
            int x0 = zeroLocation[0];
            int y0 = zeroLocation[1];

                if (Math.Abs(x - x0) == 1 && Math.Abs(y - y0) == 0 || Math.Abs(y - y0) == 1 && Math.Abs(x - x0) == 0)
                {
                    Arr[x0, y0] = value;
                    Arr[x, y] = 0;
                }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }
        }
    }
}
