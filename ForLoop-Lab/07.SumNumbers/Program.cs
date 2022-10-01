using System;

namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numberOfRows; i++)
            {


                int currentNumber = int.Parse(Console.ReadLine());
                totalSum = totalSum + currentNumber;    
                     
            }
            Console.WriteLine(totalSum);
        }
    }
}
