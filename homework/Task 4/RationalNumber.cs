using System;

namespace Task_4
{
    sealed internal class RationalNumber : IComparable<RationalNumber>
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }

            int gcd = GCD(numerator, denominator);
            Numerator = numerator / gcd;
            Denominator = Math.Abs(denominator / gcd);
        }

        public int GCD(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                int remainder = numerator % denominator;
                numerator = denominator;
                denominator = remainder;
            }

            return Math.Abs(numerator); // The final value of numerator is the GCD
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new RationalNumber(numerator, denominator);
        }

        public override string ToString() => $"{Numerator}/{Denominator}";

        public bool Equals(RationalNumber b)
        {
            return (b.Numerator == Numerator) && (b.Denominator == Denominator);
        }

        public int CompareTo(RationalNumber other)
        {
            return Numerator*other.Denominator.CompareTo(other.Numerator*Denominator);
        }

        public static explicit operator double(RationalNumber rational)
        {
            return (double)rational.Numerator / rational.Denominator;
        }

        public static implicit operator RationalNumber(int value)
        {
            return new RationalNumber(value, 1);
        }
    }
}

