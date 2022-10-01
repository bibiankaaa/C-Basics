using System;

namespace _04.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsForFirstPlayer = int.Parse(Console.ReadLine());
            int eggsForSecondPlayer = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "End") 
            {
                if (input == "one")
                {
                    eggsForSecondPlayer--;
                }
                else if (input == "two")
                {
                    eggsForFirstPlayer--;
                }

                if (eggsForFirstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsForSecondPlayer} eggs left.");
                    break;
                }

                if (eggsForSecondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsForFirstPlayer} eggs left.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine($"Player one has {eggsForFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsForSecondPlayer} eggs left.");
            }
            
        }
    }
}
