using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericDiagonalMatrix<int> matrix = new GenericDiagonalMatrix<int>(4);
            matrix[3, 3] = 3;
            matrix[1, 3] = 4;
            matrix[4, 7] = 2;   // Nothing
            int valor = matrix[5, 7];   // Error
        }
    }
}
