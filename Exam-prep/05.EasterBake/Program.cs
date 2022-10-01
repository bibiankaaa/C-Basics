using System;

namespace _05.EasterBake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countKozunac = int.Parse(Console.ReadLine());

            double totalSugar = 0;
            double totalFloor = 0;
            double countPacketsSugar = 0;
            double countPacketsFloor = 0;
            double maxSugar = 0;
            double maxFloor = 0;

            for (int i = 1; i <= countKozunac; i++)
            {
                double usedSugar = double.Parse(Console.ReadLine());
                double usedFloor = double.Parse(Console.ReadLine());

                totalSugar += usedSugar;
                totalFloor += usedFloor;

                countPacketsSugar = Math.Ceiling(totalSugar / 950);
                countPacketsFloor = Math.Ceiling(totalFloor / 750);

                if (usedSugar > maxSugar)
                {
                    maxSugar = usedSugar;
                }
                if (usedFloor > maxFloor)
                {
                    maxFloor = usedFloor;
                }
            }
            Console.WriteLine($"Sugar: {countPacketsSugar}");
            Console.WriteLine($"Flour: {countPacketsFloor}");
            Console.WriteLine($"Max used flour is {maxFloor} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
