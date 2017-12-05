using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace utilisationClasseVoiture
{
    public class Voiture
    {
        string constructeur;
        string modele;
        string nImmat;
        DateTime dateMiseCircul;
        int nbPortes;
        int energie;
        decimal prix;
        int Kilometrage;
        int vitesse;
        int capaciteReservoir;
        bool cleSurVolant;
        bool ceintureBouclee;
// constructeur
        public Voiture(string construct, string mod, string immat, DateTime mcircul, int nbp, int ener, decimal px, int capacite)
        {
            this.constructeur = construct;
            this.modele = mod;
            this.nImmat = immat;
            this.dateMiseCircul = mcircul;
            this.nbPortes = nbp;
            this.energie = ener;
            this.prix = px;
            this.Kilometrage = 0;
            this.vitesse = 0;
            this.capaciteReservoir = capacite;
            this.cleSurVolant = false;
            this.ceintureBouclee = false;
        }
        public void affiche()
        {
            Console.WriteLine("le véhicule a pour constructeur {0}, modèle {1}, numéro d'immatriculation {2}, date de mise en circulation {3}", constructeur, modele, nImmat, dateMiseCircul);
            if (ceintureBouclee)
            {
                Console.WriteLine("la ceinture est bouclée");
            }
            else
            {
                Console.WriteLine("Attention, la ceinture n'est pas bouclée");
            }
        }
        public override string ToString()
        {
            string s;
            s =String.Format("le véhicule a pour constructeur {0}, modèle {1}, numéro d'immatriculation {2}, date de mise en circulation {3}", constructeur, modele, nImmat, dateMiseCircul);
            return s;
        }
        public void bouclerCeinture()
        {
            Console.WriteLine("Vous avez bouclé la ceinture");
            ceintureBouclee = true;
        }
        public void demarrer()
        {
            if (cleSurVolant)
            {
                vitesse = 10;
                Console.WriteLine("vous roulez à {0}km/h",vitesse);
            }
            else
            {
                Console.WriteLine("mettez le contact");
            }
        }
        public void accelerer()
        {
            if (vitesse !=0)
            {
                vitesse = vitesse + 10;
                Console.WriteLine("Vous roulez à {0}km/h",vitesse);
            }
            else
            {
                Console.WriteLine("mettez le contact");
            }
        }
        public void ralentir()
        {
            if (vitesse >=10)
            {
                vitesse = vitesse - 10;
                Console.WriteLine("Vous roulez à {0}km/h", vitesse);
            }
            else
            {
                Console.WriteLine("Vous êtes déjà à l'arrêt");
            }
        }

        public void mettreLeContact()
        {
            cleSurVolant = true;
            Console.WriteLine("La voiture c'est mis en route");
        }

        public void seGarer()
        {
            Console.WriteLine("Le véhicule se gare dans le parking et s'arrête");
            if (vitesse >= 10)
            {
                vitesse = vitesse - 10;
            }
            else
            {
                Console.WriteLine("Vous êtes déja à l'arrêt");
            }
        }

        public void arrêter()
        {
            if (vitesse >= 1)
            {
                Console.WriteLine("Veuillez aller vous garer");
            }
            else
            {
                cleSurVolant = false;
                Console.WriteLine("Vous avez coupé le contact");
            }
        }

        public void détacherCeinture()
        {
            ceintureBouclee = false;
            Console.WriteLine("Vous vous êtes détachée");
        }
    }
}
