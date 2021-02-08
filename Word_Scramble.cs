/* Created by VicTheGreat */
using System;

namespace word_scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Mum";
            string word2 = "dAd";

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word1[i]));
                    Console.Write(Char.ConvertFromUtf32(word2[i]));
                }
            }
            else
            {
                Console.WriteLine("Unequal string!");

            }

        }
    }
}
