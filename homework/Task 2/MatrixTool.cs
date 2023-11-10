using homework._Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Task_2
{
    static public class MatrixTool
    {
        public static DiagonalMatrix SumDiagonals(this DiagonalMatrix matrix1, DiagonalMatrix matrix2)
        {
            int size = matrix1.GetSize() > matrix2.GetSize() ? matrix1.GetSize() : matrix2.GetSize();
            int[] diagonal = new int[size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (x == y)
                    {
                        diagonal[x] = matrix1.GetElement(x, y) + matrix2.GetElement(x, y);
                    }
                }
            }

            return new DiagonalMatrix(diagonal);
        }
    }
}
