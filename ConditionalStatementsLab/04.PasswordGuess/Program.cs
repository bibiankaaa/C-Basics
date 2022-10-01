using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            const string PASSWORD = "s3cr3t!P@ssw0rd";

            string word = (Console.ReadLine());


            if (word == PASSWORD)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }

            

        }
    }
}
