using System;

namespace _02.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelLiters = double.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            double fuelPrice = fuelLiters * 2.10;
            double totalGitandFuel = fuelPrice + 100;

            double totalPrice = 0;

            switch (dayOfTheWeek)
            {
                case "Saturday":
                    totalPrice = totalGitandFuel - (totalGitandFuel * 0.1);
                    break;
                case "Sunday":
                    totalPrice = totalGitandFuel - (totalGitandFuel * 0.2);
                    break;
            }

            double moneyLeft = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {moneyLeft:F2} lv."); 
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {moneyLeft:F2} lv.");
            }
        }
    }
}
