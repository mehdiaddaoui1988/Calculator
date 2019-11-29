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
        public virtual int Addition(int a, int b)
        {
            // Any Update
            return a+b;
        }

        /// <summary>
        /// Fonction pour faire la soustraction de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La soustraction de deux valeurs</returns>
        public virtual int Subdivision(int a, int b)
        {
            return a-b;
        }

        /// <summary>
        /// Fonction pour faire la Multiplicationtiplication de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La Multiplicationtiplication de deux valeurs</returns>
        public virtual int Multiplication(int a, int b)
        {
            return a*b;
        }

        /// <summary>
        /// Fonction pour faire la Divisionision
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La Divisionision de deux valeurs</returns>
        public virtual int Division(int a, int b)
        {
            int res;

            if ( b != 0 )
            {
                res = a / b;
            }
            else
            {
                res = Int32.MinValue;
            }
            return res;
        }
    }
}
