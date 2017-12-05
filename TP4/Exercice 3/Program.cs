using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double n;
            double resultat;

            Console.WriteLine("Saisir un nombre entier");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir n");
            n = Convert.ToInt32(Console.ReadLine());

            resultat = Math.Pow(x, n);
            Console.WriteLine(resultat);
            Console.ReadLine();




                





        }
    }
}
