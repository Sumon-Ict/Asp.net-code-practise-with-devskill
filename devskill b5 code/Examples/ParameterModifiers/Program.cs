using System;

namespace ParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inVariable = 9;
            InExample(in inVariable);

            Console.WriteLine("In Variable Value: " + inVariable);

            var outVariable = 7;
            OutExample(out outVariable);
            Console.WriteLine("Out Variable Value: " + outVariable);

            var refVariable1 = 11;
            var refVariable2 = 31;

            RefExample(ref refVariable1);
            Console.WriteLine("Ref Variable 1 Value: " + refVariable1);

            RefExample2(ref refVariable2);
            Console.WriteLine("Ref Variable 2 Value: " + refVariable2);

        }

        public static void InExample(in int x)
        {
            //x = 5; // can't be done. in parameter can't be changed
        }

        public static void OutExample(out int x)
        {
            x = 5; // must be changed. Otherwise error
        }

        public static void RefExample(ref int x)
        {
            // not changing is ok, changing x is also ok
        }

        public static void RefExample2(ref int x)
        {
            x = 3;
            // not changing is ok, changing x is also ok
        }
    }
}
