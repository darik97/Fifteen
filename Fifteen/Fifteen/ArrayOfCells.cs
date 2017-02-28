using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class ArrayOfCells
    {
        private int[,] cell;

        public ArrayOfCells(int size)
        {
            cell = new int[size, size];
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
