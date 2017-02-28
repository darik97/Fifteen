using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Cell
    {
        public readonly int Length;
        private int[ , ] cell;

        public Cell(int Size)
        {
            cell = new int[Size, Size];
            Length = Size;
        }

        public int this[int x, int y]
        {
            get
            {
                return cell[x, y];
            }
            set
            {
                cell[x, y] = value;
            }
        }
    }
}
