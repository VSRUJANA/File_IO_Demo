using System;

namespace File_IO_OperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIO_Operations fileIO = new FileIO_Operations();
            Console.WriteLine("Check whether File exists");
            fileIO.FileExists();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ReadAllLines Method");
            fileIO.ReadAllLines();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ReadAllText Method");
            fileIO.ReadAllText();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("CopyFile Method");
            fileIO.CopyFile();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("DeleteFile Method");
            fileIO.DeleteFile();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Reading file from StreamReader");
            fileIO.ReadFileFromStreamReader();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Write file using StreamWriter");
            fileIO.WriteFileUsingStreamWriter();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Binary Serialisation and Deserialisation");
            BinarySerialisationAndDeserialisation binarySerialisationAndDeserialisation = new BinarySerialisationAndDeserialisation();
            binarySerialisationAndDeserialisation.BinarySerialization();
            binarySerialisationAndDeserialisation.BinaryDeserialization();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("XML Serialisation and Deserialisation");
            XMLSerializationDeserialization xmlSerializationDeserialization = new XMLSerializationDeserialization();
            xmlSerializationDeserialization.XmlSerialization();
            xmlSerializationDeserialization.XmlDeserialization();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Json Serialisation and Deserialisation");
            JsonSerializationDeserialization jsonSerializationDeserialization = new JsonSerializationDeserialization();
            jsonSerializationDeserialization.JsonSerialization();
            jsonSerializationDeserialization.JsonDeserialization();
        }
    }
}
