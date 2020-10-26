using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace File_IO_OperationsDemo
{
    public class OrderForm
    {
        public DateTime OrderDate;
    }

    class XMLSerializationDeserialization
    {
        String pathForXML = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sampleForXML.txt";
        public void XmlSerialization()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(pathForXML, FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dateTime = new DateTime(2020, 10, 23);
            orderForm.OrderDate = dateTime;
            xmlSerializer.Serialize(fileStream, orderForm);
            fileStream.Close();
        }

        public void XmlDeserialization()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(pathForXML, FileMode.Open);
            OrderForm orderForm = (OrderForm)xmlSerializer.Deserialize(fileStream);
            Console.WriteLine(orderForm.OrderDate);
        }
    }
}
