using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double assesment = double.Parse(Console.ReadLine());

            int dissmised = 0;
            int grade = 1;
            double sum = 0;
            

            while (grade <= 12)
            {
                
               

                if (assesment < 4.00)
                {
                    dissmised++;
                    
                    if (dissmised == 2)
                    {
                        grade--;
                        
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }                 
                sum += assesment;
                double average = sum / 12;
                grade++;

                if (grade > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
                    break;
                }
                assesment = double.Parse(Console.ReadLine());
            }

           

            

        }
    }
}
