using System;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to File IOOperation!!");
            Serializationanddeserialization operation = new Serializationanddeserialization();
            //operation.BinarySerialization();
            operation.BinaryDeSerialization();
            Console.Read();
            
        }
    }
}
