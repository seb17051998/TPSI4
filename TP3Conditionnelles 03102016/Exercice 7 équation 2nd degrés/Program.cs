using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_7_équation_2nd_degrés
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta;
            double x1;
            double x2;
            char rep = 'o';

            while (rep == 'o') 
            {
                Console.WriteLine("On souhaite calculer ax²+bx+c = 0");
                Console.WriteLine("Taper a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Taper b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Taper c");
                c = int.Parse(Console.ReadLine());

               
                delta = Math.Pow(b, 2) - 4 * (a) * (c);
                Console.WriteLine("Delta est égal à:" + delta);
                if (delta < 0)
                {
                    Console.WriteLine("L'équation ne possède aucune solution dans R");
                }
                if (delta == 0)
                {
                    Console.WriteLine("L'équation possède donc 1 solution");
                    x1 = (-b) / (2 * (a));
                    Console.WriteLine("Donc S=" + x1);
                }
                if (delta > 0)
                {
                    Console.WriteLine("L'équation possède donc 2 solutions");
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1=" + x1);
                    Console.WriteLine("x2=" + x2);
                }




                Console.WriteLine("Voulez vous recommencez ?, taper o pour recommencer ou n pour quitter  (Appuyez 2 fois sur entrée):");
                rep = char.Parse(Console.ReadLine());

                Console.ReadLine();
            }
        }
    }
}
