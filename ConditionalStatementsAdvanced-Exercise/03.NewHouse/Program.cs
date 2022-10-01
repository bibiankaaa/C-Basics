using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());
            double price = 0.0;
            

            //Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            //Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            switch (flowersType)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3.00;
                    break;
                case "Gladiolus":
                    price = 2.50; 
                    break;
                    
            }
            double finalPrice = count * price;

            if (flowersType == "Roses" && count > 80)
            {
                finalPrice *= 0.9;
            }
            else if (flowersType == "Dahlias" && count > 90)
            {
                finalPrice *= 0.85;
            }
            else if (flowersType == "Tulips" && count > 80)
            {
                finalPrice *= 0.85;
            }
            else if (flowersType == "Narcissus" && count < 120)
            {
                finalPrice *= 1.15;
            }
            else if (flowersType == "Gladiolus" && count < 80)
            {
                finalPrice *= 1.2;
            }
             
            double difference = Math.Abs(finalPrice - buget);

            if (buget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowersType} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
