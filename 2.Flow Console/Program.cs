using System;
using System.Collections.Generic;
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
            Console.WriteLine("1. Menu 1");
            Console.WriteLine("2. Menu 2");
            Console.WriteLine("3. Menu 3");
            Console.WriteLine("0. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Repite();
                    break;
                case "3":
                    Sentence();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
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
            
            int tot = 0;

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
                int price = (int)ticket.TicketCost;
            tot = tot + price;
                Console.WriteLine($"The total amount is {tot}");


            }
            

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
        private static void Repite()
        {
            Console.WriteLine("Write a sentence, Quit with 0");
            do
            {
                string text = Util.AskForString("Text: ");
                if (text == "0") break;
                //client.AddTicket(text);
                //Ticket[] tickets = client.GetTickets();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(text);
                }



            } while (true);



        }
        private static void Sentence()
        {
            Console.WriteLine("Write a sentence, Quit with 0");
            do
            {
                string sep = Util.AskForString("Sentence: ");
                if (sep == "0") break;
                Console.WriteLine(sep.Split(' ')[2]);




            } while (true);

        }
    }

}
