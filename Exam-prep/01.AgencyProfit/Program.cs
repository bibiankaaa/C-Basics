using System;

namespace _01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double priceForAdultTicket = double.Parse(Console.ReadLine());
            double priceForService = double.Parse(Console.ReadLine());

            double kidTicketPrice = priceForAdultTicket - (priceForAdultTicket * 0.7);
            double adultTotal = priceForAdultTicket + priceForService;
            double kidTotal = kidTicketPrice + priceForService;
            double ticketsTotal = (kidTotal * kidsTickets) + (adultTotal * adultTickets);
            double companyWin = ticketsTotal * 0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {companyWin:F2} lv.");
        }
    }
}
