using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FirstClassPassenger : EconomyPassenger
    {
        protected double bonus;
        protected string menu;

        public FirstClassPassenger(int id, string firstName, string surname, string phoneNumber, double weight, string menu, ArrayList tickets) : base(id, firstName, surname, phoneNumber, weight, tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                this.bonus += ticket.Price * 0.02;
            }
            this.menu = menu;
        }

        public double Bonus
        {
            get { return bonus; }
        }
        public string Menu
        {
            get { return menu; }
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
            str += "\n\tMeal: " + Menu;
            str += "\n\tBonus: " + Bonus;
            return str;
        }
    }
}
