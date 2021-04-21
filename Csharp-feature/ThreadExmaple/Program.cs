using System;
using System.Threading;
using System.IO;


namespace ThreadExmaple
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

          // printmethod1();
            //printmethod2();
            //printmethod();
            /*
            Thread th1 = new Thread(printmethod1);
            th1.Start();

            var th2 = new Thread(new ThreadStart(printmethod2));

            th2.Start();

            Thread th = new Thread(printmethod);
            th.Start();
            */

            threadclass thread = new threadclass();

            var th3 = new Thread(new ThreadStart(thread.print1));
            th3.Start();

            var th4 = new Thread(new ThreadStart(thread.print2));
            th4.Start();

            var th5 = new Thread(new ThreadStart(writefile));
            th5.Start();

            var th6 = new Thread(writefile);
            th6.Start();
           
        }


        public static void writefile()
        {
            var path = @"H:\Asp.net code\Csharp-feature\ThreadExmaple\file.txt";

            lock (path)
            {

               File.WriteAllText(path, "hellow world");
               // File.AppendAllText(path, "hello world ");
            }
        }


        public static void printmethod1()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }

        public static void printmethod2()
        {
            for(int i=2;i<100;i=i+2)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);    

            }
        }
        public static void printmethod()
        {
            for(int i=100;i<200;i++)
            { Console.WriteLine(i);
                Thread.Sleep(100);
          }
        }

    }
}
