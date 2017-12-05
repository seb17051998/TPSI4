using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultatprec =0;
            int resultat = 0;
            int bornsup = 1;
            int i = 1;
            
            

            Console.WriteLine("Saisir le nombre de fois va se calculer");
            bornsup = Convert.ToInt32(Console.ReadLine());


            while (i <= bornsup)
            {
                resultat = resultatprec + i;
                i = i + 1;
                resultatprec = resultat;
            }
                    
                        Console.WriteLine(resultat);
                        
                        Console.ReadLine();
                        
                    
            
        }
    }
}
