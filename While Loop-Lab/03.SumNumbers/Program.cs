﻿using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            
            int sum = 0;


            while (number > sum)
            {
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
