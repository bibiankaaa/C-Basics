using System;

namespace _02.EasterParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double priceForOnePerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests >= 10 && guests <= 15)
            {
                priceForOnePerson = priceForOnePerson - (priceForOnePerson * 0.15);
            }
            else if (guests > 15 && guests <= 20)
            {
                priceForOnePerson = priceForOnePerson - (priceForOnePerson * 0.2);
            }
            else if (guests > 20)
            {
                priceForOnePerson = priceForOnePerson - (priceForOnePerson * 0.25);
            }

            double priceForCake = budget * 0.1;
            double totalSumForParty = priceForCake + (priceForOnePerson * guests);

            if (budget >= totalSumForParty)
            {
                Console.WriteLine($"It is party time! {budget - totalSumForParty:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(budget - totalSumForParty):f2} leva needed.");
            }
        }
    }
}
