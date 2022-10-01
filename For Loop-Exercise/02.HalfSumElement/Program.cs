using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int value = 1; value <= n ; value++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            int sumOfTheOthers = sum - maxNumber;

            if (sumOfTheOthers == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNumber - sumOfTheOthers));
            }
        }
    }
}
