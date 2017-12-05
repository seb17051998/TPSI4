using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2_Carré
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultat = 0;
            double bornsup = 1;
            int i = 1;

            Console.WriteLine("Saisir le nombre de fois va se calculer");
            bornsup = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= bornsup; i++)
            {
                resultat = resultat + Math.Pow(i, 2);
            }

            Console.WriteLine(resultat);
            Console.ReadLine();

        }
    }
}
