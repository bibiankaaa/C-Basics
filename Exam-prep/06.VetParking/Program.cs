using System;

namespace _06.VetParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());

            int dayCounter = 0;
            double daysTotal = 0;


            for (int day = 1; day <= countDays; day++)
            {
                double parkingPrice = 0;
                dayCounter++;

                for (int hour = 1; hour <= countHours; hour++)
                {
                    
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        parkingPrice += 2.50;
                        
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        parkingPrice += 1.25;
                    }
                    else
                    {
                        parkingPrice += 1.00;
                    }
                    
                }

                Console.WriteLine($"Day: {dayCounter} - {parkingPrice:f2} leva");
                daysTotal += parkingPrice;
            }

            Console.WriteLine($"Total: {daysTotal:f2} leva");
        }
    }
}
