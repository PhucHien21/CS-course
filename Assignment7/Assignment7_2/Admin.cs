using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_2
{
    class Admin
    {
        JSONSerializer jsonSerializer = new JSONSerializer();
        public string FilePathHotel { get; set; }
        public string FilePathRoom { get; set; }
        public string FilePathCustomer { get; set; }

        public Admin(string filePathHotel, string filePathRoom, string filePathCustomer)
        {
            FilePathHotel = filePathHotel;
            FilePathRoom = filePathRoom;
            FilePathCustomer = filePathCustomer;
        }

        public string GetHotelInfo()
        {
            Hotel hotel = jsonSerializer.ReadFromJSONFileHotel(FilePathHotel);
            return hotel.ToString();
        }
        public string SearchRoom(int roomNumeberSearch)
        {
            StringBuilder sb = new StringBuilder();
            List<Room> rooms = jsonSerializer.ReadFromJSONFileRoom(FilePathRoom);
            foreach (Room r in rooms)
            {
                if (roomNumeberSearch == r.RoomNumber) sb.Append(r.ToString());
            }
            return sb.ToString();
        }
        public string SearchCustomer(string customerNameSearch)
        {
            StringBuilder sb = new StringBuilder();
            List<Customer> customers = jsonSerializer.ReadFromJSONFileCustomer(FilePathCustomer);
            foreach (Customer c in customers)
            {
                if (customerNameSearch.Equals(c.Name)) sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
