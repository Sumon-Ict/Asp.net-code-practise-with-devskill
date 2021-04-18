using System;

namespace Action
{
    class Program
    {

       // public delegate void mydl(string s);

        static void Main(string[] args)
        {

            //var dl = new mydl(printmethod);

            var text = "my message";
           // dl(text);

            printprocess(text, printmethod);   // both are same work but in here contain logic 

        }

        static void  printmethod(string s)
        {
            Console.WriteLine(" delegate example {0}", s);

        }

        static void printprocess(string s,Action<string>dl)   // action is used when return type only void  otherwise  used fuction 
        {
            if(!string.IsNullOrWhiteSpace(s))
            {
                dl(s);

            }
        }
    }
}
