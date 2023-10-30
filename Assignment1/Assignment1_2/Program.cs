using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Customer[] listCustomer = { new Customer("Hien", 1, 1), 
                                        new Customer("Hoang", 2, 3),
                                        new Customer("Hong", 3, 1), 
                                        new Customer("John", 4, 2),
                                        new Customer("Howard", 5, 3) };
            Flight[] listFlight = { new Flight(1, "Finland", "Viet Nam", "24/11"), 
                                    new Flight(2, "Finland", "Russia", "25/11"),
                                    new Flight(3, "Finland", "Czech", "26/11")};

            int choice = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("\nOption:");
                    Console.WriteLine("1. Search flight");
                    Console.WriteLine("2. Search customer");
                    Console.WriteLine("3. Exit");
                    choice = Convert.ToInt16(Console.ReadLine());
                    if (choice == 3) break;
                    switch (choice)
                    {
                        case 1:
                            admin.searchFlight(listFlight, listCustomer);
                            break;
                        case 2:
                            Console.WriteLine("\nOption:");
                            Console.WriteLine("1. Search name");
                            Console.WriteLine("2. Search id");
                            Console.WriteLine("3. Exit");
                            choice = Convert.ToInt16(Console.ReadLine());
                            if (choice == 3) break;
                            switch (choice)
                            {
                                case 1:
                                    admin.searchCustomerName(listFlight, listCustomer);
                                    break;
                                case 2:
                                    admin.searchCustomerId(listFlight, listCustomer);
                                    break;
                            }
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
                }
            }
        }
    }
}
