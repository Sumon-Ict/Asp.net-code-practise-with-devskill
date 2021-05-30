using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            Sum(2, 3, out result);

            Console.WriteLine(result);
        }

        public static void Sum(int a, int b, out int r)
        {
            r = a + b;
        }
    }
}
