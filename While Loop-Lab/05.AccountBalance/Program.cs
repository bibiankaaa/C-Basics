using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;


            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += money;
                    Console.WriteLine($"Increase: {money:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:F2}");
        }

    }
}
