using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PuzzleDesign1 : IPuzzleDesign
    {
        public void Print(int width, int height)
        {
            Console.WriteLine("============================");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("|                          |");
            Console.WriteLine("============================");
        }
    }
}
