using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var design1 = new PuzzleDesign1();
            var designer = new PuzzleMaker.Design(design1.Print);

            var puzzleMaker = new PuzzleMaker();
            puzzleMaker.GeneratePuzzle(designer, 5, 5);
        }

        public static void DoPrint(int x, int y)
        {
            Console.WriteLine("Testing");
        }
    }
}
