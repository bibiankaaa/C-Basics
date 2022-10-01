using System;

namespace _04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            double points = 0;            
            int countDevide = 0;
            int countDiffColour = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;

            for (int i = 1; i <= balls; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        points += 5;
                        redBalls++;
                        break;
                    case "orange":
                        points += 10;
                        orangeBalls++;
                        break;
                    case "yellow":
                        points += 15;
                        yellowBalls++;
                        break;
                    case "white":
                        points += 20;
                        whiteBalls++;
                        break;
                    case "black":
                        points = Math.Floor(points / 2);
                        countDevide++;
                        break;                      
                }
                if (colour != "red" && colour != "orange" && colour != "yellow" && colour != "white" && colour != "black")
                {
                    countDiffColour++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {countDiffColour}");
            Console.WriteLine($"Divides from black balls: {countDevide}");
        }
    }
}
