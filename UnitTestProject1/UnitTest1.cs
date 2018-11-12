using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxRateProgram;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TaxComputation taxComputation = new TaxComputation();


        //tests for filing single

        
        
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

        //tests for married filing jointly or qualified widow

        [TestMethod]
        public void TestComputeMarriedFilingJoint0to18150()
        {
            double amount = 10000;
            double expected = 1000;
            //int 2 = choice for married filing joint
            double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint18150to73800()
        {
            double amount = 50000;
            double expected = 6592.50;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
           Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint73800to148850()
        {
            double amount = 100000;
            double expected = 16712.50;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint148850to226850()
        {
            double amount = 200000;
            double expected = 43247;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint226850to405100()
        {
            double amount = 300000;
            double expected = 74904.50;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint405100to457600()
        {
            double amount = 450000;
            double expected = 125302.50;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingJoint457600toNoLimit()
        {
            double amount = 500000;
            double expected = 144752.90;
           //int 2 = choice for married filing joint
           double actual = taxComputation.TaxCompute(2, amount);
            Assert.AreEqual(expected, actual);
        }

        //tests for married filing seperate
        [TestMethod]
        public void TestComputeMarriedFilingSeperate0to9075()
        {
            double amount = 1000;
            double expected = 100;
           //int 3 = choice for married filing joint
           double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate9075to36900()
        {
            double amount = 10000;
            double expected = 1046.25;
           //int 3 = choice for married filing joint
           double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate36900to74425()
        {
            double amount = 50000;
            double expected = 8356.25;
           //int 3 = choice for married filing joint
           double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate74425to113425()
        {
            double amount = 100000;
            double expected = 21623.50;
          //int 3 = choice for married filing joint
          double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate113425to202550()
        {
            double amount = 150000;
            double expected = 37452.25;
          //int 3 = choice for married filing joint
          double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate202550to228800()
        {
            double amount = 210000;
            double expected = 57401.25;
            //int 3 = choice for married filing joint
            double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeMarriedFilingSeperate228800toNoLimit()
        {
            double amount = 250000;
            double expected = 72376.45;
          //int 3 = choice for married filing joint
          double actual = taxComputation.TaxCompute(3, amount);
            Assert.AreEqual(expected, actual);
        }

        //tests for filing head of household
        [TestMethod]
        public void TestComputeHeadOfHouseHold0to12950()
        {
            double amount = 1000;
            double expected = 100;
            //int 4 = choice for married filing joint
            double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold12950to49400()
        {
            double amount = 20000;
            double expected = 2352.50;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold49400to127550()
        {

            double amount = 100000;
            double expected = 19412.50;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold127550to206600()
        {

            double amount = 200000;
            double expected = 46586;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold206600to405100()
        {

            double amount = 300000;
            double expected = 79256;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold405100to432200()
        {

            double amount = 410000;
            double expected = 115654;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestComputeHeadOfHouseHold432200toNoLimit()
        {

            double amount = 450000;
            double expected = 130472.80;
           //int 4 = choice for married filing joint
           double actual = taxComputation.TaxCompute(4, amount);
            Assert.AreEqual(expected, actual);
        }
    }
}
