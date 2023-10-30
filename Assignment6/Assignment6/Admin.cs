using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Admin : IAdmin
    {
        private string filePathHotel;
        private string filePathRoom;
        private string filePathCustomer;

        public string FilePathHotel
        {
            get { return filePathHotel; }
        }
        public string FilePathRoom
        {
            get { return filePathRoom; }
        }
        public string FilePathCustomer
        {
            get { return filePathCustomer; }
        }

        public Admin(string filePathHotel, string filePathRoom, string filePathCustomer)
        {
            this.filePathHotel = filePathHotel;
            this.filePathRoom = filePathRoom;
            this.filePathCustomer = filePathCustomer;
        }

        public ArrayList ReadFromFileCustomer()
        {
            ArrayList customers = new ArrayList();
            string name;
            string address;
            int roomNumber;
            string arrivalDate;
            int numberOfNights;

            BinaryReader binaryReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                binaryReader = new BinaryReader(new FileStream(FilePathCustomer, FileMode.Open));
                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    name = binaryReader.ReadString();
                    address = binaryReader.ReadString();
                    roomNumber = binaryReader.ReadInt32();
                    arrivalDate = binaryReader.ReadString();
                    numberOfNights = binaryReader.ReadInt32();
                    customers.Add(new Customer(name, address, roomNumber, arrivalDate, numberOfNights));
                }
            }
            catch (FileNotFoundException)
            {
                sb.Append(FilePathCustomer + " not found!");

            }
            catch (IOException)
            {
                sb.Append("Error reading " + FilePathCustomer);
            }
            finally
            {
                binaryReader.Close();
            }
            Console.WriteLine(sb.ToString());
            return customers;
        }
        public ArrayList ReadFromFileRoom()
        {
            ArrayList rooms = new ArrayList();
            int roomNumber;
            string area;
            string type;
            double pricePerNight;
            string description;
            BinaryReader binaryReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                binaryReader = new BinaryReader(new FileStream(FilePathRoom, FileMode.Open));
                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    roomNumber = binaryReader.ReadInt32();
                    area = binaryReader.ReadString();
                    type = binaryReader.ReadString();
                    pricePerNight = binaryReader.ReadDouble();
                    description = binaryReader.ReadString();
                    rooms.Add(new Room(roomNumber, area, type, pricePerNight, description));
                }
            }
            catch (FileNotFoundException)
            {
                sb.Append(FilePathRoom + " not found!");

            }
            catch (IOException)
            {
                sb.Append("Error reading " + FilePathRoom);
            }
            finally
            {
                binaryReader.Close();
            }
            Console.WriteLine(sb.ToString());
            return rooms;
        }

        public Hotel ReadFromFileHotel()
        {
            Hotel hotel = null;
            string hotelName;
            string constructionDate;
            string address;
            int numberOfStars;
            BinaryReader binaryReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                binaryReader = new BinaryReader(new FileStream(FilePathHotel, FileMode.Open));
                hotelName = binaryReader.ReadString();
                constructionDate = binaryReader.ReadString();
                address = binaryReader.ReadString();
                numberOfStars = binaryReader.ReadInt32();
                hotel = new Hotel(hotelName, constructionDate, address, numberOfStars, ReadFromFileRoom(), ReadFromFileCustomer());
            }
            catch (FileNotFoundException)
            {
                sb.Append(FilePathHotel + " not found!");

            }
            catch (IOException)
            {
                sb.Append("Error reading " + FilePathHotel);
            }
            finally
            {
                binaryReader.Close();
            }
            Console.WriteLine(sb.ToString());
            return hotel;
        }

        public string GetHotelInfo()
        {
            return ReadFromFileHotel().ToString();
        }
        public string SearchRoom(int roomNumeberSearch)
        {
            StringBuilder sb = new StringBuilder();
            ArrayList rooms = ReadFromFileRoom();
            foreach(Room r in rooms)
            {
                if (roomNumeberSearch == r.RoomNumber) sb.Append(r.ToString()); 
            }
            return sb.ToString();
        }
        public string SearchCustomer(string customerNameSearch)
        {
            StringBuilder sb = new StringBuilder();
            ArrayList customers = ReadFromFileCustomer();
            foreach (Customer c in customers)
            {
                if (customerNameSearch.Equals(c.Name)) sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
