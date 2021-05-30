using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaMethod
{
    public class Math
    {
        public int Addition(int a, int b) => a > 5 ? a + b : a - b;

        public int Subtraction(int a, int b) => a - b;

        public void Print(int number) => Console.WriteLine(number);
    }
}
