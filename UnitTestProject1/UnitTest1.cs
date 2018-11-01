using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxRateProgram;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TaxComputation taxComputation = new TaxComputation();
        [TestMethod]
        public void TestComputeSingleTax0to9075()
        {
            double amount = 100.00;
            // int 1 = choice one for single
            double expected = 10.00;
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestComputeSingleTax9075to36900()
        {
            double amount = 10000;
            //int 1 = choicd one for single
            double expected = 1046.25;
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeSingleTax36900to89350()
        {
            double amount = 50000;
            double expected =8356.25 ;
            //int 1 = choice one for single. 
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeSingleTax89350to186350()
        {
            double amount = 100000;
            double expected =21175.75 ;
            //int 1 = choice one for single
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeSingleTax186350to405100()
        {
            double amount = 200000 ;
            double expected = 49858.25;
            //int 1 = choice one for single
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod ]
        public void TestComputeSingleTax405100to406750()
        {
            double amount = 406000;
            double expected = 117856.25 ;
            //int 1 = choice one for single
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeSingleTax406750toNoLimit()
        {
            double amount = 500000;
            double expected = 155045.75;
            //int 1 = choice one for single
            double actual = taxComputation.TaxCompute(1, amount);
            Assert.AreEqual(expected, actual);
        }
    }
}
