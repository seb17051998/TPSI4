using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace utilisationClasseVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables
            string s;
            Voiture vehicule;
            string constct;
            string model;
            string nimmatr;
            DateTime mcirc;
            int np=0;
            int enrg=0;
            decimal prx=0;
            int capac=0;
            bool ok;
            // instructions pour utiliser la voiture
            // saisie des caractéristiques
            Console.WriteLine("saisir le constructeur");
            constct = Console.ReadLine();
            Console.WriteLine("saisir le model");
            model = Console.ReadLine();
            Console.WriteLine("saisir le numéro d'immatriculation");
            nimmatr = Console.ReadLine(); 
            mcirc = new DateTime(2016, 11, 30);
            ok = false;
            while (!ok)
            {
                Console.WriteLine("saisir le nombre de portes");
                ok = Int32.TryParse(Console.ReadLine(), out np);
            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("saisir l'énergie");
                Console.WriteLine("1- Essence");
                Console.WriteLine("2- Diesel");
                Console.WriteLine("3- GPL");
                Console.WriteLine("4- Electrique");
                ok = Int32.TryParse(Console.ReadLine(), out enrg);
            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("saisir le prix");
                ok = Decimal.TryParse(Console.ReadLine(), out prx);
            }
            while (!ok)
            {
                Console.WriteLine("saisir la capacité du réservoir");
                ok = Int32.TryParse(Console.ReadLine(), out capac);
            }
            // instanciation de l'objet
            vehicule = new Voiture(constct, model, nimmatr, mcirc, np, enrg, prx, capac);
            // afficher les caractéristiques du véhicule
            vehicule.affiche();
            // ( petit tour en ville) bouclerCeinture, démarrer, accélérer, ralentir, se garer, s'arrêter, détacher la ceinture
            vehicule.bouclerCeinture();
            vehicule.mettreLeContact();
            vehicule.demarrer();
            vehicule.accelerer();
            vehicule.ralentir();
            vehicule.seGarer();
            vehicule.arrêter();
            vehicule.détacherCeinture();
            
            
            
            //  afficher les caractéristiques du véhicule
            vehicule.affiche();
            Console.ReadLine();
        }
    }
}
