using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Flow_Console
{
    class Client
    {
        private List<Ticket> client;
        public Client()
        {
            client = new List<Ticket>();
        }

        internal Ticket[] GetTickets()
        {
            return client.ToArray();
        }
        internal void AddTicket(int age)
        {
            client.Add(new Ticket(age));
        }

    }
}
