using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathHotel = @"D:\CS\Assignment6\hotel.dat";
            string filePathRoom = @"D:\CS\Assignment6\room.dat";
            string filePathCustomer = @"D:\CS\Assignment6\customer.dat";
            Admin admin = new Admin(filePathHotel, filePathRoom, filePathCustomer);

            ArrayList rooms = new ArrayList();
            rooms.Add(new Room(101, "24m2", "Single", 25, "Small Room for 1 person"));
            rooms.Add(new Room(102, "32m2", "Double", 50, "Room for couple"));
            rooms.Add(new Room(201, "56m2", "Luxury", 100, "Luxury experience room"));
            rooms.Add(new Room(300, "100m2", "President", 200, "Special room for wealthy person"));

            ArrayList customers = new ArrayList();
            customers.Add(new Customer("Hoang", "62 Palosaarentie C13", 101, "13/2", 3));
            customers.Add(new Customer("Ryan", "21 Palosaarentie", 102, "14/2", 1));
            customers.Add(new Customer("Lily", "21 Palosaarentie", 102, "14/2", 1));
            customers.Add(new Customer("Hong", "62 Palosaarentie C13", 201, "15/2", 2));
            customers.Add(new Customer("Hien", "62 Palosaarentie C13", 300, "17/2", 2));

            Hotel hotel = new Hotel("New Life", "21/09/2001", "11 Southeast Street", 5, rooms, customers);

            Console.WriteLine(hotel.WriteToFileHotel(filePathHotel));
            Console.WriteLine(hotel.WriteToFileRoom(filePathRoom));
            Console.WriteLine(hotel.WriteToFileCustomer(filePathCustomer));

            bool flag = true;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Display hotel's information");
                Console.WriteLine("2. Search room's information");
                Console.WriteLine("3. Search customer's information");
                Console.WriteLine("4. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                int inputRoomSearch;
                string inputNameSearch;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(admin.GetHotelInfo());
                        break;
                    case 2:
                        Console.Write("Enter the room number to search:");
                        inputRoomSearch = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(admin.SearchRoom(inputRoomSearch));
                        break;
                    case 3:
                        Console.Write("Enter the customer name to search:");
                        inputNameSearch = Console.ReadLine();
                        Console.WriteLine(admin.SearchCustomer(inputNameSearch));
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
