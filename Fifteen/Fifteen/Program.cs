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
            Game2 game2 = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);
            Game2 game3 = new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0);

            ConsoleGameUI game = new ConsoleGameUI(game2);
            game.Play();

            game = new ConsoleGameUI(game3);
            game.Play();
        }
    }
}


