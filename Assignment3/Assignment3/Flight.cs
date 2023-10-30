using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Flight
    {
        private int id;
        private string origin;
        private string destination;
        private string date;
        private double price;
        public Flight(int id, string origin, string destination, string date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }
        public int Id
        {
            get { return id; }
            set {  this.id = value; }
        }
        public string Origin
        {
            get { return origin; }
            set { this.origin = value; }
        }    
        public string Destination
        {
            get { return destination; }
            set { this.destination = value; }
        }
        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }
        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public string FindFlight(int searchId)
        {
            if(searchId == this.id)
            {
                return this.ToString();
                
            }
            return "";
        }
        public override string ToString()
        {
            string str = "\nFlight ID: " + id 
                       + "\n\tOrigin: " + origin 
                       + "\n\tDestination: " + destination 
                       + "\n\tDate: " + date 
                       + "\n\tPrice: " + price + " Euro";
            return str;
        }
    }
}
