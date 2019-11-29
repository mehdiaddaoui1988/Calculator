using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        /// <summary>
        /// Fonction pour Additionitionner deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2éme valeur</param>
        /// <returns>L'Additionition des deux valeurs</returns>
        public virtual int Addition(int val1, int val2)
        {
            // Any Update
            return val1 + val2;
        }

        /// <summary>
        /// Fonction pour faire la soustraction de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La soustraction de deux valeurs</returns>
        public virtual int Subdivision(int val1, int val2)
        {
            return val1 - val2;
        }

        /// <summary>
        /// Fonction pour faire la Multiplicationtiplication de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La Multiplicationtiplication de deux valeurs</returns>
        public virtual int Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }

        /// <summary>
        /// Fonction pour faire la Divisionision
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La Divisionision de deux valeurs</returns>
        public virtual int Division(int val1, int val2)
        {
            int resultat;

            if (val2 != 0)
            {
                resultat = val1 / val2;
            }
            else
            {
                resultat = Int32.MinValue;
            }
            return resultat;
        }
        public virtual int Square(int val1)
        {
            int resultat;

            resultat = val1 * val1;




            return resultat;
        }
        public virtual double SquareRoot(int val1)
        {
            double resultat;

            resultat = Math.Sqrt(val1);




            return resultat;
        }
        public virtual float Percent(int val1)
        {
            float resultat;

            resultat = val1 / 100;




            return resultat;
        }
    }
}
