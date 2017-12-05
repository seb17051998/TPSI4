using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPchaineDeCaractères
{
    class Program
    {
        static void Main(string[] args)
        {
            string identité;
            string[] elt = new string[2];
            int nbPersonnes;
            int nb = 0;

            Console.WriteLine("Saisir le nombre de personnes au max");
            nbPersonnes = Convert.ToInt32(Console.ReadLine());
            for (nb = 1; nb <= nbPersonnes; nb++)
            {
                Console.WriteLine("Saisir une identité");
                identité = Console.ReadLine();
                elt = identité.Split(' ');
                Console.WriteLine("prénom:{0} nom: {1}", elt[1], elt[0]);
            }




            Console.ReadLine();

        }
    }
}
