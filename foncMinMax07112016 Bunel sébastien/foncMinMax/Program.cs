 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foncMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
              // variables locales à l’algorithme MINMAX 

            double N1 = 0, N2 = 0, N3 = 0, min, max;
            bool ok;
            int choix = 0;
            string s;
        
          
            
            // premier affichage du menu
            Console.WriteLine("1 : rechercher le minimum");
            Console.WriteLine("2 : rechercher le maximum");
            Console.WriteLine("3 : fin du programme");
            // saisie du choix
            ok = false;
            while (!ok || choix < 1 || choix > 3)
            {
                Console.WriteLine("donnez votre choix");
                ok = Int32.TryParse(Console.ReadLine(), out choix);
            }
            // boucle de traitement
            while (choix != 3)
            {
                //  Saisie des trois nombres 
                ok = false;
                while (!ok)
                {
                    Console.WriteLine("saisir un premier nombre réel");
                    ok = Double.TryParse(Console.ReadLine(), out N1);
                }
                ok = false;
                while (!ok)
                {
                    Console.WriteLine("saisir un deuxième nombre");
                    s = Console.ReadLine();
                    ok = Double.TryParse(s, out N2);
                }
                ok = false;
                while (!ok)
                {
                    Console.WriteLine("saisir un troisième nombre");
                    ok = Double.TryParse(Console.ReadLine(), out N3);
                }

                //  réalisation du choix 
                switch (choix)
                {
                    //  cas recherche du minimum
                    case 1:
                        min = N1;
                        if (N2 < min)
                            min = N2;
                        if (N3 < min)
                            min = N3;
                        Console.WriteLine("Le minimum des 3 nombres {0}, {1}, {2} est : {3}", N1, N2, N3, min);
                        break;
                    //  cas recherche du maximum
                    case 2:
                        max = N1;
                        if (N2 > max)
                           max = N2;
                        if (N3 > max)
                           max = N3;
            Console.WriteLine("Le maximum des 3 nombres {0}, {1}, {2} est : {3}", N1, N2, N3, max);
                        break;
                    case 3:
                        Console.WriteLine("fin du programme");
                        break;
                    default:
                        Console.WriteLine("choix erroné");
                        break;

                }
                //  afficher le menu pour recommencer
               
                 Console.WriteLine("1 : rechercher le minimum");
                 Console.WriteLine("2 : rechercher le maximum");
                 Console.WriteLine("3 : fin du programme");
                 // saisie du choix
                 ok = false;
                 while (!ok || choix < 1 || choix > 3)
                 {
                     Console.WriteLine("donnez votre choix");
                     ok = Int32.TryParse(Console.ReadLine(), out choix);
                 }
               
            }
        }

         
    }
}


