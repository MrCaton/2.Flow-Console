using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;

namespace _2.Flow_Console
{
    class Program
    {
        static Client client = new Client();
        static void Main(string[] args)
        {
            do
            {
                PrintMeny();
            } while (true);
        }

        private static void PrintMeny()
        {
            Console.WriteLine("1. Next menu");
            Console.WriteLine("2. Total");
            Console.WriteLine("0. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Print();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        private static void Print()
        {
            Ticket[] tickets = client.GetTickets();
            int total = 0;
            //int n = tickets.Sum();
            //for(int i=0;i<n;i++)
            //{
            //    total = total + i;
            //}
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket);

                Console.WriteLine(ticket.TicketCost.Equals(TicketCost.Youth) ?
                    YouthTicket() : (
                    ticket.TicketCost.Equals(TicketCost.Adult) ?
                    AdultTicket() : (
                    ticket.TicketCost.Equals(TicketCost.Pension) ?
                    PensionTicket() :
                    FreeTicket())));



            }
            Console.WriteLine($"Total:{total}");
        }


        private static void Add()
        {
            Console.WriteLine("Add the age of the costumer, Quit with 0");

            do
            {
                int age = Util.AskForInt("Age: ");
                if (age == 0) break; 
                client.AddTicket(age);
                Ticket[] tickets = client.GetTickets();

                

            } while (true);
            

        }
    

        private static string PensionTicket()
        {
            return "The ticket costs 90 SEK";
        }

        private static string FreeTicket()
        {
            return "The ticket is free";
        }

        private static string YouthTicket()
        {
            return "The ticket costs 80 SEK";
        }

        private static string AdultTicket()
        {
            return "The ticket costs 120 SEK";
        }
    }
}

