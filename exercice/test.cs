/**
 * @file Test.cs
 * @brief Programme de test pour la documentation avec Doxygen.
 * @author Mustapha , 
 * @date 18 avril 2026
 * @tableofcontents
 */

using System;

namespace ProjetExercice
{
    /**
     * @class Calculatrice
     * @brief Classe représentant une calculatrice simple.
     */
    public class Calculatrice
    {
        /**
         * @brief Additionne deux nombres.
         * @param a Premier nombre
         * @param b Deuxième nombre
         * @return Résultat de l'addition
         */
        public int Addition(int a, int b)
        {
            return a + b;
        }

        /**
         * @brief Multiplie deux nombres.
         * @param a Premier nombre
         * @param b Deuxième nombre
         * @return Résat du produit
         */
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }

    /**
     * @class Programme
     * @brief Classe principale pour tester la calculatrice.
     */
    class Programme
    {
        /**
         * @brief Point d'entrée du programme.
         * @param args Arguments de la ligne de commande
         */
        static void Main(string[] args)
        {
            Calculatrice calc = new Calculatrice();

            int somme = calc.Addition(5, 3);
            int produit = calc.Multiplication(5, 3);

            Console.WriteLine("Somme: " + somme);
            Console.WriteLine("Produit: " + produit);
        }
    }
}