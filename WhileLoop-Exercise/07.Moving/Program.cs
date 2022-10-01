using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            double cubicMeters = width * lenght * high;

            while (cubicMeters > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{cubicMeters} Cubic meters left.");
                    break;
                }
                if (input != "Done")
                {
                    double boxesCount = double.Parse(input);
                    cubicMeters -= boxesCount;
                }
            }
            if (cubicMeters <= 0)
            {
              Console.WriteLine($"No more free space! You need {Math.Abs(cubicMeters)} Cubic meters more.");
            }
            
            
        }
    }
}
