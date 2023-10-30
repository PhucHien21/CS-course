using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Hotel : IHotel
    {
        protected string name;
        protected string constructionDate;
        protected string address;
        protected int numberOfStars;
        protected ArrayList rooms;
        protected ArrayList customers;

        public string Name
        {
            get { return name; }
        }
        public string ConstructionDate
        {
            get { return constructionDate; }
        }
        public string Address
        {
            get { return address; }
        }
        public int NumberOfStars
        {
            get { return numberOfStars; }
        }
        public Hotel(string name, string constructionDate, string address, int numberOfStars, ArrayList rooms, ArrayList customers)
        {
            this.name = name;
            this.constructionDate = constructionDate;
            this.address = address;
            this.numberOfStars = numberOfStars;
            this.rooms = rooms;
            this.customers = customers;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Hotel: {0}\nConstruction Date: {1}\nAddress: {2}\nNumber of Stars: {3}\n\nList of Rooms: ",
                Name, ConstructionDate, Address, NumberOfStars));
            foreach (Room r in rooms) sb.Append(r.ToString());
            sb.Append("\n\nList of Customers: ");
            foreach (Customer c in customers) sb.Append(c.ToString());
            return sb.ToString();
        }

        public string WriteToFileHotel(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                TextWriter textWriter = new StreamWriter(filePath, append: false);
                textWriter.WriteLine(Name + "|" + ConstructionDate + "|" + Address + "|" + numberOfStars);
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                sb.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                sb.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                sb.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return sb.ToString();
        }
        public string WriteToFileRoom(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                TextWriter textWriter = new StreamWriter(filePath, append: false);
                foreach (Room room in rooms)
                {
                    textWriter.WriteLine(room.RoomNumber + "|" + room.Area + "|" + room.Type + "|" + room.PricePerNight + "|" + room.Description);
                }
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                sb.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                sb.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                sb.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return sb.ToString();
        }
        public string WriteToFileCustomer(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                TextWriter textWriter = new StreamWriter(filePath, append: false);
                foreach (Customer customer in customers)
                {
                    textWriter.WriteLine(customer.Name + "|" + customer.Address + "|" + customer.RoomNumber + "|" + customer.ArrivalDate + "|" + customer.NumberOfNights);
                }
                textWriter.Close();
            }
            catch (FileNotFoundException)
            {
                sb.Append(filePath + " not found!");
            }
            catch (IOException)
            {
                sb.Append("Error writing to file: " + filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
                sb.Append(fileInfo.FullName + " exists? " + fileInfo.Exists + ". Current length: " + fileInfo.Length);
            return sb.ToString();
        }
    }
}
