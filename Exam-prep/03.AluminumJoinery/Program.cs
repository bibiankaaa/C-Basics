using System;

namespace _03.AluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countJoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string delivery = Console.ReadLine();

            
            double priceForJoinery = 0;
            double priceWithDisscount = 0;

            
            switch (typeJoinery)
            {
                case "90X130":

                    priceForJoinery = 110 * countJoinery;
                    
                    if (countJoinery >= 30 && countJoinery <= 60)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.05);
                    }
                    else if (countJoinery > 60)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.08);
                    }
                    break;
                case "100X150":

                    priceForJoinery = 140 * countJoinery;

                    if (countJoinery >= 40 && countJoinery <= 80)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.06);
                    }
                    else if (countJoinery > 80)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.1);
                    }
                    break;
                case "130X180":

                    priceForJoinery = 190 * countJoinery;

                    if (countJoinery >= 20 && countJoinery <= 50)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.07);
                    }
                    else if (countJoinery > 50)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.12);
                    }
                    break;

                case "200X300":

                    priceForJoinery = 250 * countJoinery;

                    if (countJoinery >= 25 && countJoinery <= 50)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.09);
                    }
                    else if (countJoinery > 50)
                    {
                        priceWithDisscount = priceForJoinery - (priceForJoinery * 0.14);
                    }
                    break;
            }

            

            if (delivery == "With delivery")
            {
                priceWithDisscount += 60;
            }
            

            if (countJoinery > 99)
            {
                priceWithDisscount = priceWithDisscount - (priceWithDisscount * 0.04);
            }

            if (countJoinery < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{priceWithDisscount:f2} BGN");
            }
            
        }
    }
}
