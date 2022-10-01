using System;

namespace _01.EasterLunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countKozunac = int.Parse(Console.ReadLine());
            int eggsKora = int.Parse(Console.ReadLine());
            int kgKurabii = int.Parse(Console.ReadLine());

            double priceForKozunak = countKozunac * 3.20;
            double priceForEggs = eggsKora * 4.35;
            double priceForKurabii = kgKurabii * 5.40;
            double pricePaintForEggs = eggsKora * 12 * 0.15;

            double total = priceForKozunak + priceForEggs + priceForKurabii + pricePaintForEggs;

            Console.WriteLine($"{total:f2}");
        }
    }
}
