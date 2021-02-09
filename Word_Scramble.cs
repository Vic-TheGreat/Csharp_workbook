/* By: VicTheGreat  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace word_scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Mum";
            string word2 = "dAd12";

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word1[i]) + Char.ConvertFromUtf32(word2[i]));
                   //Console.Write(Char.ToUpper(word1[i]) + Char.ToLower(word2[i]));
                   //why does concatenating that gives int but string when not concat~ed
                }
            }
            else if (word1.Length > word2.Length)
            {
                //'Except' is a LINQ fuction to compare diiferences in strings. always put the larger string on the left
                //char[] ss = word1.Except(word2).ToArray();
                //string diff = new string(ss);
                //OR  difference = word2.Except(word1).ToArray();

                for (int i = 0; i < word2.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word1[i]) + Char.ConvertFromUtf32(word2[i]));
                }
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word1[i]));      //add excess xters
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word1[i]) + Char.ConvertFromUtf32(word2[i]));
                }
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    Console.Write(Char.ConvertFromUtf32(word2[i]));      //add excess xters
                }
                Console.WriteLine();
            }

        }
    }
}
