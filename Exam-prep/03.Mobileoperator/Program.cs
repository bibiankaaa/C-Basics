using System;

namespace _03.Mobileoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string contractLenght = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileInt = Console.ReadLine();
            int paymentMonths = int.Parse(Console.ReadLine());

            double contractPrice = 0;


                if (contractLenght == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        contractPrice = 9.98;
                        break;
                    case "Middle":
                        contractPrice = 18.99;

                        break;
                    case "Large":
                        contractPrice = 25.98;
                        break;
                    case "ExtraLarge":
                        contractPrice = 35.99;
                        break;

                }
            }
                else if (contractLenght == "two")
            {
                switch (contractType)
                {
                    case "Small":
                        contractPrice = 8.58;
                        break;
                    case "Middle":
                        contractPrice = 17.09;
                        break;
                    case "Large":
                        contractPrice = 23.59;
                        break;
                    case "ExtraLarge":
                        contractPrice = 31.79;
                        break;

                }
            }
                if (mobileInt == "yes" && contractPrice <= 10.00)
            {
                contractPrice = contractPrice + 5.50;
            }
                else if (mobileInt == "yes" && contractPrice <= 30.00)
            {
                contractPrice = contractPrice + 4.35;
            }
                else if (mobileInt == "yes" && contractPrice > 30.00)
            {
                contractPrice = contractPrice + 3.85;
            }

             
           

            double totalPrice = paymentMonths * contractPrice;

            if (contractLenght == "two")
            {
                totalPrice *= 0.9625;
            }


            Console.WriteLine($"{totalPrice:F2} lv.");
                
            
                    
             
                  
                        

            

        }
    }
}
