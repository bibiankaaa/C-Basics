using System;

namespace _01.FruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strPrice = double.Parse(Console.ReadLine());
            double kgBanana = double.Parse(Console.ReadLine());
            double kgOranges = double.Parse(Console.ReadLine());
            double kgRassberries = double.Parse(Console.ReadLine());
            double kgStr = double.Parse(Console.ReadLine());

            double rassPrice = strPrice / 2;
            double orangePrice = rassPrice - (rassPrice * 0.4);
            double bananaPrice = rassPrice - (rassPrice * 0.8);

            double totalStr = strPrice * kgStr;
            double totalBanana = kgBanana * bananaPrice;
            double totalOranges = kgOranges * orangePrice;
            double totalRass = rassPrice * kgRassberries;

            double totalSum = totalStr + totalRass + totalOranges + totalBanana;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
