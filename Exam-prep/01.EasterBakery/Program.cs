using System;

namespace _01.EasterBakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceKgFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int eggsPack = int.Parse(Console.ReadLine());
            int packsYeast = int.Parse(Console.ReadLine());

            double priceForSugar = priceKgFlour - (priceKgFlour * 0.25);
            double priceForEggsPack = priceKgFlour * 1.1;
            double priceForPackYeast = priceForSugar * 0.2; 

            double totalFloor = priceKgFlour * kgFlour;
            double totalSugar = priceForSugar * kgSugar;
            double totalEggs = priceForEggsPack * eggsPack;
            double totalYeast = priceForPackYeast * packsYeast;

            double total = totalFloor + totalSugar + totalEggs + totalYeast;

            Console.WriteLine($"{total:f2}");
        }
    }
}
