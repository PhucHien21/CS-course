using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
            bool flag = true;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Search flight");
                Console.WriteLine("2. Print all available flights");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int userInput;
                        string result = "";
                        Console.Write("Input flight id to search: ");
                        userInput = Convert.ToInt16(Console.ReadLine());
                        result = airline.FindFLight(userInput);
                        Console.WriteLine("\n" + result);
                        break;
                    case 2:
                        Console.WriteLine("List of all available Flight:");
                        for (int i = 0; i < airline.Count(); i++)
                            Console.WriteLine(airline[i] + "\n");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
