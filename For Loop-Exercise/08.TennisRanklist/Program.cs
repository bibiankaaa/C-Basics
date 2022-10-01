using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int totalWinPoints = 0;
            int countWin = 0;

            for (int number = 1; number <= tournamentsCount; number++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":

                        points += 2000;
                        totalWinPoints += 2000;
                        countWin++;
                        break;

                    case "F":
                        points += 1200;
                        totalWinPoints += 1200;
                        
                        break;

                    case "SF":

                        points += 720;
                        totalWinPoints += 720;
                        
                        break;
                }

            }

            Console.WriteLine($"Final points: {points}");

            double average = (totalWinPoints * 1.0) / tournamentsCount; 
            Console.WriteLine($"Average points: {Math.Floor(average)}");

            double percent = countWin * 1.0 / tournamentsCount * 100;
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
