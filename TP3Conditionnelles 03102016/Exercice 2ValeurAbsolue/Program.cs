using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2ValeurAbsolue
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int a;
            int b;
            int resultat;
            Console.WriteLine("Donner le premier entier");            
            nombre = Console.ReadLine();
            a = Convert.ToInt32(nombre);
            Console.WriteLine("Donner le deuxième entier");
            nombre = Console.ReadLine();
            b = Convert.ToInt32(nombre);

            if (a > b) 
            {
                resultat = a-b;
                Console.WriteLine("Le résultat est " + resultat);
            }
            if (b > a)
            {
                resultat = b - a;
                Console.WriteLine("Le résultat est " + resultat);
            }

            Console.ReadLine();

            

            
            
            





        }
    }
}
