using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 10;
            int c = 25;

            int x = 3;
            int y = 5;
            int z = 9;

            int average = Average(a, b, c);
            int average2 = Average(x, y, z);

            bool p = a + b > c;

            if(a + b > c || a < c && b > c)
            {
                Console.WriteLine("Greater");
            }
            else if(a + b < c)
            {
                Console.WriteLine("Smaller");
            }
            else if( a == c)
            {
                Console.WriteLine("a and c equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }

        static int Average(int num1, int num2, int num3)
        {
            int result = (num1 + num2 + num3) / 3;
            return result;
        }

    }
}
