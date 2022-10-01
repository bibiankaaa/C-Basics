using System;

namespace _03.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesForHoliday = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
       
            switch (destination)
            {
                case "France":
                    switch (datesForHoliday)
                    {
                        case "21-23":
                            pricePerNight = nights * 30;
                            break;
                        case "24-27":
                            pricePerNight = nights * 35;
                            break;
                        case "28-31":
                            pricePerNight = nights * 40;
                            break;
                    }
                     
                    break;
                case "Italy":
                    switch (datesForHoliday)
                    {
                        case "21-23":
                            pricePerNight = nights * 28;
                            break;
                        case "24-27":
                            pricePerNight = nights * 32;
                            break;
                        case "28-31":
                            pricePerNight = nights * 39;
                            break;
                    }
                    break;
                case "Germany":
                        switch (datesForHoliday)
                        {
                          case "21-23":
                            pricePerNight = nights * 32;
                            break;
                         case "24-27":
                            pricePerNight = nights * 37;
                            break;
                         case "28-31":
                            pricePerNight = nights * 43;
                            break;
                        }
                    break;

            }
            Console.WriteLine($"Easter trip to {destination} : {pricePerNight:f2} leva.");

        }
    }
}
