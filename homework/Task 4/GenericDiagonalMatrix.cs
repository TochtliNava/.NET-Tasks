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
                if (x < Size && y < Size && x >= 0 && y >= 0)
                {
                    return x == y ? _diagonal[x] : default;
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set 
            {
                if (x < Size && y < Size && x >= 0 && y >= 0 && x == y)
                {
                    T oldValue = _diagonal[x];
                    _diagonal[x] = value;
                    OnElementChanged(x, oldValue);
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

        public delegate void ElementChangedEventHandler(int index, T oldValue);
        public event ElementChangedEventHandler ElementChanged;
        private void OnElementChanged(int index, T oldValue)
        {
            ElementChanged?.Invoke(index, oldValue);
        }
    }
}
