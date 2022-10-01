using System;

namespace _06.Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


                int inputK = int.Parse(Console.ReadLine());
                int inputL = int.Parse(Console.ReadLine());
                int inputM = int.Parse(Console.ReadLine());
                int inputN = int.Parse(Console.ReadLine());

                int maxChanges = 0;

                
                
                    string firstNumber = "";
                    string secondNumber = "";

                    for (int i = inputK; i <= 8; i++)
                    {
                        if (i % 2 == 0)
                        {
                            for (int j = 9; j >= inputL; j--)
                            {
                                if (j % 2 != 0)
                                {
                                    firstNumber = i.ToString() + j.ToString();

                                for (int k = inputM; k <= 8; k++)
                                {
                                    if (k % 2 == 0)
                                    {
                                        for (int m = 9; m >= inputN; m--)
                                        {
                                            if (m % 2 != 0)
                                            {
                                                secondNumber = k.ToString() + m.ToString();

                                                if (firstNumber != secondNumber && maxChanges <= 5)
                                                {
                                                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                                                maxChanges++;
                                                    
                                                }
                                                else if (firstNumber == secondNumber && maxChanges <=5)
                                                {
                                                    Console.WriteLine("Cannot change the same player.");
                                                }
                                            }
                                        }
                                    }

                                }
                            }

                                

                            }
                        }

                    }


                

            }
        }
    }

    

