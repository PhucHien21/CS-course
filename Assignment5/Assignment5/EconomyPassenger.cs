using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class EconomyPassenger: Passenger
    {
        protected double luggageWeight;
        public double LuggageWeight
        {
            get { return luggageWeight; }
        }
        public EconomyPassenger(int id, string firstName, string surname, string phoneNumber, double weight, ArrayList tickets) : base(id, firstName, surname, phoneNumber, tickets)
        {
            this.luggageWeight = weight;
        }
        public override string GetInfo(int searchKey)
        {
            string str = "";
            if (searchKey == Id)
            {
                str += ToString();
                str += "\n\nTicket information:";
                foreach (Ticket ticket in tickets)
                {
                    str += ticket.ToString();
                }
            }
            return str;
        }
        public override string ToString()
        {
            string str = "";
            str += base.ToString();
            str += "\n\tMaximum luggage weight: " + LuggageWeight;
            return str;
        }
    }
}
