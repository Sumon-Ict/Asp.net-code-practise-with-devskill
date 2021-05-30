using System;
using System.Linq.Expressions;

namespace ExpressionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(x => x > 5);
            Test2(x => x > 5);
        }

        static void Test(Expression<Func<int, bool>> expr)
        {
            Func<int, bool> deleg = expr.Compile();
            Console.WriteLine("deleg(4) = {0}", deleg(4));
            Console.WriteLine();
        }

        static void Test2(Func<int, bool> f)
        {
            Console.WriteLine("deleg2(4) = {0}", f(4));
        }
    }
}
