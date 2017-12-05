using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_6_Finances
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            double pu;
            int qtecom;
            double pap;
            int port;
            int remise;
            double txrem;
            double tot;
            string s;
            Console.WriteLine("Entrez la quantité du produit");
            qtecom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le prix unitaire du produit");
            pu = double.Parse(Console.ReadLine()); ;
            tot = qtecom * pu;
            Console.WriteLine("Le prix totale brut est de:" + tot);

            if (tot > 500)
            {
                Console.WriteLine("Le port est gratuit");



                

            }

            Console.ReadLine();
        }
    }
}
