using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass] // That is annotations 
    public class CalculatorEngineUnitTest
    {
        [TestMethod] // That is annotations - Test de l'Additionition 
        public void TestMethodAddition()
        {
            //Implémentation des valeurs de test
            int a = 1;
            int b = 2;
            int exp = 3;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Addition(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la soustraction 
        public void TestMethodSubdivision()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 1;
            int exp = 1;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Subdivision(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la Multiplicationtiplication 
        public void TestMethodMultiplication()
        {
            //Implémentation des valeurs de test
            int a = 1;
            int b = 2;
            int exp = 2;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Multiplication(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la Divisionision 
        public void TestMethodDivision()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 2;
            int exp = 1;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }

        [TestMethod] // That is annotations - Test de la Divisionision par zero
        public void TestMethodDivisionByZero()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 0;
            int exp = Int32.MinValue;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
    }
}
