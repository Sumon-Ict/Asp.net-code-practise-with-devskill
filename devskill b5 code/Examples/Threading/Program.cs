using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Thread(PrintUsingThread.thread1);
            var b = new Thread(PrintUsingThread.thread2);
            a.Start();
            b.Start();

            
            var obj = new PrintUsingThread();

            var thr1 = new Thread(new ThreadStart(obj.threadA));
            thr1.Start();

            var thr2 = new Thread(new ThreadStart(obj.threadB));
            thr2.Start();

            List<Task> tasks = new List<Task>();
            tasks.Add(obj.TestAnother());
            tasks.Add(obj.TestAnother());
            Task.WaitAll(tasks.ToArray());
        }
    }
}
