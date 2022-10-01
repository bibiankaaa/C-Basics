using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;   

            int numOfRows = int.Parse(Console.ReadLine());

            for (int value = 0; value < numOfRows; value++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");

        }
    }
}
