using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_2
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public int RoomNumber { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double PricePerNight { get; set; }
        [DataMember]
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
