using System;

namespace _07.AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = (Console.ReadLine());

            // · Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му
            //· Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му
            //· Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга
            //· Ако фигурата е триъгълник(triangle): на следващите два реда
            //    четат две дробни числа -дължината на страната му и дължината на височината към нея
            //Резултатът да се закръгли до 3 цифри след десетичната запетая.

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = sideA * sideB;
                Console.WriteLine($"{result:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double finalResult = radius * radius * Math.PI;
                Console.WriteLine($"{finalResult:f3}");
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = sideA * sideB / 2;
                Console.WriteLine($"{result:f3}");
            }
                
        }
    }
}
