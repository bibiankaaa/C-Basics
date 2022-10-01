using System;

namespace _02.EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double guestCount = double.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double kozunac = Math.Ceiling(guestCount / 3);
            double eggs = guestCount * 2;
            double priceKozunac = kozunac * 4;
            double priceEggs = eggs * 0.45;

            double totalPrice = priceKozunac + priceEggs;
            double total = Math.Abs(budget - totalPrice);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Lyubo bought {kozunac} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total:f2} lv. more.");
            }

        }
    }
}
