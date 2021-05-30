using System;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {

            #region File Read

            var filePath = @"C:\Training\csharp-b5\Examples\FileOperation\Sample.txt";

            if(File.Exists(filePath))
            {
                var text = File.ReadAllText(filePath);
                Console.WriteLine(text);

                var lines = File.ReadAllLines(filePath);
                foreach(var line in lines)
                {
                    Console.WriteLine($"--{line}--");
                }

                //File.Create(@"C:\Training\csharp-b5\Examples\FileOperation\newFile.txt");

                File.Delete(@"C:\Training\csharp-b5\Examples\FileOperation\newFile.txt");
            }

            var file = new FileInfo(filePath);
            if(file.Exists)
            {
                var reader = file.OpenText();
                string line = null;
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine($"=={line}==");
                } while (line != null);
            }

            #endregion

            #region File Write

            var writeFilePath = @"C:\Training\csharp-b5\Examples\FileOperation\SampleWrite.txt";
            var content = "Hello from Bangladesh!";
            File.WriteAllText(writeFilePath, content);

            using var writer = File.OpenWrite(writeFilePath);
            var bytes = Encoding.ASCII.GetBytes(content);
            writer.Write(bytes);

            FileInfo fileInfo = new FileInfo(writeFilePath);
            Console.WriteLine(fileInfo.Length);

            #endregion
        }

    }
}
