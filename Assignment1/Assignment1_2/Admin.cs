using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Admin
    {
        public void searchFlight(Flight[] listFlight, Customer[] listCustomer)
        {
            try
            {
                int input;
                Console.Write("Flight id: ");
                input = Convert.ToInt16(Console.ReadLine());
                string str = "";

                foreach (Flight fly in listFlight)
                {
                    if (fly.getId() == input)
                    {
                        str += "\nFlight detail:" + fly.toString() + "\n\nCustomers:";
                        foreach (Customer cus in listCustomer)
                        {
                            if (cus.getFlightId() == input)
                            {
                                str += cus.toString() + "\n";
                            }
                        }
                    }
                }
                
                if (str.Equals(""))
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
            }
        }

        public void searchCustomerName(Flight[] listFlight, Customer[] listCustomer)
        {
            try
            {
                string input;
                Console.Write("Name: ");
                input = Console.ReadLine();
                String str = "";

                foreach (Customer cus in listCustomer)
                {
                    if (cus.getName().Equals(input))
                    {
                        str += "\nCustomer detail:" + cus.toString() + "\n\nFlight detail:";
                        foreach (Flight fly in listFlight)
                        {
                            if (fly.getId() == cus.getFlightId())
                            {
                                str += fly.toString() + "\n";
                            }
                        }
                    }
                }
                if (str.Equals(""))
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
            }
        }

        public void searchCustomerId(Flight[] listFlight, Customer[] listCustomer)
        {
            try
            {
                int input;
                Console.Write("Id: ");
                input = Convert.ToInt16(Console.ReadLine());
                String str = "";

                foreach (Customer cus in listCustomer)
                {
                    if (cus.getId() == input)
                    {
                        str += "\nCustomer detail:" + cus.toString() + "\n\nFlight detail:";
                        foreach (Flight fly in listFlight)
                        {
                            if (fly.getId() == cus.getFlightId())
                            {
                                str += fly.toString() + "\n";
                            }
                        }
                    }
                }
                if (str.Equals(""))
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalide data type!" + Environment.NewLine + e.Message);
            } 
        }
    }
}
