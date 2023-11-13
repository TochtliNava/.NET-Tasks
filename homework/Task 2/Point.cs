using System;

namespace homework._Task2
{
    public class Point
    {
        private int[] _coordinates = new int[3];
        private double _mass = 0;

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

        public double GetMass()
        {
            return _mass;
        }

        public int GetCoordinateX()
        {
            return _coordinates[0];
        }
        public int GetCoordinateY()
        {
            return _coordinates[1];
        }

        public int GetCoordinateZ()
        {
            return _coordinates[2];
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
            double distance = Math.Pow(Convert.ToDouble(point.GetCoordinateX()) - Convert.ToDouble(GetCoordinateX()), Convert.ToDouble(2)) +
                              Math.Pow(Convert.ToDouble(point.GetCoordinateY()) - Convert.ToDouble(GetCoordinateY()), Convert.ToDouble(2)) +
                              Math.Pow(Convert.ToDouble(point.GetCoordinateZ()) - Convert.ToDouble(GetCoordinateZ()), Convert.ToDouble(2));
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
