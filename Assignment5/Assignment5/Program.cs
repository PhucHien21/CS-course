using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight[] flight = { new Flight(1, "Finland", "Vietnam", "05/02/2022"),
                                new Flight(2, "Vietnam", "Japan", "06/02/2022"),
                                new Flight(3, "Japan", "Finland", "07/02/2022")};

            Ticket[] tickets = { new Ticket(1, 1, flight[0], 200),
                                 new Ticket(2, 2, flight[0], 300),
                                 new Ticket(3, 2, flight[1], 350),
                                 new Ticket(4, 3, flight[0], 500),
                                 new Ticket(5, 3, flight[1], 600),
                                 new Ticket(6, 3, flight[2], 700),};

            ArrayList tickets1 = new ArrayList();
            tickets1.Add(tickets[0]);

            ArrayList tickets2 = new ArrayList();
            tickets2.Add(tickets[1]);
            tickets2.Add(tickets[2]);

            ArrayList tickets3 = new ArrayList();
            tickets3.Add(tickets[3]);
            tickets3.Add(tickets[4]);
            tickets3.Add(tickets[5]);

            ArrayList passengers = new ArrayList();
            passengers.Add(new Passenger(1, "Hong", "Huynh", "123", tickets1));
            passengers.Add(new EconomyPassenger(2, "Hoang", "Duong", "456", 23, tickets2));
            passengers.Add(new FirstClassPassenger(3, "Hien", "Nguyen", "789", 46,  "Beefsteak", tickets3));

            bool flag = true;
            int inputTicketId, inputPassengerId;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Search the information of tickets");
                Console.WriteLine("2. Search the information of passengers");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt16(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Input ticket's id: ");
                        inputTicketId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(tickets[inputTicketId - 1].GetPassengers(passengers));
                        break;
                    case 2:
                        Console.Write("Input passenger's id: ");
                        inputPassengerId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(((Passenger)passengers[inputPassengerId - 1]).GetInfo(inputPassengerId));
                        break;
                    case 3:
                        flag = false;
                        break;
                }
                
            }

        }
    }
}
