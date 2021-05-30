using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    public class Math
    {
        public double Average(params int[] items)
        {
            var sum = 0.0;
            foreach(var item in items)
            {
                sum += item;
            }

            return sum / items.Length;
        }
    }
}
