using System;
using System.Collections.Generic;

namespace Task_02
{
    public static class SmartSort
    {
        public delegate int Compare<T>(T a, T b);

        public static IList<T> Sort<T>(this IList<T> elements, Compare<T> compare)
        {
            throw new NotImplementedException();

        }
    }

    class Program
    {

       static int mycompre(string a,string b)
        {
            return a.CompareTo(b);

        }
        static void Main(string[] args)
        {
            IList<string> list = new List<string> { "sumon", "suon", "kajol" };

            list = list.Sort<string>(mycompre);

        }

    }
}
