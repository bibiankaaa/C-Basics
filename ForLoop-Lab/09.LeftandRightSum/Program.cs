using System;

namespace _09.LeftandRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int value = 0; value < 2 * numberOfRows; value++)
            {
                int number = int.Parse(Console.ReadLine());

                if (value < numberOfRows)
                {
                    leftSum += number; 
                }
                else
                {
                    rightSum += number;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
