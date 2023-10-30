using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class AirlineCompany
    {
        private readonly string airlineName;
        private List<Flight> flights = new List<Flight>();
        public string AirlineName
        {
            get { return airlineName; }
        }
        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
        }
        public Flight this[int index]
        {
            set
            {
                flights.Insert(index, value);
            }
            get
            {
                return flights[index];
            }
        }
        public int Count()
        {
            return flights.Count;
        }
        public string FindFLight(int flightId)
        {
            string str = "";
            foreach (Flight f in flights)
            {
                str += f.FindFlight(flightId);
            }
            if (string.IsNullOrEmpty(str))
            {
                str = "Flight not found!";
            }
            return str;
        }
    }
}
