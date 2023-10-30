using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Concert ticket1 = new Concert("Rap", "Central Hall", "1/12", "9pm", 25);
            Concert ticket2 = new Concert("Book", "Library", "2/12", "10am", 15);
            Concert ticket3 = new Concert("Game", "Game Center", "3/12", "11am", 10);
            Concert ticket4 = new Concert("Pop", "Stadium", "4/12", "10pm", 30);
            Concert ticket5 = new Concert("Rock", "Central Hall", "5/12", "9pm", 20);

            Hashtable concerts = new Hashtable();
            concerts.Add(ticket1.GetTitle(), ticket1);
            concerts.Add(ticket2.GetTitle(), ticket2);
            concerts.Add(ticket3.GetTitle(), ticket3);
            concerts.Add(ticket4.GetTitle(), ticket4);
            concerts.Add(ticket5.GetTitle(), ticket5);
            
            Console.WriteLine("Price of " + ticket1.GetTitle() + " concert before ++: " + ticket1.GetPrice() + "€\n");
            ticket1++;
            Console.WriteLine("Price of " + ticket1.GetTitle() + " concert after ++: " + ticket1.GetPrice() + "€\n");

            Console.WriteLine("Price of " + ticket2.GetTitle() + " concert before --: " + ticket2.GetPrice() + "€\n");
            ticket2--;
            Console.WriteLine("Price of " + ticket2.GetTitle() + " concert after --: " + ticket2.GetPrice() + "€\n");

            Console.WriteLine("Ticket 1 is cheaper than ticket 2: " + (ticket1 < ticket2) + "\n");
            Console.WriteLine("Ticket 2 is cheaper than ticket 1: " + (ticket2 < ticket1) + "\n");

            Console.WriteLine("The content of the Hashtable:\n");
            foreach (DictionaryEntry concert in concerts)
            {
                Console.WriteLine("\nKey: " + concert.Key + "\nValue:" + concert.Value);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
