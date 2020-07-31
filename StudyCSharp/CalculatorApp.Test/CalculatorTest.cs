using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;


namespace CalculatorApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd3and7()
        {
            double a = 3.0;
            double b = 7.0;
            double expected = 10.0;

            Calculator calc = new Calculator();
            double actual = calc.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMult4and5()
        {
            double a = 4.0;
            double b = 5.0;
            double expected = 20.0;

            Calculator calc = new Calculator();
            double actual = calc.Mult(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv10and2()
        {
            double a = 10.0;
            double b = 2.0;
            double expected = 5.0;

            Calculator calc = new Calculator();
            double actual = calc.Div(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
