using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Room : IRoom
    {
        protected int roomNumber;
        protected string area;
        protected string type;
        protected double pricePerNight;
        protected string description;

        public int RoomNumber
        {
            get { return roomNumber; }
        }
        public string Area
        {
            get { return area; }
        }
        public string Type
        {
            get { return type; }
        }
        public double PricePerNight
        {
            get { return pricePerNight; }
        }
        public string Description
        {
            get { return description; }
        }
        public Room(int roomNumber, string area, string type, double pricePerNight, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.pricePerNight = pricePerNight;
            this.description = description;
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
