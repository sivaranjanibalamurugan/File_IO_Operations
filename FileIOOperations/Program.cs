using System;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to File IOOperation!!");
            String filePath = @"C:\Users\user\source\repos\FileIOOperations\FileIOOperations\textfile.txt";
            string OutputPath = @"C:\Users\user\source\repos\FileIOOperations\FileIOOperations\textfilee1.txt";
            Operations.FileExits(filePath);
            Operations.ReadAllLines(filePath);
           // Operations.ReadAllText(filePath);
            //Operations.ReadfromStreamReader(filePath);
            Operations.WriteusingStreamWriter(filePath);
            Console.Read();
        }
    }
}
