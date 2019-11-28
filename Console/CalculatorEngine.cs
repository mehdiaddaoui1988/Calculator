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
        /// Fonction pour additionner deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2éme valeur</param>
        /// <returns>L'addition des deux valeurs</returns>
        public int Add(int a, int b)
        {
            return a+b;
        }

        /// <summary>
        /// Fonction pour faire la soustraction de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La soustraction de deux valeurs</returns>
        public int Sub(int a, int b)
        {
            return a-b;
        }

        /// <summary>
        /// Fonction pour faire la multiplication de deux valeurs
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La multiplication de deux valeurs</returns>
        public int Mul(int a, int b)
        {
            return a*b;
        }

        /// <summary>
        /// Fonction pour faire la division
        /// </summary>
        /// <param name="a">1ere valeur</param>
        /// <param name="b">2eme valeur</param>
        /// <returns>La division de deux valeurs</returns>
        public int Div(int a, int b)
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
