using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            

            while (steps < 10000)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int walkedSteps = int.Parse(Console.ReadLine());
                    steps += walkedSteps;
                    break;
                }
                else
                {
                    steps += int.Parse(input);
                }

            }
            if (steps >= 10000)
            {
                int diff = steps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                int difference = 10000 - steps;
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
