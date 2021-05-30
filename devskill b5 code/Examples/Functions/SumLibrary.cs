using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class SumLibrary
    {
        public int SimpleSum(List<int> items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }

        public int MultiSum(List<int> items)
        {
            var multiSum = 0;
            foreach (var item in items)
            {
                multiSum += item * item;
            }
            return multiSum;
        }
    }
}
