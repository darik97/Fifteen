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
        public ConsoleGameUI(IPlayable game)
        {
            this.game = game;
        }

        public void Play()
        {
            int maxValue = Convert.ToInt32(Math.Pow(game.Size, 2) - 1);
            game.Randomize();

            Print();

            while (!game.IsFinished())
            {
                Console.Write("Введите число ");
                int value = GetValueToShift();
                game.Shift(value);
                Print();
            }
            Console.WriteLine("Поздравляем! Вы победили!");
        }

        public int GetValueToShift()
        {
            string valueS = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < valueS.Length; i++)
                if (valueS[i] < '0' || valueS[i] > '9')
                {
                    Console.WriteLine("Введите число от 0 до " + (Math.Pow(game.Size, 2) - 1) + "!");
                    GetValueToShift();
                }
            int value = Convert.ToInt32(valueS);
            if (value < 0 || value > Math.Pow(game.Size, 2) - 1)
            {
                Console.WriteLine("Введите число от 0 до " + (Math.Pow(game.Size, 2) - 1) + "!");
                GetValueToShift();
            }
            return value;
        }

        public void Print()
        {
            for (int x = 0; x < game.Size; x++)
            {
                for (int y = 0; y < game.Size; y++)
                {
                    Console.Write(game[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
