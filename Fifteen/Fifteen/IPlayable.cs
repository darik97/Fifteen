using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    interface IPlayable
    {
        void Randomize();
        void Shift(int value);
        bool IsFinished();
    }
}
