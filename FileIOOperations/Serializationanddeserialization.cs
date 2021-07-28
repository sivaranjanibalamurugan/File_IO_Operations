using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    class Serializationanddeserialization
    {
        //converting the object into the binary format
        public void BinarySerialization()
        {
            string path = @"C:\Users\user\source\repos\FileIOOperations\FileIOOperations\Binary text.txt";
            //creating the object for the personData
            PersonDetails data = new PersonDetails();
            data.name = "siva";
            data.age = 20;
            data.name = "bala";
            data.age = 31;
            //creating the stream for the file to write
            FileStream file = File.OpenWrite(path);
            //it convert the object into binary format
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
        }
        public void BinaryDeSerialization()
        {
            string path = @"C:\Users\user\source\repos\FileIOOperations\FileIOOperations\Binary text.txt";
            //creating the stream for the file to write
            FileStream file = File.OpenRead(path);
            BinaryFormatter Binary = new BinaryFormatter();
            //deserialize the binary format into object
            PersonDetails person = (PersonDetails)Binary.Deserialize(file);
            Console.WriteLine("Person detail");
            Console.WriteLine("Name:{0}  Age{1}", person.name, person.age);
        }
    }
}

