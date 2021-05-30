using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region Example 1
    public struct Coords1
    {
        public Coords1(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }

    #endregion

    #region Example 2 - Readonly Struct
    public readonly struct Coords2
    {
        public Coords2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";


        // Readonly member
        public readonly double Sum()
        {
            return X + Y;
        }
    }

    #endregion
}
