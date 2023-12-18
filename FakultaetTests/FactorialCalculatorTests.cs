using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fakultaet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet.Tests
{
    [TestClass()]
    public class FactorialCalculatorTests
    {
        [TestMethod()]
        public void ZeroFactorial()
        {
            var Calculator = new FactorialCalculator();
            Assert.AreEqual(1, Calculator.Calculate(0));
        }
        public void OneFactorial()
        {
            var Calculator = new FactorialCalculator();
            Assert.AreEqual(1, Calculator.Calculate(1));
        }
        public void FiveFactorial()
        {
            var Calculator = new FactorialCalculator();
            Assert.AreEqual(120, Calculator.Calculate(5));
        }

    }
}