﻿using System;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            GenericDiagonalMatrix<int> matrix = new GenericDiagonalMatrix<int>(4);
            GenericDiagonalMatrix<int> matrix2 = new GenericDiagonalMatrix<int>(4);
            matrix[3, 3] = 3;
            matrix[1, 3] = 4;
            matrix[4, 7] = 2;   // Nothing
            //int valor = matrix[5, 7];   // Error
            matrix2[1, 1] = 5;
            matrix2[3, 3] = 5;

            //  Extension Method
            Func<int, int, int> addFunction = (a, b) => a + b;
            GenericDiagonalMatrix<int> result = matrix.Add(matrix2, addFunction);

            //  Undo Method
            MatrixTracker<int> matrixTracker = new MatrixTracker<int>(matrix);
            matrix[3, 3] = 8;
            matrixTracker.Undo();

            RationalNumber fraction = new RationalNumber(-2, 6); // Should be 1/3
            RationalNumber rational = new RationalNumber(2, 8);

            bool isSame = fraction.Equals(rational);  //  False
            Console.WriteLine(fraction);
            int comparation = fraction.CompareTo(rational);

            RationalNumber resultFraction = (fraction + rational);
            resultFraction = (fraction - rational);
            resultFraction = (fraction * rational);
            resultFraction = (fraction / rational);

            double rationalNumber = ((double)fraction);
            RationalNumber implicitNumber = 3;
        }
    }
}
