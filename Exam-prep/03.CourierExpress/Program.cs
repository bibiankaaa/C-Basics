using System;

namespace _03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parcelKg = double.Parse(Console.ReadLine());
            string typeOfService = Console.ReadLine();
            int distanceInKm = int.Parse(Console.ReadLine());

            double priceForDelivery = 0;
            

            
            
            if(parcelKg < 1)
            {
                priceForDelivery = distanceInKm * 0.03;
                
                 if (typeOfService == "express")
                {
                    priceForDelivery += ((0.8 * 0.03) * parcelKg) * distanceInKm;
                }
            }
            else if (parcelKg >= 1 && parcelKg < 10)
            {
                priceForDelivery = distanceInKm * 0.05;

                if (typeOfService == "express")
                {
                    priceForDelivery += ((0.4 * 0.05) * parcelKg) * distanceInKm;
                }
            }
            else if (parcelKg >= 10 && parcelKg < 40)
            {
                priceForDelivery = distanceInKm * 0.10;

                if (typeOfService == "express")
                {
                    priceForDelivery += ((0.05 * 0.1) * parcelKg) * distanceInKm;
                }
            }
            else if (parcelKg >= 40 && parcelKg < 90)
            {
                priceForDelivery = distanceInKm * 0.15;

                if (typeOfService == "express")
                {
                    priceForDelivery += ((0.02 * 0.15) * parcelKg) * distanceInKm;
                }
            }
            else if (parcelKg >= 90 && parcelKg < 150)
            {
                priceForDelivery = distanceInKm * 0.20;

                if (typeOfService == "express")
                {
                    priceForDelivery += ((0.1 * 0.20) * parcelKg) * distanceInKm;
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {parcelKg:f3} kg. would cost {priceForDelivery:f2} lv.");
            
        }
    }
}
