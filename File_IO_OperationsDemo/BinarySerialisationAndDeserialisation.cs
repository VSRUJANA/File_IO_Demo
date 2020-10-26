using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace File_IO_OperationsDemo
{
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public string ApplicationId { get; set; } = "1001";
    }
    public class BinarySerialisationAndDeserialisation
    {
        string path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sampleForBinary.txt";
        public void BinarySerialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, sample);
            fileStream.Close();
            Console.ReadKey();
        }
        public void BinaryDeserialization()
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName { deserializedSampledemo.ApplicationName} --- ApplicationId{ deserializedSampledemo.ApplicationId}");
            Console.ReadKey();
        }
    }
}