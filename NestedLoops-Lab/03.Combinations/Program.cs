using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstNumber = 0; firstNumber <= magicNumber; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= magicNumber; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= magicNumber; thirdNumber++)
                    {
                        if (firstNumber + secondNumber + thirdNumber == magicNumber)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
