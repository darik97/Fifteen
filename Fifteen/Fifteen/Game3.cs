using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game3 : Game2, IPlayable
    {
        public readonly Stack<int> History;

        public Game3(params int[] values) : base(values)
        {
            History = new Stack<int>();
        }

        public override void Randomize()
        {
            base.Randomize();
            History.Clear();
        }

        public override void Shift(int value)
        {
            if (value > 0 && value < Arr.Length)
            {
                base.Shift(value);
                History.Push(value);
            }
        }

        public void MakeStepsBack(int number)
        {
            if (number > History.Count)
            {
                number = History.Count;
            }
            for (int i = 0; i < number; i++)
            {
                base.Shift(History.Pop());
            }
        }
    }
}

