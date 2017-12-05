using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4_théorème_de_pythagore
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int c1;
            int c2;
            int c3;
            Console.WriteLine("Saisir L'hypothénuse");
            s = Console.ReadLine();
            c1 = Convert.ToInt32(s);
            Console.WriteLine("Saisir La base du triangle");
            s = Console.ReadLine();
            c2 = Convert.ToInt32(s);
            Console.WriteLine("Saisir La hauteur du triangle");
            s = Console.ReadLine();
            c3 = Convert.ToInt32(s);

            c1 = c1 * c1;
            c2 = c2 * c2 + c3 * c3;

            if (c2 == c1)
            {
                Console.WriteLine("Le triangle est rectangle");
            }
            else

                Console.WriteLine("Le triangle n'est pas rectangle");

            Console.ReadLine();





        }
    }
}
