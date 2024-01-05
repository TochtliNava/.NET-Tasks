using System;

namespace Task_4
{
    internal static class GenericDiagonalMatrixExtensions
    {
        public static GenericDiagonalMatrix<T> Add<T>(this GenericDiagonalMatrix<T> matrixA, GenericDiagonalMatrix<T> matrixB, Func<T, T, T> addDelegateFunction)
        {
            matrixA = matrixA ?? throw new ArgumentNullException(nameof(matrixA));
            matrixB = matrixB ?? throw new ArgumentNullException(nameof(matrixB));
            addDelegateFunction = addDelegateFunction ?? throw new ArgumentNullException("Function must be provided");
            if (matrixA.Size != matrixB.Size)
            {
                throw new ArgumentException("Both matrices must be the same size");
            }
            GenericDiagonalMatrix<T> matrix = new GenericDiagonalMatrix<T>(matrixA.Size);

            for (int i = 0; i < matrixA.Size; i++)
            {
                matrix[i, i] = addDelegateFunction(matrixA[i, i], matrixB[i, i]);
            }

            return matrix;
        }
    }
}
