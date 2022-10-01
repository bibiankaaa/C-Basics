using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string month = Console.ReadLine();
           int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            double priceForStudio = 0;
            double priceForApartment = 0;

            //Май и октомври                   Юни и септември                              Юли и август
            //Студио – 50 лв./ нощувка         Студио – 75.20 лв./ нощувка                 Студио – 76 лв./ нощувка
            //Апартамент – 65 лв./ нощувка      Апартамент – 68.70 лв./ нощувка          Апартамент – 77 лв./ нощувка

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;

                if (nights > 7 && nights < 14)
                {
                    studio = 50 * 0.95;
                }
                else if (nights > 14)
                {
                    studio = 50 * 0.70;
                    apartment = 65 * 0.90;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;

                if (nights > 14)
                {
                    studio = 75.20 * 0.8;
                    apartment = 68.70 * 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;

                if (nights > 14)
                {
                    apartment = 77 * 0.90;
                }
            }

            priceForStudio = studio * nights;
            priceForApartment = apartment * nights;

            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
           
            
                
            
            
        }
    }
}
