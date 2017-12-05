using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversionKmMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            double miles;
            double km;

            //Saisit des kilomètres par l'utilisateur
            Console.WriteLine("Saisir le nombres de kilomètres à convertir en miles : ");
            km = Convert.ToDouble(Console.ReadLine());

            //Calcul pour convertir les km en miles
            miles = km * 0.62137;

            //Affichage du résultat
            Console.WriteLine("{0}km en miles est de {1} miles",km,miles);
            Console.ReadKey();
        }
    }
}
