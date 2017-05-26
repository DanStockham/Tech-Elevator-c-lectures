using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDDLecture;

namespace TDDLectureTests
{
    [TestClass]
    public class KataPrimeFactorsTest
    {
        [TestMethod]
        public void FactorizeTest_2()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(2);
            CollectionAssert.AreEquivalent(new List<int> { 2 }, response);

        }

        [TestMethod]
        public void FactorizeTest_PowersOfTwo()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(256);
            CollectionAssert.AreEquivalent(new List<int> { 2,2,2,2,2,2,2,2 }, response);

        }



        [TestMethod]
        public void FactorizeTest_SmallNonPrime()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(6);
            CollectionAssert.AreEquivalent(new List<int> { 2, 3 }, response);

        }

        [TestMethod]
        public void FactorizeTest_LargeNonPrime()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(12);
            CollectionAssert.AreEquivalent(new List<int> { 2, 2, 3 }, response);

        }

        [TestMethod]
        public void FactorizeTest_TwoPrimes()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(323);
            CollectionAssert.AreEquivalent(new List<int> { 17, 19 }, response);

        }

        [TestMethod]
        public void FactorizeTest_LargePrimes()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(199);
            CollectionAssert.AreEquivalent(new List<int> { 199 }, response);

        }

        [TestMethod]
        public void FactorizeTest_VeryLargeTests()
        {
            KataPrimeFactors testClass = new KataPrimeFactors();
            List<int> response = testClass.Factorize(105769);
            CollectionAssert.AreEquivalent(new List<int> { 105769 }, response);

        }

    }
}
