using System;

namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double buget = double.Parse(Console.ReadLine());
            double cast = double.Parse(Console.ReadLine());     
            double castClothes = double.Parse(Console.ReadLine());

            double decor = buget * 0.1;
            double castClothesSum = cast * castClothes;
            double discount = 0.0;

            if (cast >= 150)
            {
                discount = castClothesSum * 0.1;
                castClothesSum = castClothesSum - discount;
            }
             
            if (decor + castClothesSum > buget)
            {
                double totalMoney = decor + castClothesSum;
                double moneyNeeded = totalMoney - buget;

                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (decor + castClothesSum <= buget)
            {
                double totalMoney = decor + castClothesSum;
                double moneyLeft = buget - totalMoney;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
