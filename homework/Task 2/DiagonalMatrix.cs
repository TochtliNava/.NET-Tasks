using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace homework._Task2
{
    public class DiagonalMatrix
    {
        private readonly int _size;
        private int[] _diagonal;
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

        public int GetSize()
        {
            return _size;
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
            if(matrix.GetSize() != _size)
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
