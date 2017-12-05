using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3DivisionEuclidienneSansVirgule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclatation des variables
            int quotient;
            int dividende;
            int diviseur;
            int reste;

            //Saisit par l'utilisateur (Dividende,Diviseur)
            Console.WriteLine("Veuillez saisir le nombre d'alumettes (la dividende)");
            dividende = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre de boites d'allumettes (le diviseur)");
            diviseur = Convert.ToInt32(Console.ReadLine());

            //Calcul du quotient
            quotient = dividende / diviseur;

            //Calcul du reste
            reste = dividende % diviseur;

            //Affichage des résultats
            Console.WriteLine("Boites pleines (quotient) : " + quotient);
            Console.WriteLine("Alumettes Restant : " + reste);

            Console.ReadLine();



        }
    }
}
