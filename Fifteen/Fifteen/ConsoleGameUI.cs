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

        public void Randomize()
        {
            game.Randomize();
        }

        public void Print()
        {
            game.Print();
        }

        public void Shift(int value)
        {
            game.Shift(value);
        }

        public bool IsFinished()
        {
            return game.IsFinished();
        }
    }
}
