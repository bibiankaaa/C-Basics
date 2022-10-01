using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double price = 0.0;

            //Град   0 ≤ s ≤ 500   500 < s ≤ 1 000    1 000 < s ≤ 10 000     s > 10 000
            //Sofia      5 %             7 %                 8 %                 12 %
            //Varna      4.5 %           7.5 %               10 %                13 %
            //Plovdiv    5.5 %           8 %                 12 %                14.5 %

            switch (town)
            {
                case "Sofia":

                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        price = salesVolume * 0.05;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        price = salesVolume * 0.07;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        price = salesVolume * 0.08;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        price = salesVolume * 0.12;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (salesVolume < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        price = salesVolume * 0.045;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        price = salesVolume * 0.075;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        price = salesVolume * 0.1;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (salesVolume > 10000)
                    {
                        price = salesVolume * 0.13;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (salesVolume < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        price = salesVolume * 0.055;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        price = salesVolume * 0.08;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        price = salesVolume * 0.12;
                        Console.WriteLine($"{price:f2}");                       
                    }
                    else if (salesVolume > 10000)
                    {
                        price = salesVolume * 0.145;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (salesVolume < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default: 
                        Console.WriteLine("error");
                    break;

            }
        }
    }
}
