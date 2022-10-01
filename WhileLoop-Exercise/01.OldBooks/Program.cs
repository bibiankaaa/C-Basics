using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string input = Console.ReadLine();
            int count = 0;

            while (input != "No More Books")
            {
               
                if (favBook == input)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;
               input = Console.ReadLine();

                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }
            }

            
        }
    }
}
