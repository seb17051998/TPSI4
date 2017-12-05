using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4PermutationDeValeur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            string a;
            string b;
            string result;

            //Saisit par l'utilisateur
            Console.WriteLine("Saisir a: ");
            a = Console.ReadLine();
            Console.WriteLine("Saisir b: ");
            b = Console.ReadLine();

            //Permutation de valeur
            result = a + b;

            //affichage du résulat
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
