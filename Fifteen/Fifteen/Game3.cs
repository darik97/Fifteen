﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Game3 : Game2
    {
        public readonly Stack<int> History;

        public Game3(params int[] values) : base(values)
        {
            History = new Stack<int>();
        }

        public override void Shift(int value)   
        {
            if (value > 0 && value < Arr.Length)
            {
                History.Push(value);
            }
            base.Shift(value);
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

