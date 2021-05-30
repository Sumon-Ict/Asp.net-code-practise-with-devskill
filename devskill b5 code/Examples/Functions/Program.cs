using System;
using System.Collections.Generic;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleMaker = new PuzzleMaker();
            puzzleMaker.GeneratePuzzle(new PuzzleDesign2().Print, 5, 5);

            var example = new Example1();
            example.PrintResult(new List<int> { 1, 2, 3 }, new SumLibrary().MultiSum);
        }
    }
}
