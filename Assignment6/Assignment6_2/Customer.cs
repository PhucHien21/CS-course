using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Customer : ICustomer
    {
        protected string name;
        protected string address;
        protected int roomNumber;
        protected string arrivalDate;
        protected int numberOfNights;

        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
        }
        public int RoomNumber
        {
            get { return roomNumber; }
        }
        public string ArrivalDate
        {
            get { return arrivalDate; }
        }
        public int NumberOfNights
        {
            get { return numberOfNights; }
        }
        public Customer(string name, string address, int roomNumber, string arrivalDate, int numberOfNights)
        {
            this.name = name;
            this.address = address;
            this.roomNumber = roomNumber;
            this.arrivalDate = arrivalDate;
            this.numberOfNights = numberOfNights;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("\n\n\tCustomer's name: {0}\n\tAddress: {1}\n\tRoom's Number: {2}\n\tArrival Date: {3}\n\tNumber of Nights: {4}",
                Name, Address, RoomNumber, ArrivalDate, NumberOfNights));
            return sb.ToString();
        }
    }
}
