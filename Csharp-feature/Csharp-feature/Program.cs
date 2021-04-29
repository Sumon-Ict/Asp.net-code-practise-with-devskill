using System;

namespace Csharp_feature
{
    class Program
    {

        delegate int mydelegate(int number, int number2);
        delegate double mydelegate2(int a, int b, int c);
        delegate void myd1(string s);

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
         


            mydelegate d = new mydelegate(sum);
            mydelegate d1 = new mydelegate(mul);

            var result2 = d1(34, 56);
            Console.WriteLine(result2);

            var result = d(12, 34);

            Console.WriteLine(result);

            myd1 d2 = new myd1(tostring);

            d2("sumon");


            DelegateExample de = new DelegateExample();
            mydelegate2 dl2 = new mydelegate2(de.volume);  // method passed from delegateexample class 

            var r = dl2(34, 45, 21);
            Console.WriteLine("the volume of the surface is {0}", r);

            mydelegate dl3 = new mydelegate(de.area);

            var result3 = dl3(23, 45);

            Console.WriteLine("the area of the surface is {0}",result3);

            var dl4 = new myd1(de.stringmethod);

            dl4("sumon");




        }
       

     

        static void tostring(string s)
        {
            Console.WriteLine("my name is {0}",s);

        }


        static int sum(int a, int b)
        {
            return a + b;
        }

        static int mul(int a,int b)
        {
            return a * b;
        }


    }
}
