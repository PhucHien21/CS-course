using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Customer
    {
        private string name;
        private int id;
        private int flightId;

        public Customer(string name, int id, int flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }

        public String getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }
    
        public int getFlightId()
        {
            return flightId;
        }
        public string toString()
        {
            string str = "";
            str += "\n\tName: " + name + "\n\tId: " + id + "\n\tFlight id: " + flightId;
            return str;
        }
    }
}
