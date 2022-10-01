using System;

namespace _07WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
           string weekDay = Console.ReadLine(); 

            if (number >= 10 && number <= 18)
            {
                switch (weekDay)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
