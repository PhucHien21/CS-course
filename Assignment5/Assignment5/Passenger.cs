using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Passenger
    {
        protected int id;
        protected string firstName;
        protected string surname;
        protected string phoneNumber;
        protected ArrayList tickets;
        public int Id
        {
            get { return id; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public Passenger(int id, string firstName, string surname, string phoneNumber, ArrayList tickets)
        {
            this.id = id;
            this.firstName = firstName;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.tickets = tickets;
        }
        public virtual string GetInfo(int searchKey)
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
            string str = "\nPassenger's information:";
            str += "\n\nPassenger ID: " + Id;
            str += "\n\tFirst name: " + FirstName;
            str += "\n\tSurname: " + Surname;
            str += "\n\tPhone number: " + PhoneNumber;
            return str;
        }
    }
}
