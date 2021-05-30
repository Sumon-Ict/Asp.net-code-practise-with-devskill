using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class Example1
    {
        public void PrintResult(List<int> items, Func<List<int>, int> calculator)
        {
            var result = calculator(items);
            Console.WriteLine(result);
        }
    }
}
