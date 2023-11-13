namespace homework._Task2
{
    public class DiagonalMatrix
    {
        private readonly int _size;
        private int[] _diagonal;

        public int Size { get { return _size; } }
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

        public int GetElement(int i, int j)
        {
            int element = 0;
            if (i < Size && j < Size)
            {
                element = i == j ? _diagonal[i] : 0;
                return element;
            }
            return element;
        }

        public override string ToString()
        {
            string print = "";
            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    print += x != y ? 0 : _diagonal[x];
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
    }
}
