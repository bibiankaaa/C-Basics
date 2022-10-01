using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < 100 && number != 0) || number > 200)
            {
               Console.WriteLine("invalid");
            }
             
            
        }
    }
}
