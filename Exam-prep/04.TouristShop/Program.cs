using System;

namespace _04.TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string productType = Console.ReadLine();
            double productPrice = double.Parse(Console.ReadLine());

            int productCounter = 0;
            double totalPrice = 0;
            double allProductsPrice = 0;

            for (int input = 0; input <= 3; input++)
            {
                totalPrice = budget - productPrice;
                productCounter++;
                allProductsPrice += productPrice;

                if (productType == "Stop")
                {
                    
                    Console.WriteLine($"You bought {productCounter} products for {allProductsPrice} leva.");
                    break;
                }
                if (totalPrice > budget)
                {
                    double difference = Math.Abs(totalPrice - budget);

                    Console.WriteLine($"You don't have enough money!You need {difference:F2} leva!");
                    break;
                }
                if (productCounter == 3)
                {
                    productPrice = productPrice / 2;
                }

                 productType = Console.ReadLine();
                productPrice = double.Parse(Console.ReadLine());
            }
           
            
        }
    }
}
