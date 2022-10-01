using System;

namespace _04.ComputerFirm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countComputers = int.Parse(Console.ReadLine());

            double totalSells = 0;
            double totalComputers = 0;
            

            for (int sells = 1; sells <= countComputers; sells++)
            {
                int modelSells = int.Parse(Console.ReadLine());
                string convertModelSells = modelSells.ToString();

                int raiting = modelSells % 10;
                string possibleSells = convertModelSells[0].ToString() + convertModelSells[1].ToString();
                totalComputers += raiting;


                if (raiting == 2)
                {
                    double carriedSells = Double.Parse(possibleSells) * 0.00;
                    totalSells += carriedSells;
                }
                if (raiting == 3)
                {
                    double carriedSells = Double.Parse(possibleSells) * 0.5;
                    totalSells += carriedSells;
                }
                if (raiting == 4)
                {
                    double carriedSells = Double.Parse(possibleSells) * 0.7;
                    totalSells += carriedSells;
                }
                if (raiting == 5)
                {
                    double carriedSells = Double.Parse(possibleSells) * 0.85;
                    totalSells += carriedSells;
                }
                if (raiting == 6)
                {
                    double carriedSells = Double.Parse(possibleSells);
                    totalSells += carriedSells;
                }
                
            }
            double average = totalComputers / countComputers;
            Console.WriteLine($"{totalSells:f2}");
            Console.WriteLine($"{average:f2}");

        }
    }
}
