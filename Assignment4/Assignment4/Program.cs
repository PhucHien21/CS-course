using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airline = new AirlineCompany("Vietnam Airlines");
            Console.WriteLine("Airline: " + airline.AirlineName);
            airline[0] = new Flight(1, "Viet Nam", "Finland", "24/12", 521.9);
            airline[1] = new Flight(2, "Viet Nam", "South Korea", "25/12", 216.56);
            airline[2] = new Flight(3, "Viet Nam", "England", "26/12", 770.19);
            airline[3] = new Flight(4, "Viet Nam", "Japan", "27/12", 409.6);
            FindFlightDelegate byPrice;
            Action<Flight, double> action = (flight, price) => Console.WriteLine(price > flight.Price ? flight.ToString() : "The flight's price is greater than the given price");
            Predicate<double> predicate = (price) => (price > 250);
            bool flag = true;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Print all available flights");
                Console.WriteLine("2. Search flight");
                Console.WriteLine("3. Print all flights which price is less than the given price");
                Console.WriteLine("4. Compare the given price with the chosen flight");
                Console.WriteLine("5. Print all flights which price is greater than 250");
                Console.WriteLine("6. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                int userInputId;
                double userInputPrice;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("List of all available Flight:");
                        for (int i = 0; i < airline.Count(); i++)
                            Console.WriteLine(airline[i] + "\n");
                        break;
                    case 2:
                        Console.Write("Input flight id to search: ");
                        userInputId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("\n" + airline.FindFLight(userInputId));
                        break;
                    case 3:
                        Console.Write("Input the price:");
                        userInputPrice = Convert.ToDouble(Console.ReadLine());
                        byPrice = new FindFlightDelegate(airline.FindFLight);
                        Console.WriteLine("\n" + airline.CompareFlightPrice(byPrice, userInputPrice));
                        break;
                    case 4:
                        Console.Write("Input the price: ");
                        userInputPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input Flight's id: ");
                        userInputId = Convert.ToInt32(Console.ReadLine());
                        airline.CompareFlightAndPrice(action, airline[userInputId - 1], userInputPrice);
                        break;
                    case 5:
                        Console.WriteLine(airline.FindFlightGreaterThan250(predicate));
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
