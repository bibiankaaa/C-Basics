using System;

namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool hasTheMagicNumberBeenFound = false;

            for (int firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (int secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {
                    counter++;

                    if (firstNumber + secondNumber == magicNumber)
                    {
                        hasTheMagicNumberBeenFound = true;

                       Console.WriteLine($"Combination N:{counter} ({firstNumber} + {secondNumber} = {magicNumber})");
                        break;
                    }
                }
                if (hasTheMagicNumberBeenFound)
                {
                    break;
                }
            }
            if (!hasTheMagicNumberBeenFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }

        }
    }
}
