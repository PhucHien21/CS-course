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
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
                binaryWriter.Write(Name);
                binaryWriter.Write(ConstructionDate);
                binaryWriter.Write(Address);
                binaryWriter.Write(NumberOfStars);
                binaryWriter.Close();
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
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (Room room in rooms)
                {
                    binaryWriter.Write(room.RoomNumber);
                    binaryWriter.Write(room.Area);
                    binaryWriter.Write(room.Type);
                    binaryWriter.Write(room.PricePerNight);
                    binaryWriter.Write(room.Description);
                }
                binaryWriter.Close();
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
                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (Customer customer in customers)
                {
                    binaryWriter.Write(customer.Name);
                    binaryWriter.Write(customer.Address);
                    binaryWriter.Write(customer.RoomNumber);
                    binaryWriter.Write(customer.ArrivalDate);
                    binaryWriter.Write(customer.NumberOfNights);
                }
                binaryWriter.Close();
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
