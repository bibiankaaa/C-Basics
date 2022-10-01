using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();
            
            int mostGols = 0;
            string bestPlayer = "";

            while (nameOfPlayer != "END")
            { 
             
                int gols = int.Parse(Console.ReadLine());

                if (gols > mostGols)
                {
                    mostGols = gols;
                    bestPlayer = nameOfPlayer;                                       
                }

                if (mostGols >= 10)
                {
                    break;
                }
                                           
                nameOfPlayer = Console.ReadLine();                
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (mostGols >= 3)
            {
                Console.WriteLine($"He has scored {mostGols} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostGols} goals.");
            }


        }
    }
}
