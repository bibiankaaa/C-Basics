using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            
            
            double pieces = width * lenght;
            int piecesTaken = 0;

            while (pieces > 0)
            {
                               
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                if (input != "STOP")
                {
                    piecesTaken = int.Parse(input);
                    pieces -= piecesTaken;
                    
                }

            }
            if (pieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
             
        }
    }
}
