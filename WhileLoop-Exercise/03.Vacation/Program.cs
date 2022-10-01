using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForHoliday = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            

            int consecutiveDays = 0;
            int days = 0;
            double currentMoney = 0;

            while (availableMoney >= 0)
            {
                string action = Console.ReadLine();
                double moneyAction = int.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    consecutiveDays++;
                    days++;
                    currentMoney = availableMoney - moneyAction;
                  
                }
                else
                {
                    days++;
                    currentMoney += moneyAction;
                }
                
                if (consecutiveDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                if (currentMoney >= availableMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
                
            }
           

        }
    }
}
