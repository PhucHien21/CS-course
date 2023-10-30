using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Concert
    {
        private string title;
        private string location;
        private string date;
        private string time;
        private double price;

        public Concert(string title, string location, string date, string time, double price)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.time = time;
            this.price = price;
        }
        public string GetTitle()
        {
            return title;
        }
        public double GetPrice()
        {
            return price;
        }
        public override string ToString()
        {
            string str = "\n\tTitle: " + title +
                         "\n\tLocation: " + location +
                         "\n\tDate: " + date +
                         "\n\tTime: " + time +
                         "\n\tPrice: " + price + " Euro";

            return str;
        }
        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.price < c2.price) return true;
            return false;
        }
        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.price > c2.price) return true;
            return false;
        }
        public static Concert operator ++(Concert c1)
        {
            return new Concert(c1.title, c1.location, c1.date, c1.time, c1.price + 5);
        }
        public static Concert operator --(Concert c1)
        {
            return new Concert(c1.title, c1.location, c1.date, c1.time, c1.price - 5);
        }
    }
}
