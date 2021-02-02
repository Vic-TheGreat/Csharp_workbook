using System;
/* Created By: Victoria ADEOYE
 * Simple app to display a verse of a song (99 shooters sans alcool) 
 * depending on the number shooters a user inputs, ranging from 0-99
 */
namespace RegleDuJour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenue! \n Entrez le numéro du couplet: ");

            //An int.TryParse, to catch exceptions if the user inputs a value that is not a real number.
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("\n Désolé, ce n'est pas un numéro de couplet valide. \n " +
                     "Veuillez saisir un nombre entre 0 et 99");
            }

            const int nMax = 99;

            /*when a number n is entered the verse below is displayed
              else if n is 1, no plurals. 
                   if n is 0, replace verse by 'plus de' */
            if (1<n && n<=99)
            {
                Console.WriteLine(n + " shooters sans alcool sur le mur, " + n + " shooters sans alcool.");
                Console.WriteLine("Bois en un et au suivant ! " + (n-1) + " shooters sans alcool sur le mur.");
            }
            else if (n==1)
            {
                Console.WriteLine(n + " shooter sans alcool sur le mur, " + n + " shooter sans alcool.");
            }
            else if (n==0)
            {
                Console.WriteLine("Plus de shooters sans alcool sur le mur, plus de shooters sans alcool.");
                Console.WriteLine("Vas au supermarché pour en acheter, " + nMax + " shooters sans alcool sur le mur.");
            }
            else
            {
                Console.WriteLine("Désolé, ce n'est pas un numéro de verset valide. Veuillez saisir un nombre entre 0 et 99 ");
            }

            Console.Read();
        }
    }
}
