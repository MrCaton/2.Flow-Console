using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Flow_Console
{
    class Ticket
    {
        public int Age { get; }

        public TicketCost TicketCost
        {
            get
            {
                if (Age<2)
                {
                    return TicketCost.Free;
                }
                if (Age < 20)
                {
                    return TicketCost.Youth;
                }
                else if (Age < 64)
                {
                    return TicketCost.Adult;
                }
                else if (Age < 100)
                {
                    return TicketCost.Pension;
                }
                else
                {
                    return TicketCost.Free;
                }
            }
        }

        public Ticket(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"Age: {Age}";
        }
    }
}
