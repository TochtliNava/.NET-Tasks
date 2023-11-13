using homework._Task2;

namespace homework.Task_2
{
    static public class MatrixTool
    {
        public static DiagonalMatrix SumDiagonals(this DiagonalMatrix matrix1, DiagonalMatrix matrix2)
        {
            int size = matrix1.Size > matrix2.Size ? matrix1.Size : matrix2.Size;
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
