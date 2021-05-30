using System;
using System.Collections.Generic;
using System.Text;

namespace Answer1
{
    class Geometry
    {
        public double CalculateArea(Shape shape)
        {
            if (shape is Circle)
            {
                var circle = shape as Circle;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                return rectangle.Width * rectangle.Height;
            }
            else if (shape is Triangle)
            {
                var triangle = shape as Triangle;
                var p = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;
                return Math.Sqrt(p * (p - triangle.Side1) * (p - triangle.Side2) * (p - triangle.Side3));
            }
            else
                throw new InvalidOperationException("Shape not supported");
        }

        public double CalculatePerimeter(Shape shape)
        {
            if (shape is Circle)
            {
                var circle = shape as Circle;
                return 2 * Math.PI * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                return 2 * (rectangle.Width + rectangle.Height);
            }
            else if (shape is Triangle)
            {
                var triangle = shape as Triangle;
                return triangle.Side1 + triangle.Side2 + triangle.Side3;
            }
            else
                throw new InvalidOperationException("Shape not supported");
        }
    }
}
