using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            

            for (int i = startNumber; i <= endNumber; i++)
            {
                string number = i.ToString();
                double odd = 0;
                double even = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int currentDigit = int.Parse(number[j].ToString());

                    if (j % 2 == 0)
                    {
                        odd += currentDigit;
                    }
                    else
                    {
                        even += currentDigit;                      
                    }
                }
                if (even == odd)
                {
                    Console.WriteLine($"{i} ");
                }
            }


        }
                       
    }
}
