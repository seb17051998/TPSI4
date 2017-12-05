﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minMaxFonc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            int choix;
            bool ok = false;

            while (ok == false)
            {
                Console.WriteLine("1- Recherche du minimum");
                Console.WriteLine("2- Recherche du maximum");
                Console.WriteLine("3- Fin de programme");
                Console.WriteLine("Votre choix : ");
                choix = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Saisir le 1er nombre");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir le 2er nombre");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir le 3er nombre");
                        c = Convert.ToInt32(Console.ReadLine());

                        //Appel à la fonction Minimum
                        Minimum(a, b, c);
                        break;

                    case 2:
                        Console.WriteLine("Saisir le 1er nombre");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir le 2er nombre");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Saisir le 3er nombre");
                        c = Convert.ToInt32(Console.ReadLine());
                        //Appel à la fonction Maximum
                        Maximum(a, b, c);
                        break;
                    case 3:
                        ok = true;
                        break;
                }
            }
        }


        //Fonction : recherche du minimum
        static double Minimum(double a, double b, double c)
        {
            double min=0;
            if (a < b && a < c)
            {
                min = a;
                Console.WriteLine("Le minumum de {0}, {1}, {2} est {3}", a, b, c, min);
                
            }
            if (b < a && b < c)
            {
                min = b;
                Console.WriteLine("Le minumum de {0}, {1}, {2} est {3}", a, b, c, min);
                
            }
            if (c < a && c < b)
            {
                min = c;
                Console.WriteLine("Le minumum de {0}, {1}, {2} est {3}", a, b, c, min);
                
            }
            return min;
        }

        //Fonction : recherche du maximum
        static double Maximum(double a, double b, double c)
        {
            double max = 0;
            if (a > b && a > c)
            {
                max = a;
                Console.WriteLine("Le maximum de {0}, {1}, {2} est {3}", a, b, c, max);
            }
            if (b > a && b > c)
            {
                max = b;
                Console.WriteLine("Le maximum de {0}, {1}, {2} est {3}", a, b, c, max);
            }
            if (c > a && c > b)
            {
                max = c;
                Console.WriteLine("Le maximum de {0}, {1}, {2} est {3}", a, b, c, max);
            }
            return max;

        }
    }
}
