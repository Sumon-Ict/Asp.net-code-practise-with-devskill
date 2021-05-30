using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Examples.Collections.SortedListExample
{
    public class SortedListExampleRunner
    {
        public string Name => nameof(SortedListExampleRunner);

        public void Run()
        {
            // Creates and initializes a new SortedList.
            var mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            Console.WriteLine("  Keys and Values:");
            for (int i = 0; i < mySL.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL.GetByIndex(i));
            }
        }
    }
}
