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
                    Console.Write(Char.ConvertFromUtf32(word1[i]) + Char.ConvertFromUtf32(word2[i]));
                     //Console.Write(Char.ToUpper(word1[i]) + Char.ToLower(word2[i]));
                   //why does concatenating that gives int but string when not concat~ed
                }
            }
            else
            {
                Console.WriteLine("Unequal string!");

            }

        }
    }
}
