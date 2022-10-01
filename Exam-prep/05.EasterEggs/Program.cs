using System;

namespace _05.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countColouredEggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = 0;
            string maxEggsColour = "";

            for (int i = 1; i <= countColouredEggs; i++)
            {
                string colour = Console.ReadLine();

                if (colour == "red")
                {
                    redEggs++;
                    if (redEggs > maxEggs)
                    {
                        maxEggs = redEggs;
                        maxEggsColour = "red";
                    }
                }
                else if (colour == "orange")
                {
                    orangeEggs++;
                    if (orangeEggs > maxEggs)
                    {
                        maxEggs = orangeEggs;
                        maxEggsColour = "orange";
                    }
                }
                else if (colour == "blue")
                {
                    blueEggs++;

                    if (blueEggs > maxEggs)
                    {
                        maxEggs = blueEggs;
                        maxEggsColour = "blue";
                    }
                }
                else if (colour == "green")
                {
                    greenEggs++;
                    if (greenEggs > maxEggs)
                    {
                        maxEggs = greenEggs;
                        maxEggsColour = "green";
                    }
                }
                

            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxEggsColour}");
        }
    }
}
