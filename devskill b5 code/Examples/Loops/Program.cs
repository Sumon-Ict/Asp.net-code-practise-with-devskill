using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region While Loop
            int x = 10;
            while(x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
            #endregion

            #region Do While Loop
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a < 10);
            #endregion

            #region Foreach Loop
            int[] p = new int[10];

            foreach(int t in p)
            {
                Console.WriteLine(t);
            }

            #endregion
        }
    }
}
