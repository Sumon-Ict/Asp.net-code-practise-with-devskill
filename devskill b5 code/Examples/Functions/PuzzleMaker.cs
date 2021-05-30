using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class PuzzleMaker
    {
        public void GeneratePuzzle(Action<int, int> design, int width, int height)
        {
            Console.WriteLine("Hello from puzzle.\nWe are generating a puzzle");

            Console.WriteLine("Printing puzzle");

            design(width, height);

            Console.WriteLine("Done.");
        }

        private void StartPuzzle()
        {
            Console.WriteLine("Starting puzzle game");
        }
    }
}
