using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_2
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int RoomNumber { get; set; }
        [DataMember]
        public string ArrivalDate { get; set; }
        [DataMember]
        public int NumberOfNights { get; set; }
        public Customer() { }
        public Customer(string name, string address, int roomNumber, string arrivalDate, int numberOfNights)
        {
            Name = name;
            Address = address;
            RoomNumber = roomNumber;
            ArrivalDate = arrivalDate;
            NumberOfNights = numberOfNights;
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
