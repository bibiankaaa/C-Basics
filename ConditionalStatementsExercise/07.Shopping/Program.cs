using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int countVideoCart = int.Parse(Console.ReadLine());
            int countProcessor = int.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());

            double sumForVideoCart = countVideoCart * 250;

            double processorPrice = sumForVideoCart * 0.35;
            double sumForProcessor = countProcessor * processorPrice;

            double ramPrice = sumForVideoCart * 0.10;
            double sumForRam = ramPrice * countRam;

            double totalSum = sumForVideoCart + sumForProcessor + sumForRam;
            

            if (countVideoCart > countProcessor)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else
            {
                totalSum = sumForVideoCart + sumForProcessor + sumForRam;
            }

            if (buget >= totalSum)
            {
                double enoughMoney = buget - totalSum;
                Console.WriteLine($"You have {enoughMoney:f2} leva left!");
            }
            else
            {
                double moneyNeeded = totalSum - buget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
