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
             for (int i = 0; i < ran.Next(50, 120); i++)
             {
                 var p1 = GetLocation(ran.Next(0, Arr.Length - 1));
                 var p2 = GetLocation(ran.Next(0, Arr.Length - 1));
                 Change(p1, p2);
             }
        }

        public bool IsWin()
        {
            int k = 1;
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (k == Size * Size)
                        k = 0;
                    if (Matrix[x, y] != k)
                        return false;
                    k++;
                }
            }
            return true;
        }
    }
}
