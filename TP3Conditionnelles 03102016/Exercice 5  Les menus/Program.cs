using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_5__Les_menus
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix;
            double a, b, c;
            int s;
            int d;


            Console.WriteLine("Quel est votre choix (entrez un nombre entre 1 et 4)");
            Console.WriteLine("1 Somme");
            Console.WriteLine("2 Quotient");
            Console.WriteLine("3 Moyenne");
            Console.WriteLine("4 Produit");
            s = int.Parse(Console.ReadLine());



            switch (s)
            {
                case 1:
                    {
                        Console.WriteLine("Taper a");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tapez b");
                        b = double.Parse(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Le résultat de l'addition est :" + c);
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {

                        Console.WriteLine("Taper a");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tapez b");
                        b = double.Parse(Console.ReadLine());
                        c = (a / b);
                        Console.WriteLine("Le résultat de la division est:" + c);
                        Console.ReadLine();
                        break;

                    }
                case 3:
                    {

                        Console.WriteLine("Taper a");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tapez b");
                        b = double.Parse(Console.ReadLine());
                        c = (a + b / 2);
                        Console.WriteLine("La moyenne est:" + c);
                        Console.ReadLine();
                        break;

                    }
                case 4:
                    {

                        Console.WriteLine("Taper a");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tapez b");
                        b = double.Parse(Console.ReadLine());
                        c = (a * b);
                        Console.WriteLine("Le résultat de la multiplication est:" + c);
                        Console.ReadLine();
                        break;

                    }
            }
        }
    }
}
