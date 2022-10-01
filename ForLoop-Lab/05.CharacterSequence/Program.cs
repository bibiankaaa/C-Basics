using System;

namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;

            for (int value = 0; value <= wordLength - 1; value++)
            {
                Console.WriteLine(word[value]);
            }
        }
    }
}
