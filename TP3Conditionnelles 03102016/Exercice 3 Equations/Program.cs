using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3_Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double a;
            double b;
            char c = 'o'; 


            while(c == 'o')
            {


                Console.WriteLine("Donner a: ");
                nombre = Console.ReadLine();
                a = Convert.ToDouble(nombre);
                Console.WriteLine("Donner b: ");
                nombre = Console.ReadLine();
                b = Convert.ToDouble(nombre);
                if (a != 0)
                {
                    Console.WriteLine("La solution est : " + (-b / a));
                }
                else
                {
                    if (b == 0)
                    {
                    }
                    else
                    {
                    }
                    Console.WriteLine("Voulez vous recommencer, tapez oui si vous voulez refaire l'équation, tapez non si vous voulez quitter.");
                    c = char.Parse(Console.ReadLine());
                    Console.ReadLine();

                }
                

            }

            






        }
    }
}
