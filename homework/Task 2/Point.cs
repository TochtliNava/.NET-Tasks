using System;

namespace homework._Task2
{
    public class Point
    {
        private int[] _coordinates = new int[3];
        private double _mass = 0;

        public int X { get { return _coordinates[0]; } }
        public int Y { get { return _coordinates[1]; } }
        public int Z { get { return _coordinates[2]; } }
        public double Mass {  get { return _mass; } }
        
        public Point(int x, int y, int z, double mass)
        {
            _coordinates[0] = x;
            _coordinates[1] = y;
            _coordinates[2] = z;
            if (mass > 0)
            {
                _mass = mass;
            }
        }

        public bool IsZero()
        {
            foreach (var coordinate in _coordinates)
            {
                if (coordinate > 0)
                {
                    return false;
                }
            }
            return true;
        }

        // d = `/(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2
        public double CalculateDistance(Point point)
        {
            double distance = Math.Pow(Convert.ToDouble(point.X) - Convert.ToDouble(X), Convert.ToDouble(2)) +
                              Math.Pow(Convert.ToDouble(point.Y) - Convert.ToDouble(Y), Convert.ToDouble(2)) +
                              Math.Pow(Convert.ToDouble(point.Z) - Convert.ToDouble(Z), Convert.ToDouble(2));
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
