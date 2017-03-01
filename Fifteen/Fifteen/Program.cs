using System;
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
            Print(newGame);

            while (1 == 1)
            {
                Console.Write("Введите число ");
                int value = Convert.ToInt32(Console.ReadLine());
                if (newGame.Shift(value) > 0)
                    Print(newGame);
                else if (newGame.Shift(value) == -1)
                    Console.WriteLine("Неовзможный ход!");
                else
                    Console.WriteLine("Такого значения нет!");

            }

        }

        static void Print(Game game)
        {
            for (int x = 0; x < game.Size; x++)
            {
                for (int y = 0; y < game.Size; y++)
                {
                    Console.Write(game.Matrix[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
