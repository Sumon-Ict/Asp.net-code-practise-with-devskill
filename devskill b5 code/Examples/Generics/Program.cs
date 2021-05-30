using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box<int>();
            var box2 = new Box<double>();

            box1.Width = 22;
            box2.Width = 22.5;

            var storage = new Storage<string>(5);
            storage.PutItem(1, "hello");
            storage.PutItem(2, "world");

            var storage2 = new Storage<int>(9);
            storage2.PutItem(1, 1);
            storage2.PutItem(2, 5);
            storage2.PutItem(3, 9);
            storage2.PutItem(4, 2);
            storage2.PutItem(5, 7);
            storage2.PutItem(7, 12);

            var storage3 = new Storage<bool>(3);
            storage3.PutItem(1, true);
            storage3.PutItem(2, false);

            Console.WriteLine(storage2.GetItem(3));
        }
    }
}
