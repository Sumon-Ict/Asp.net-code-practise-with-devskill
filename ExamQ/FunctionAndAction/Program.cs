using System;

namespace FunctionAndAction
{
    class Program
    {

        delegate void mydl(string str);

        static void delmethod(string str)
        {
            Console.WriteLine($"the delegate method string is {str}");

        }

        delegate int mydl2(int x, int y);


        static Action<string> exam1 = x => Console.WriteLine(x);   
        
            

        static void Main(string[] args)
        {

            


            mydl2 mydelegate2 = new mydl2(example4);

            var res2 = mydelegate2(23, 89);
            Console.WriteLine($"the multiplicatinn of two integer by fucton and delegate {res2}");




            mydl dl3 = new mydl(exam1);
            dl3("sarafat");




            mydl dl = new mydl(delmethod);
            dl("sumon");

            mydl dl2 = delmethod;    //same work 
            dl2("sujon");



            var result = example3("sumon", "sujon");
            Console.WriteLine(result);

            example1("sumon");
            example2("sumon", "sujon");
            var r4 = example4(12, 34);

            Console.WriteLine(r4);

        }
        static Action<string> example1 = x => Console.WriteLine($"the string is {x}");

        static Action<string, string> example2 = (x, y) => Console.WriteLine($"the two string value is {x} ans {y}");
        static Func<string, string, string> example3 = (x, y) => (x + y);

        static Func<int, int, int> example4 = (x, y) => (x * y);

       
    }
}
