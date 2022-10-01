using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int epizodTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125;
            double restTime = breakTime * 0.25;

            double neededTime = epizodTime + lunchTime + restTime;

            double difference = Math.Abs(neededTime - breakTime);

            if (breakTime >= neededTime)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
