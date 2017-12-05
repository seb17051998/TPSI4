using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3Conditionnelles
{
    class Program
    {
        static void Main(string[] args)
        {
            string couleur;
            Console.WriteLine("Indiquer la couleur du feu");
            couleur = Console.ReadLine();



            if (couleur == "rouge")
            {
                Console.WriteLine("Veuillez vous arrêter");
            }
            
            if (couleur == "orange")
            {
                Console.WriteLine("Veuillez ralentir puis vous arrêter");
            }
            
            if (couleur == "vert")
            
            {
                Console.WriteLine("Vous pouvez avancer");
            }

            Console.ReadLine();
             











        }
    } 
}
