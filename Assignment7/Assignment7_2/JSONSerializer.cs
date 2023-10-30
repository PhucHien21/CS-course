using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Assignment7_2
{
    class JSONSerializer
    {
        public JSONSerializer() { }
        public string WriteToJSONFileHotel(Hotel hotel, string filePath)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Hotel), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, hotel);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";
        }

        public string WriteToJSONFileRoom(List<Room> rooms, string filePath)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Room>), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, rooms);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";

        }

        public string WriteToJSONFileCustomer(List<Customer> customers, string filePath)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();
            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.MaxItemsInObjectGraph = 1000;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);

            FileStream fileWriter = new FileStream(filePath, FileMode.Create);

            jsonSerializer.WriteObject(fileWriter, customers);
            fileWriter.Close();
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
                return fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length;
            return filePath + " does not exist!";

        }

        public Hotel ReadFromJSONFileHotel(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Hotel>(jsonData);
        }

        public List<Room> ReadFromJSONFileRoom(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<List<Room>>(jsonData);
        }

        public List<Customer> ReadFromJSONFileCustomer(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string jsonData = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<List<Customer>>(jsonData);
        }
    }
}