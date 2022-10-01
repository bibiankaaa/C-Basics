using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysForStay = int.Parse(Console.ReadLine()); 
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
            double finalPrice = 0;

            double nights = daysForStay - 1;
                
            switch (room)
            {
                case "room for one person":
                    price = nights * 18.00;
                    break;
                case "apartment":
                    
                    if (nights < 10)
                    {
                        price = (nights * 25.00) * 0.7;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        price = (nights * 25.00) * 0.65;
                    }
                    else if (nights > 15)
                    {
                        price = (nights * 25.00) * 0.5;
                    }
                    break;
                case "president apartment":

                    if (nights < 10)
                    {
                        price = (nights * 35.00) * 0.9;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        price = (nights * 35.00) * 0.85;
                    }
                    else if (nights > 15)
                    {
                        price = (nights * 35.00) * 0.80;
                    }
                    break;

            }
            if (grade == "positive")
            {
                finalPrice = price * 1.25;
            }
            else if (grade == "negative")
            {
                finalPrice = price * 0.9;
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
