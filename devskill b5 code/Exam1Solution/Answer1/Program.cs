using System;

namespace Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometry = new Geometry();
            var triangle = new Triangle
            {
                Side1 = 10,
                Side2 = 20,
                Side3 = 30
            };

            var perimeter = geometry.CalculatePerimeter(triangle);
        }
    }
}
