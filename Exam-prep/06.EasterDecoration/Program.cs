using System;

namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chockoladBunnyPrice = 7;
            
            double totalSum = 0;
            
            for (int i = 1; i <= customers; i++)
            {
                string purchase = "";
                double customerSum = 0;
                int items = 0;

                while (purchase != "Finish")
                {
                    purchase = Console.ReadLine();
                    
                    if (purchase != "Finish")
                    {
                        items++;
                    }

                    switch (purchase)
                    {
                        case "basket":
                            customerSum += basketPrice;
                            break;
                        case "wreath":
                            customerSum += wreathPrice;
                            break;
                        case "chocolate bunny":
                            customerSum += chockoladBunnyPrice;
                            break;
                    }                    
                }
                if (items % 2 == 0)
                {
                    customerSum -= customerSum * 0.2;
                }

                totalSum += customerSum;
                Console.WriteLine($"You purchased {items} items for {customerSum:f2} leva.");
            }

            double average = totalSum / customers;
            Console.WriteLine($"Average bill per client is: {average:f2} leva.");
            
        }
    }
}
