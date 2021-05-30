using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class PrintUsingThread
    {
        public void threadA()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 1");
                Thread.Sleep(500);
            }
        }

        public void threadB()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 2");
                Thread.Sleep(500);
            }
        }

        public async Task<int> Test()
        {
            var x = 0;
            await Task.Run(() =>
            {
                for (int z = 0; z < 20; z++)
                {
                    Console.WriteLine("Printing from thread 2");
                    x++;
                }
            });

            return x;
        }

        public async Task TestAnother()
        {
            var x = await Test();
            Console.WriteLine($"X = {x}");
        }

        public static void thread1()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 1");
                Thread.Sleep(500);
            }
        }

        // static method for thread b 
        public static void thread2()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 2");
                Thread.Sleep(500);
            }
        }
    }
}
