using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_4_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int i;
            int j = 1;
            string Mes;
            int nbrepeat;
            int resultat = 0;
            double result = 0;
            double bornsup = 1;
            int resultatprec = 0;
            double x;
            double n;
            int choix = 0;


            while (choix <= 4)
            {
                Console.WriteLine("1 - réplication de message");
                Console.WriteLine("2 - somme des n premiers nombres entiers");
                Console.WriteLine("3 - somme des carrés des n premiers nombres entiers");
                Console.WriteLine("4 - élévation à la puissance (x n)");
                Console.WriteLine("5 - fin du programme");
                choix = Convert.ToInt32(Console.ReadLine());

                {

                    switch (choix)
                    {
                        case 1:
                            {

                                Console.WriteLine("Saisir un nombre entier dont le nombre de fois le message s'affichera :");
                                nbrepeat = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Saisir le message à afficher");
                                Mes = Console.ReadLine();

                                for (i = 1; i <= nbrepeat; i++)
                                {
                                    Console.WriteLine(Mes);
                                }

                                Console.ReadLine();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Saisir un nombre");
                                bornsup = Convert.ToInt32(Console.ReadLine());


                                while (j <= bornsup)
                                {
                                    resultat = resultatprec + j;
                                    j = j + 1;
                                    resultatprec = resultat;
                                }

                                Console.WriteLine(resultat);

                                Console.ReadLine();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Saisir un nombre");
                                bornsup = Convert.ToInt32(Console.ReadLine());

                                for (i = 1; i <= bornsup; i++)
                                {
                                    result = result + Math.Pow(i, 2);
                                }

                                Console.WriteLine(result);
                                Console.ReadLine();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Saisir un nombre entier");
                                x = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Saisir n");
                                n = Convert.ToInt32(Console.ReadLine());

                                result = Math.Pow(x, n);
                                Console.WriteLine(result);
                                Console.ReadLine();
                                break;
                            }

                        case 5:
                            {
                                break;

                            }


                    }
                }
            }
                



            
            
        }
    }
}
