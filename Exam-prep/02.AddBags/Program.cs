using System;

namespace _02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20kg = double.Parse(Console.ReadLine());
            double kgBagagge = double.Parse(Console.ReadLine());
            int daysUntilTrip = int.Parse(Console.ReadLine());
            int countBagagges = int.Parse(Console.ReadLine());

            double priceForBagagge = 0;
            

            if (kgBagagge < 10)
            {
                priceForBagagge = priceAbove20kg * 0.2;
            }
            else if (kgBagagge >= 10 && kgBagagge <= 20)
            {
                priceForBagagge = priceAbove20kg * 0.5;
            }
            else if (kgBagagge > 20)
            {
                priceForBagagge = priceAbove20kg;
            }
            
            if (daysUntilTrip > 30)
            {
                priceForBagagge = priceForBagagge + (priceForBagagge * 0.1);
            }
            else if (daysUntilTrip >= 7 && daysUntilTrip <= 30)
            {
                priceForBagagge = priceForBagagge + (priceForBagagge * 0.15);
            }
            else if (daysUntilTrip < 7)
            {
                priceForBagagge = priceForBagagge + (priceForBagagge * 0.4);
            }

            double totalBagagge = priceForBagagge * countBagagges;

            Console.WriteLine($"The total price of bags is: {totalBagagge:F2} lv.");



        }
    }
}
