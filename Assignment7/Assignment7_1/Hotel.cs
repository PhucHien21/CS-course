using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment7_1
{
    [XmlRoot("hotel")]
    public class Hotel
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("constructionDate")]
        public string ConstructionDate { get; set; }
        [XmlElement("address")]
        public string Address { get; set; }
        [XmlElement("numberOfStars")]
        public int NumberOfStars { get; set; }
        [XmlIgnore]
        public List<Room> Rooms { get; set; }
        [XmlIgnore]
        public List<Customer> Customers { get; set; }
        public Hotel() { }
        public Hotel(string name, string constructionDate, string address, int numberOfStars, List<Room> rooms, List<Customer> customers)
        {
            Name = name;
            ConstructionDate = constructionDate;
            Address = address;
            NumberOfStars = numberOfStars;
            Rooms = rooms;
            Customers = customers;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Hotel: {0}\nConstruction Date: {1}\nAddress: {2}\nNumber of Stars: {3}",
                Name, ConstructionDate, Address, NumberOfStars));
            /*sb.Append("\n\nList of Rooms: ");
            foreach (Room r in Rooms) sb.Append(r.ToString());
            sb.Append("\n\nList of Customers: ");
            foreach (Customer c in Customers) sb.Append(c.ToString());*/
            return sb.ToString();
        }
    }
}
