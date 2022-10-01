using System;

namespace _03.PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colourOfTheEggs = Console.ReadLine();    
            int batch = int.Parse(Console.ReadLine());
            double price = 0;

            switch (sizeEggs)
            {
                case "Large":
                    switch (colourOfTheEggs)
                    {
                        case "Red":
                            price = batch * 16;
                            break;
                        case "Green":
                            price = batch * 12;
                            break;
                        case "Yellow":
                            price = batch * 9;
                            break;
                    }
                    break;
                case "Medium":
                    switch (colourOfTheEggs)
                    {
                        case "Red":
                            price = batch * 13;
                            break;
                        case "Green":
                            price = batch * 9;
                            break;
                        case "Yellow":
                            price = batch * 7;
                            break;
                    }
                    break;
                case "Small":
                    switch (colourOfTheEggs)
                    {
                        case "Red":
                            price = batch * 9;
                            break;
                        case "Green":
                            price = batch * 8;
                            break;
                        case "Yellow":
                            price = batch * 5;
                            break;
                    }
                    break;                    
            }
            double totalPrice = price - (price * 0.35);
            Console.WriteLine($"{totalPrice:F2} leva.");

        }
    }
}
