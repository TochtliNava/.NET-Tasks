using System;

namespace Task_4
{
    internal class MatrixTracker<T>
    {
        private GenericDiagonalMatrix<T> _matrix;
        private int _index;
        private T _oldValue;
        public MatrixTracker(GenericDiagonalMatrix<T> matrix) 
        {
            _matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
            matrix.ElementChanged += Matrix_ElementChanged;
        }

        private void Matrix_ElementChanged(int index, T oldValue)
        {
            _index = index;
            _oldValue = oldValue;
        }

        public void Undo() 
        {
            _matrix[_index, _index] = _oldValue;
        }
    }
}
