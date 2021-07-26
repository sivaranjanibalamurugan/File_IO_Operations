using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileIOOperations
{
    class Operations
    {
        //method to check existance of a file
        public static void FileExits(String filePath)
        {
            if(File.Exists(filePath))
            {
                Console.WriteLine("file exists");
            }
            else
            {
                Console.WriteLine("file not found");
            }

        }
        public static void ReadAllLines(String filePath)
        {
            string[] lines;
            lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        public static void ReadAllText(string filePath)
        {
            string text;
            text = File.ReadAllText(filePath);
            Console.WriteLine("{0}", text);
        }
        public static void FileCopy(string InputFile, string OutputFile )
        {
            File.Copy(InputFile, OutputFile);
            Console.WriteLine("File is copied");
        }
        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("the file has been deleted");
        }
        public static void ReadfromStreamReader(string filePath)
        {
            StreamReader sr = File.OpenText(filePath);
            string text = "";
            while((text = sr.ReadLine())!=null)
            {
                Console.WriteLine(text);
            }
        }
        public static void WriteusingStreamWriter(string filePath)
        {
            using (StreamWriter sr = File.AppendText(filePath))
            {
               
                sr.WriteLine("happy to learn");
                sr.Close();
            }
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}
