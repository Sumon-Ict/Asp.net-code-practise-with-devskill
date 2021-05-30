using System;
using System.IO;

namespace FinalizerExample
{
    class First : IDisposable
    {
        private FileStream file;

        public First()
        {
            file = new FileStream("", FileMode.Open);
        }
        ~First()
        {
            file?.Dispose();
            Console.WriteLine("First's destructor is called.");
        }

        public void Dispose()
        {
            file?.Dispose();
        }
    }

    class Second : First
    {
        ~Second()
        {
            Console.WriteLine("Second's destructor is called.");
        }
    }

    class Third : Second
    {
        ~Third()
        {
            Console.WriteLine("Third's destructor is called.");
        }
    }

    /*
    Finalizers cannot be defined in structs. They are only used with classes.
    A class can only have one finalizer.
    Finalizers cannot be inherited or overloaded.
    Finalizers cannot be called. They are invoked automatically.
    A finalizer does not take modifiers or have parameters.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Third t = new Third();
        }
    }
}
