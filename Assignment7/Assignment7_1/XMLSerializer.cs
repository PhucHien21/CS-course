//This is XMLSerializer.cs file
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment7_1
{
    public class XMLSerializer
    {
        public XMLSerializer() { }
        public string WriteXML<T>(T type, string filePath)
        {
            StringBuilder feedback = new StringBuilder();
            feedback.AppendLine("Provided data is invalid!");

            if (type == null)
                return feedback.ToString();

            XmlSerializer xmlSerializer = new XmlSerializer(type.GetType());

            XmlWriter xmlWriter = XmlWriter.Create(filePath,
                                          new XmlWriterSettings()
                                          {
                                              OmitXmlDeclaration = true, 
                                              ConformanceLevel = ConformanceLevel.Auto,
                                              Indent = true

                                          });

            xmlSerializer.Serialize(xmlWriter, type);

            xmlWriter.Close();

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                feedback.Clear();
                feedback.AppendLine(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            }
            return feedback.ToString();
        }

        public T ReadXML<T>(string filePath)
        {
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}