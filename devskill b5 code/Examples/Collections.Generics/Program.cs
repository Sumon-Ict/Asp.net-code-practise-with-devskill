using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Collections.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("jalaluddin");
            names.Add("hasan");
            int length = names[0].Length;

            List<object> something = new List<object>();
            something.Add("jalaluddin");
            something.Add(23);

            string x = (string)something[0];
            int y = (int)something[1];

            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("item1", "abc");
            pairs.Add("item2", "def");


            HashSet<string> codes = new HashSet<string>();
            codes.Add("abc");
            codes.Add("def");

            Dictionary<string, string> d;
            HashSet<string> hs;
            LinkedList<string> ll;
            List<string> l;
            Queue<string> q;
            SortedDictionary<string, string> sd;
            SortedList<string, string> sl;
            SortedSet<string> ss;
            Stack<string> s;
        }
    }
}
