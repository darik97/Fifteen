using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class ConsoleGameUI
    {
        IPlayable game;
        public ConsoleGameUI(int gameClass)
        {
            if (gameClass == 2)
            {
                game = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);
            }
            else
            {
                game = new Game3(1, 2, 3, 4, 5, 6, 7, 8, 0);
            }
        }

        public void Play()
        {
            game.Randomize();

            Print((Game)game);

            while (!game.IsFinished())
            {
                Console.Write("Введите число ");
                int value = Convert.ToInt32(Console.ReadLine());
                game.Shift(value);
                Print((Game) game);

            }
            Console.WriteLine("Поздравляем! Вы победили!");
        }

        public void Print(Game game)
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

        //public void Randomize()
        //{
        //    game.Randomize();
        //}

        //public void Print()
        //{
        //    game.Print();
        //}

        //public void Shift(int value)
        //{
        //    game.Shift(value);
        //}

        //public bool IsFinished()
        //{
        //    return game.IsFinished();
        //}
    }
}
