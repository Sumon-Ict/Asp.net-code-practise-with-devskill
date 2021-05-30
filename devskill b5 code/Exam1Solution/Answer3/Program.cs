using System;

namespace Answer3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[100];
            var count = 0;
            while(true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;

                numbers[count++] = int.Parse(line);
            }

            var reversed = new int[count];
            foreach(var item in numbers)
            {
                if (count == 0)
                    break;

                reversed[--count] = item;
            }

            var odds = new int[(reversed.Length / 2) + (reversed.Length % 2)];
            var evens = new int[(reversed.Length / 2)];

            for(var i = 0; i < reversed.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    evens[i / 2] = reversed[i];
                else
                    odds[i / 2] = reversed[i];
            }

            for(var i = 0; i < odds.Length / 2; i++)
            {
                var temp = odds[i];
                odds[i] = odds[odds.Length - 1 - i];
                odds[odds.Length - 1 - i] = temp;

                temp = evens[i];
                evens[i] = evens[evens.Length - 1 - i];
                evens[evens.Length - 1 - i] = temp;
            }

            foreach(var odd in odds)
            {
                Console.Write(odd + " ");
            }

            Console.WriteLine();

            foreach (var even in evens)
            {
                Console.Write(even + " ");
            }
        }
    }
}
