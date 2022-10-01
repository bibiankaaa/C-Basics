using System;

namespace _05.HairSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string action = "";
            double income = 0;
            double totalIncome = 0;

            while (action != "closed")
            {
                action = Console.ReadLine(); 

                switch (action)
                {
                    case "haircut":
                        string typeOfHairCut = Console.ReadLine();

                        switch (typeOfHairCut)
                        {
                            case "mens":
                                income = 15;
                                totalIncome += income;
                                break;
                            case "ladies":
                                income = 20;
                                totalIncome += income;
                                break;
                            case "kids":
                                income = 10;
                                totalIncome += income;
                                break;
                        }
                        break;
                    case "color":
                        string typeOfcolor = Console.ReadLine();

                        switch (typeOfcolor)
                        {
                            case "touch up":
                                income = 20;
                                totalIncome += income;
                                break;
                            case "full color":
                                income = 30;
                                totalIncome += income;
                                break;
                        }

                        break;
                }

                if (target <= totalIncome)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {totalIncome}lv.");
                    break;
                }


            }
            
            
                double diff = Math.Abs(target - totalIncome);

                
                if (target > totalIncome)
                {
                    Console.WriteLine($"Target not reached! You need {diff}lv. more.");
                    Console.WriteLine($"Earned money: {totalIncome}lv.");
                }
            
            
            
        }
    }
}
