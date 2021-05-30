using System;
using System.IO;

namespace DirectoryOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileLocation = directory.Parent.Parent.Parent.FullName;
            var filePath = Path.Combine(fileLocation, "sample.txt");

            //File.WriteAllText(filePath, "hello"); 

            var files = directory.Parent.Parent.Parent.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} - {file.Length}");
            }
            
        }
    }
}
