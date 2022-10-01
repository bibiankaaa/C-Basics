using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogsFood = 2.50;
            double catsFood = 4;

            int countDogsFood = int.Parse(Console.ReadLine());
            int countCatsFood = int.Parse(Console.ReadLine());

            double totalDogs = dogsFood * countDogsFood;
            double totalCats = catsFood * countCatsFood;

            Console.WriteLine(totalCats + totalDogs + " lv.");

        }
    }
}
