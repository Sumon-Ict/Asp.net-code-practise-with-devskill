using System;

namespace Answer4
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var array = new int[size, size];

            for(var i = 0; i < size; i++)
            {
                for(var j = 0; j < size; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            var leftDiagonalSum = 0;
            var rightDiagonalSum = 0;
            for(var i = 0; i < size; i++)
            {
                leftDiagonalSum += array[i, i];
                rightDiagonalSum += array[i, size - 1 - i];
            }

            Console.WriteLine($"Left Diagonal: {leftDiagonalSum}, Right Diagonal: {rightDiagonalSum}");
        }
    }
}
