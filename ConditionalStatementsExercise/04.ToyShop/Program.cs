using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double puzzle = 2.60;
            double talkingDoll = 3.00;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2.00;
            double discount = 0.0;
            

            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());     
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
        
            double sum = puzzle * puzzleCount + talkingDoll * talkingDollsCount + teddyBear * teddyBearCount + minion * minionCount + truck * truckCount;
            int toysCount = puzzleCount + talkingDollsCount + teddyBearCount + minionCount + truckCount;

            if (toysCount >= 50)
            {
                discount = sum * 0.25;
                sum = sum - discount;
            }

            double rent = sum * 0.1;

            double win = sum - rent;

            if (win >= holidayPrice)
            {
                double moneyLeft = win - holidayPrice;

                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else 
            {
                double leftMoney = holidayPrice - win;

                Console.WriteLine($"Not enough money! {leftMoney:f2} lv needed.");
            }


            

    }   }
}
