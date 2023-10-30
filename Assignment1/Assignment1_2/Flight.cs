using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Flight
    {
        private int id;
        private string origin;
        private string destination;
        private string date;

        public Flight(int id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public int getId()
        {
            return id;
        }

        public string toString()
        {
            string str = "";
            str += "\n\tID: " + id + "\n\tOrigin: " + origin + "\n\tDestination: " + destination + "\n\tDate: " + date;
            return str;
        }
    }
}
