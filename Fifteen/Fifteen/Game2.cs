using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game2 : Game
    {
        public Game2(params int[] values) : base(values) { }

        public void Rand()
        {
             Random ran = new Random();
             for (int i = 0; i < 9999; i++)
             {
                 base.Shift(ran.Next(1, Arr.Length - 1));
             }
        }

        public bool IsWin()
        {
            int k = 1;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (Matrix[x, y] != k && k < Size * Size)
                        return false;
                    k++;
                }
            }
            return true;
        }
    }
}
