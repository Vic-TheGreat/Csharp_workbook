using System;
using System.Text;

namespace word_scrabble2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        } //main

        public static string NewPassword(string a, string b)
        {
            //a = "zbxnsjdns"; b = "idowdk";

            if (a == null && b == null)
            {
                return null;
            }

            if (a == null)
            {
                a = string.Empty;
            }

            if (b == null)
            {
                b = string.Empty;
            }

            int shortLength = a.Length > b.Length ? b.Length : a.Length;

            if (shortLength == 0 && a.Length == shortLength)
            {
                return b;
            }
            else if (shortLength == 0 && b.Length == shortLength)
            {
                return a;
            }

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < shortLength; i++)
            {
                stringBuilder.Append(a[i]).Append(b[i]);
            }

            if (a.Length > b.Length)
            {
                stringBuilder.Append(a, shortLength, a.Length - shortLength);
            }
            else if (b.Length > a.Length)
            {
                stringBuilder.Append(b, shortLength, b.Length - shortLength);
            }

            return stringBuilder.ToString();

        }  //new pwd

    } //program class
}
