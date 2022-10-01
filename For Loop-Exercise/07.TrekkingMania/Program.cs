using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int group = 1; group <= groupCount; group++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());  

                if (peopleInGroup <= 5)
                {
                    count1 += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    count2 += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    count3 += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    count4 += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    count5 += peopleInGroup;
                }
            }

            int total = count1 + count2 + count3 + count4 + count5;

            double p1 = count1 * 1.0 / total * 100;
            double p2 = count2 * 1.0 / total * 100;
            double p3 = count3 * 1.0 / total * 100;
            double p4 = count4 * 1.0 / total * 100;
            double p5 = count5 * 1.0 / total * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
