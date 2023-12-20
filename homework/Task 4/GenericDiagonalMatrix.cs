using System;

namespace Task_4
{
    internal class GenericDiagonalMatrix<T>
    {
        private T[] _diagonal;

        public int Size
        {
            get { return _diagonal.Length; }
        }

        public T this[int x, int y]
        {
            get
            {
                if ((x - 1) < Size && (y - 1) < Size && (x - 1) >= 0 && (y - 1) >= 0)
                {
                    return x == y ? _diagonal[x - 1] : default(T);
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set 
            {
                if ((x - 1) < Size && (y - 1) < Size && (x - 1) >= 0 && (y - 1) >= 0)
                {
                    _diagonal[x - 1] = x == y ? value : default(T);
                }
            }
        }

        public GenericDiagonalMatrix(int size)
        {
            if(size < 0)
            {
                throw new ArgumentException("The size can't be negative"); 
            }
            _diagonal = new T[size];
        }
    }
}
