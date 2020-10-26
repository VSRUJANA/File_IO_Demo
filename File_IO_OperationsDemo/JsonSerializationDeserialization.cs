using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace File_IO_OperationsDemo
{
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

    }

    class JsonSerializationDeserialization
    {
        public void JsonSerialization()
        {
            BlogSites blogSites = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome to Universe"
            };
            string jsonData = JsonConvert.SerializeObject(blogSites);
            Console.WriteLine(jsonData);
        }

        public void JsonDeserialization()
        {
            string jsonData = @"{
                                 'Name': 'Sam',
                                 'Description' :'Welcome to Universe'
                                }";
            BlogSites blogSites = JsonConvert.DeserializeObject<BlogSites>(jsonData);
            Console.WriteLine(blogSites.Name);
            Console.WriteLine(blogSites.Description);
        }
    }
}
