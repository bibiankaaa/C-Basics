using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jugesCount = int.Parse(Console.ReadLine());
            double pointsFormation = academyPoints;

            
          

            for (int judge = 1; judge <= jugesCount; judge++)
            {

                string jugesNames = Console.ReadLine();
                double jugesPoints = double.Parse(Console.ReadLine());

                int length = jugesNames.Length;

                pointsFormation += (length * jugesPoints) / 2;

                if (pointsFormation > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFormation:f1}!");
                    break;
                }
            }
            if (pointsFormation < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - pointsFormation):f1} more!");
            }
            
;
        }
    }
}
