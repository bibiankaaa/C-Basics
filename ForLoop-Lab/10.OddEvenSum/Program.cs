using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int value = 1; value <= numOfRows; value++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    evenSum += currentNumber; 
                }
                else
                {
                    oddSum += currentNumber;
                }
                
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");

            }
        }
    }
}
