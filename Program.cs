using System;

namespace Lycky_ticket
{
    class Program 
    {
        static void Main(string[] args)
        {
            const int MIN_NUMBER = 4;
            const int MAX_NUMBER = 8;

            while(true)
            {
                Console.WriteLine($"Enter ticket (ticket can be {MIN_NUMBER} to {MAX_NUMBER} digits long): ");
                string ticket = Console.ReadLine();
                
                int ticketLength = ticket.Length;

                if (ticket == "q")
                {
                    break;
                }

                if (ticketLength < MIN_NUMBER || ticketLength >= MAX_NUMBER)
                {
                    Console.WriteLine($"The number is not valid. Number can be {MIN_NUMBER} to {MAX_NUMBER}");
                }
                else
                {

                    if (ticketLength % 2 != 0)
                    {
                        ticket = "0" + ticket;
                    }

                    bool isLucky = isLuckyTicket(ticket);

                    if (isLucky)
                    {
                        Console.WriteLine("Ticket is Lucky");
                    }
                    else
                    {
                        Console.WriteLine("Ticket is not Lucky");
                    }
                }

            }

        }

        public static bool isLuckyTicket(string ticket)
        {
            int firstHalfSum = -1;
            int secondHalfSum = -1;

            for (int i = 0; i < ticket.Length; i++)
            {
                if(i < ticket.Length / 2)
                {
                    if(!Char.IsDigit(ticket[i]))
                    {
                        Console.WriteLine("Ticket is not a number");
                        break;
                    }

                    firstHalfSum += int.Parse(ticket[i].ToString());

                } else
                {
                    if (!Char.IsDigit(ticket[i]))
                    {
                        Console.WriteLine("Ticket is not a number");
                        break;
                    }

                    secondHalfSum += int.Parse(ticket[i].ToString());
                }
            }

            if (firstHalfSum == secondHalfSum && firstHalfSum != -1 && secondHalfSum != -1)
                return true;

            return false;
        }
    }
}
