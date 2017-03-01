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
            Game2 game = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);
            game.Rand();
            Print(game);

            while (!game.IsWin())
            {
                Console.Write("Введите число ");
                int value = Convert.ToInt32(Console.ReadLine());
                if (game.Shift(value) > 0)
                    Print(game);
                else if (game.Shift(value) == -1)
                    Console.WriteLine("Неовзможный ход!");
                else
                    Console.WriteLine("Такого значения нет!");
            }
            Console.WriteLine("Поздравляем! Вы победили!");
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
