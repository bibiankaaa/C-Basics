using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double recordInSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double secondsInTotal = meters * secondsForOneMeter;
            double totalTime = Math.Floor(meters / 15);
            double totalTimeTwo = totalTime * 12.5;
            double total = totalTimeTwo + secondsInTotal;

            if (recordInSeconds > total)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {total:f2} seconds.");
            }
            else
            {
                double notEnoughSeconds = total - recordInSeconds;

                Console.WriteLine($"No, he failed! He was {notEnoughSeconds:f2} seconds slower.");
                
            }


        }
    }
}
