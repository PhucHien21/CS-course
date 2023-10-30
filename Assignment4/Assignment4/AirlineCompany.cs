using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public delegate string FindFlightDelegate(int id);

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
        public string CompareFlightPrice(FindFlightDelegate findFlightDelegate, double price)
        {
            string str = "";
            foreach (Flight f in flights)
            {
                if (price < f.Price)
                {
                    str += findFlightDelegate(f.Id);
                }
            }
            return str;
        }
        public void CompareFlightAndPrice(Action<Flight, double> action, Flight flight, double price)
        {
            action(flight, price);
        }
        public string FindFlightGreaterThan250(Predicate<double> predicate)
        {
            string str = "";
            foreach (Flight f in flights)
            {
                if (predicate(f.Price))
                {
                    str += f.ToString();
                }
            }
            return str;
        }
    }

}