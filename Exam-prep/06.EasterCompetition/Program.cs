using System;

namespace _06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countKozunak = int.Parse(Console.ReadLine());

            double bestPoints = 0;
            string bestBaker = "";
            



            for (int i = 1; i <= countKozunak; i++) 
            {
                string nameOfTheBaker = Console.ReadLine();
                double totalPoints = 0;
                string grades = "";

                while (grades != "Stop")
                {

                    grades = Console.ReadLine();

                    if (grades != "Stop")
                    {
                        int points = int.Parse(grades);
                        totalPoints += points;
                        
                    }
                    
                }
                Console.WriteLine($"{nameOfTheBaker} has {totalPoints} points.");

                if (grades == "Stop")
                {
                    if (totalPoints > bestPoints)
                    {
                        bestPoints = totalPoints;
                        bestBaker = nameOfTheBaker;
                        Console.WriteLine($"{nameOfTheBaker} is the new number 1!");

                    }
                    

                }

                

            }
            Console.WriteLine($"{bestBaker} won competition with {bestPoints} points!");
        }
    }
}
