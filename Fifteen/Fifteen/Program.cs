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
            //IPlayable game;
            Console.Write("Введите, с каким классом работать: ");
            int gameClass = Convert.ToInt32(Console.ReadLine());
            ConsoleGameUI game = new ConsoleGameUI(gameClass);

            game.Play();

            //game.Randomize();

            //game.Print();

            //while (!game.IsFinished())
            //{
            //    Console.Write("Введите число ");
            //    int value = Convert.ToInt32(Console.ReadLine());
            //    game.Shift(value);
            //    game.Print();

            //    //Console.Write("Отменить ходы ");
            //    //int steps = Convert.ToInt32(Console.ReadLine());
            //    //game.MakeStepsBack(steps);
            //    //Print(game);

            //}
            //Console.WriteLine("Поздравляем! Вы победили!");
        }

        static void Print(Game game)
        {
            for (int x = 0; x < game.Size; x++)
            {
                for (int y = 0; y < game.Size; y++)
                {
                    Console.Write(game.GameField[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


