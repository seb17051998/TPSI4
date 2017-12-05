using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string Mes;
            int nbrepeat;

            Console.WriteLine("Saisir un nombre entier dont le nombre de fois le message s'affichera :");
            nbrepeat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir le message à afficher");
            Mes = Console.ReadLine();

            for(i=1;i <=  nbrepeat; i++) 
            {
                Console.WriteLine(Mes);
            }

            Console.ReadLine();
        }
    }
}
