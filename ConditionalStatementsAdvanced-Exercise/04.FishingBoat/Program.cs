using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishmen = int.Parse(Console.ReadLine());
            double shipPrice = 0;
            
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                    shipPrice = 4200;
                    break;
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
                     
            }
            double totalPrice = 0;

            if (fishmen <= 6)
            {
                  discount = shipPrice * 0.10;
                totalPrice = shipPrice - discount;
            }
            else if (fishmen >= 7 && fishmen <= 11)
            {
                discount = shipPrice * 0.15;
                totalPrice = shipPrice - discount;
            }
            else if (fishmen >= 12)
            {
                discount = shipPrice * 0.25;
                totalPrice = shipPrice - discount;
            }


            if (fishmen % 2 == 0 && season != "Autumn")
            {
                double discountTwo = totalPrice * 0.05;
                totalPrice = totalPrice - discountTwo;
            }

            double finalPrice = Math.Abs(totalPrice - budget);
            
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice:f2} leva.");
            }
        }
    }
}
