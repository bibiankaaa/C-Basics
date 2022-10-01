using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeOfHoliday = string.Empty;
            string destination = string.Empty;
            double spendMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                    typeOfHoliday = "Camp";
                        
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                    typeOfHoliday = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    spendMoney = budget * 0.4;
                    typeOfHoliday = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                    typeOfHoliday = "Hotel";
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfHoliday = "Hotel";
                spendMoney = budget * 0.9;

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {spendMoney:f2}"); 
        }
    }
}
