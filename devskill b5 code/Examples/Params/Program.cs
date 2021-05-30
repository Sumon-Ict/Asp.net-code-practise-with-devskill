using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Math();
            var x = math.Average(2, 3);
            var y = math.Average(2, 3, 4);
            var y2 = math.Average(2, 3, 4, 5, 6, 7, 8, 9);
            var z = math.Average(new int[] { 2, 3, 4, 5 });
        }
    }
}
