using System;

namespace _01.CatDiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentFats = int.Parse(Console.ReadLine());
            int percentProteins = int.Parse(Console.ReadLine());
            int percentCarbs = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percentWater = int.Parse(Console.ReadLine());

            double totalGramsOfFat = totalCalories * (double)percentFats / 100 / 9;
            double totalGramsProtein = totalCalories * (double)percentProteins / 100 / 4;
            double totalGramsCarbs = totalCalories * (double)percentCarbs / 100 / 4;

            double foodWeight = totalGramsOfFat + totalGramsProtein + totalGramsCarbs;

            double caloriesForOneGramFood = totalCalories / foodWeight;

            double waterInCalories = 100 - percentWater;

            double total = caloriesForOneGramFood * waterInCalories / 100;

            Console.WriteLine($"{total:f4}");
        }
    }
}
