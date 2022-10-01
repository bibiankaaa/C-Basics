using System;

namespace _04.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsInTheShop = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            
            int soldEggs = 0;

            while (command != "Close")
            {
                int countEggs = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (eggsInTheShop < countEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInTheShop}.");
                        break;
                    }

                    eggsInTheShop -= countEggs;
                    soldEggs = soldEggs + countEggs;
                }
                else if (command == "Fill")
                {
                    eggsInTheShop += countEggs;
                }
               
                command = Console.ReadLine();
                
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
