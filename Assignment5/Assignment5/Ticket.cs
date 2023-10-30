using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Ticket
    {
        private int ticketId;
        private int passengerId;
        private Flight flight;
        private double price;
        private readonly double extraTax;
        public Ticket(int ticketId, int passengerId, Flight flight, double price)
        {
            this.ticketId = ticketId;
            this.passengerId = passengerId;
            this.flight = flight;

            if (DateTime.Parse(flight.Date).DayOfWeek.Equals(DayOfWeek.Saturday) || DateTime.Parse(flight.Date).DayOfWeek.Equals(DayOfWeek.Sunday))
                this.extraTax = 0.07;
            else
                this.extraTax = 0.05;
            this.price = price * (1 + this.extraTax);
        }
        public int TicketId
        {
            get { return ticketId; }
        }
        public int PassengerId
        {
            get { return passengerId; }
        }
        public double Price
        {
            get { return price; }
        }
        public double ExtraTax
        {
            get { return extraTax; }
        }
        public double GetPrice(int ticketId)
        {
            double result;
            result = Price + (ExtraTax * Price);
            return result;
        }
        public string GetPassengers(ArrayList passengers)
        {
            string str = "";
            foreach (Passenger passenger in passengers)
            {
                if (passenger.Id == PassengerId)
                {
                    str += "\nTicket's information: ";
                    str += ToString();
                    str += "\n" + passenger.ToString();
                }
            }
            return str;
        }
        public override string ToString()
        {
            string str = "";
            str += "\n\nTicket ID: " + TicketId;
            str += "\n\tPassenger ID: " + PassengerId;
            str += "\n\tPrice: " + Price;
            str += flight.ToString();
            return str;
        }
    }
}
