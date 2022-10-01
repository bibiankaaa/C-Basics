using System;

namespace _02.DeerofSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int santaDaysMissing = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double foodForFirstDeer = double.Parse(Console.ReadLine());
            double foodForSecondDeer = double.Parse(Console.ReadLine());
            double foorForThirdDeer = double.Parse(Console.ReadLine());

            double firstDeer = santaDaysMissing * foodForFirstDeer;
            double secondDeer = santaDaysMissing * foodForSecondDeer;
            double thirdDeer = santaDaysMissing * foorForThirdDeer;

            double totalFoodNeeded = firstDeer + secondDeer + thirdDeer;

            double diff = Math.Abs(totalFoodNeeded - foodLeftInKg);

            if (totalFoodNeeded <= foodLeftInKg)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
