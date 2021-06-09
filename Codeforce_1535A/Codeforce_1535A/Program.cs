using System;
using System.Linq;

namespace Codeforce_1535A
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {


                var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var a = Math.Max(array[0], array[1]);

                var b = Math.Max(array[2], array[3]);



                Array.Sort(array);

                var sum = array[2] + array[3];

                if (sum == a + b)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");

                }

            }


        }
    }
}
