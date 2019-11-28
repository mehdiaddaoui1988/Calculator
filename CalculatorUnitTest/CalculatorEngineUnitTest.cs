using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass] // That is annotations 
    public class CalculatorEngineUnitTest
    {
        [TestMethod] // That is annotations - Test de l'addition 
        public void TestMethodAdd()
        {
            //Implémentation des valeurs de test
            int a = 1;
            int b = 2;
            int exp = 3;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Add(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la soustraction 
        public void TestMethodSub()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 1;
            int exp = 1;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Sub(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la multiplication 
        public void TestMethodMul()
        {
            //Implémentation des valeurs de test
            int a = 1;
            int b = 2;
            int exp = 2;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
        [TestMethod] // That is annotations - Test de la division 
        public void TestMethodDiv()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 2;
            int exp = 1;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }

        [TestMethod] // That is annotations - Test de la division par zero
        public void TestMethodDivByZero()
        {
            //Implémentation des valeurs de test
            int a = 2;
            int b = 0;
            int exp = Int32.MinValue;

            // Instanciation d'un objet CalculatorEngine défini dans la classe CalculatorEngine
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            //Vérification de l'égalité entre the expected valeur et l'actual valeur 
            Assert.AreEqual(exp, actual);


        }
    }
}
