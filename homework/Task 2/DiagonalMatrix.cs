using System;

namespace homework._Task2
{
    public class DiagonalMatrix : ICloneable
    {
        private readonly int _size;
        private int[] _diagonal;

        public int Size { get { return _size; } }
        public int this[int x, int y]
        {
            get
            {
                if (x < Size &&  y < Size)
                {
                    return x == y? _diagonal[x] : 0;
                }
                return 0;
            }
            set
            {
                if (x < Size && y < Size)
                {
                    _diagonal[x] = value;
                }
            }
        }


        public DiagonalMatrix(int[] diagonal) 
        {
            if (diagonal != null)
            {
                _size = diagonal.Length;
                _diagonal = diagonal;
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach(int value in _diagonal)
            {
                sum += value;
            }
            return sum;
        }

        public override string ToString()
        {
            string print = "";
            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    print += this[x, y];
                    print += " ";
                }
                print += "\n";
            }
            return print;
        }

        public override bool Equals(object obj)
        {
            var matrix = obj as DiagonalMatrix;
            if(matrix.Size != _size)
            {
                return false;
            }
            for (int index = 0; index < _size; index++)
            {
                if (_diagonal[index] != matrix._diagonal[index])
                {
                    return false;
                }
            }
            return true;
        }

        public object Clone()
        {
            int[] diagonal = new int[Size];
            DiagonalMatrix clone = new DiagonalMatrix(diagonal);
            for (int i = 0; i < _size; i++)
            {
                clone[i, i] = _diagonal[i];
            }
            return clone;
        }
    }
}
