using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClassesTests.Classes
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    /// 

    //CollectionAssert
    //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
    //.AllItemsAreUnique() - Checks for uniqueness among actual collection
    //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
    //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
    //.AreNotEqual() - Opposite of AreEqual
    //.AreNotEquilavent() - Opposite or AreEqualivent
    //.Contains() - Checks to see if collection contains a value/object

    [TestClass]
    public class LoopsAndArrayExercisesTests
    {
        public LoopsAndArrayExercisesTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void MiddleWayTest()
        {

            LoopsAndArrayExercises myExercises = new LoopsAndArrayExercises();
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] c = { 2, 5 };
            CollectionAssert.AreEquivalent(myExercises.MiddleWay(a, b), c);
        }
    }
}
