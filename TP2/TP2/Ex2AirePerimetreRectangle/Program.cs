using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2AirePerimetreRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
                //x est la largeur
                //y est la longueur
            double x, y;
            double aire;
            double périmètre;

            //Saisit des dimensions par l'utilisateur
            Console.WriteLine("Saisir la longueur du rectangle en cm");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saisir la largeur du rectangle en cm");
            x = Convert.ToDouble(Console.ReadLine());

            //Rappel longueur largeur du rectangle
            Console.WriteLine("Longueur : " + y);
            Console.WriteLine("Largeur : " + x);

            //Calcul de l'aire du rectangle (y=longueur, x=largeur)
            aire = y * x;
            Console.WriteLine("L'aire du rectangle est de {0} cm²",aire);

            //Calcul du périmètre du rectangle 
            périmètre = y + x + y + x;
            Console.WriteLine("Le périmètre du rectangle est de {0} cm",périmètre);

            Console.ReadLine();

        }
    }
}
