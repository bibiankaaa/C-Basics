using System;

namespace _05.DivisionWithoutRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int num = 1; num <= n; num++)
            {
                 int value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    count1++;
                }
                if (value % 3 == 0)
                {
                    count2++;
                }
               if (value % 4 == 0)
                {
                    count3++;
                }
                
            }
            double p1 = count1 * 1.0 / n * 100;
            double p2 = count2 * 1.0 / n * 100;
            double p3 = count3 * 1.0 / n * 100;


            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");



        }
    }
}
