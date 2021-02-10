/* By: VicTheGreat
simple app that generates a password from 2 words, A & B.
SPECIFICATIONS:
1) Password is generated from combining the characters in each word from the same position.
ex: if A = Mom & B = Dad, i.e password = MDoamd
2) If words are not of the same length, then the extra length is added after the equal lengths are combined as (1) above
ex: if A = Mummy & B = Dad, password = MDuamdmy
 */

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
            Console.Write("Please enter word 1: ");
            string word1 = Console.ReadLine(); 
            Console.Write("Please enter word 2: ");
            string word2 = Console.ReadLine();
            Console.WriteLine();

            if (word1.Length == word2.Length)
            {
                Console.Write("Password is : ");
                for (int i = 0; i < word1.Length; i++)
                {
                    //Console.Write(Char.ConvertFromUtf32(word1[i]) + Char.ConvertFromUtf32(word2[i]));
                    Console.Write(word1[i]);
                    Console.Write(word2[i]);
                }
                Console.WriteLine();
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
