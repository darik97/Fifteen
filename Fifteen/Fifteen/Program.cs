﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game(1, 2, 3, 4, 5, 6, 7, 8, 0);
            newGame.Print();

            while (1 == 1)
            {
                Console.Write("Введите число ");
                int value = Convert.ToInt32(Console.ReadLine());
                newGame.Shift(value);
                newGame.Print();
            }

        }
    }
}
