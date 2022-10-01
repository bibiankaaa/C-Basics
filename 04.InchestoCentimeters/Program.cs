using System;

namespace _04.InchestoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double inches = 2.54;
            double centimeters = number * inches;

            Console.WriteLine(centimeters);


        }
    }
}
