using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment7_1
{
    [XmlRoot("room")]
    public class Room
    {
        [XmlElement("roomNumber")]
        public int RoomNumber { get; set; }
        [XmlElement("area")]
        public string Area { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
        [XmlElement("pricePerNight")]
        public double PricePerNight { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        public Room() { }
        public Room(int roomNumber, string area, string type, double pricePerNight, string description)
        {
            RoomNumber = roomNumber;
            Area = area;
            Type = type;
            PricePerNight = pricePerNight;
            Description = description;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\n\n\tRoom's Number: {0}\n\tArea: {1}\n\tType: {2}\n\tPrice per night: {3}\n\tDescription: {4}",
               RoomNumber, Area, Type, PricePerNight, Description));
            return sb.ToString();
        }
    }
}
