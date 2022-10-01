using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            


            int solvedProblemsCount = 0;
            
            
            int dissmised = 0;
            double totalAssesments = 0;
            string lastTask = "";
            bool isFailed = true;

            while (dissmised < poorGrades)
            {
                string nameOfTheTask = Console.ReadLine();

                if ("Enough" == nameOfTheTask)
                {
                    isFailed = false;
                    break;
                }

                int assesment = int.Parse(Console.ReadLine());
              
                if (assesment <= 4.00)
                {
                    dissmised++;                    
                }


                solvedProblemsCount++;
                totalAssesments += assesment;
                lastTask = nameOfTheTask;
                              
            }        
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {dissmised} poor grades.");
            }

            else 
            {
                Console.WriteLine($"Average score: {totalAssesments / solvedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

            

        }
    }
}
