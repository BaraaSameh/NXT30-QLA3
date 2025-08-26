using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    internal class Matrix
    {
        int[,] data;
        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }
       public int this[int row, int col]
        {
            get => data[row, col];
            set => data[row, col] = value;
        }
    }
}
