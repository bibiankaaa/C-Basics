using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double loundryPrice = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());

            int bDayMoney = 0;
            int toys = 0;
            int moneyToys = 0;
            int evenNumber = 0;
            int savedMoney = 0;
            int money = 0;

            for (int number = 1; number <= age; number++)
            {
                if (number % 2 == 0)
                {
                    money += 10;
                    evenNumber++;
                    bDayMoney += money;
                }
                else
                {
                    toys++;
                }
                        

            }

            moneyToys = toys * priceForOneToy;
            savedMoney = (moneyToys + bDayMoney) - evenNumber;

            double final = Math.Abs(savedMoney - loundryPrice);

            if (savedMoney > loundryPrice)
            {
                Console.WriteLine($"Yes! {final:F2}");
            }
            else
            {
                
                Console.WriteLine($"No! {final:F2}");
                 
                
            }
        }
    }
}
