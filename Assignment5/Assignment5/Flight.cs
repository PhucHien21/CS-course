using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Flight
    {
        private int id;
        private string origin;
        private string destination;
        private string date;
        public int Id
        {
            get { return id; }
        }
        public string Origin
        {
            get { return origin; }
        }
        public string Destination
        {
            get { return destination; }
        }
        public string Date
        {
            get { return date; }
        }
        public Flight()
        {
        }
        public Flight(int id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }
        public string GetFlight(int searchKey)
        {
            if (searchKey == Id)
            {
                return ToString();
            }
            return "";
        }
        public override string ToString()
        {
            string str = "";
            str += "\n\tFlight ID: " + Id;
            str += "\n\tFrom " + Origin + " to " + Destination ;
            str += "\n\tDate: " + Date;
            return str;
        }
    }
}
