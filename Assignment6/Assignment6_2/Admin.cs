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
            string item;
            TextReader textReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                textReader = new StreamReader(FilePathCustomer);
                while ((item = textReader.ReadLine()) != null)
                {
                    string[] info = item.Split('|');
                    customers.Add(new Customer(info[0], info[1], int.Parse(info[2]), info[3], int.Parse(info[4])));
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
                textReader.Close();
            }
            Console.WriteLine(sb.ToString());
            return customers;
        }
        public ArrayList ReadFromFileRoom()
        {
            ArrayList rooms = new ArrayList();
            string item;
            TextReader textReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                textReader = new StreamReader(FilePathRoom);
                while ((item = textReader.ReadLine()) != null)
                {
                    string[] info = item.Split('|');
                    rooms.Add(new Room(int.Parse(info[0]), info[1], info[2], double.Parse(info[3]), info[4]));
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
                textReader.Close();
            }
            Console.WriteLine(sb.ToString());
            return rooms;
        }

        public Hotel ReadFromFileHotel()
        {
            Hotel hotel = null;
            string item;
            TextReader textReader = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                textReader = new StreamReader(FilePathHotel);
                while ((item = textReader.ReadLine()) != null)
                {
                    string[] info = item.Split('|');
                    hotel = new Hotel(info[0], info[1], info[2], int.Parse(info[3]), ReadFromFileRoom(), ReadFromFileCustomer());
                }
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
                textReader.Close();
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
