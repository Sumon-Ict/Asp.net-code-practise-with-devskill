using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PuzzleMaker
    {
        public delegate void Design(int width, int height);

        #region Hide
        public void GeneratePuzzle(Design design, int width, int height)
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
        #endregion
    }
}
