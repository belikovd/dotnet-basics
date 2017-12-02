/**
 * SortingTests.cs
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * License:     See LICENSE.txt in the project root for more information.
 * 
 */
using DotNetBasics.Common.Interfaces;
using DotNetBasics.Library.Sorting;
using DotNetBasics.Library.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetBasics.Library.Tests.SortingTests
{
    /// <summary>
    /// Summary description for BubbleSortTests
    /// </summary>
    [TestClass]
    public class SortingTests
    {
        private readonly List<ISortingAlgorithm> _algorithms;

        public SortingTests()
        {
            _algorithms = new List<ISortingAlgorithm>();
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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            _algorithms.AddRange(new ISortingAlgorithm[]
            {
                new BubbleSortingAlgorithm(),
                new SelectionSortingtAlgorithm(),
                new InsertionSortingAlgorithm()
            });
        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Test Methods

        [TestMethod]
        public void Sort_Sorts_Unsorted_Array_Of_Numbers()
        {
            _algorithms.ForEach(alg =>
            {
                int[] source = new int[] { 6, 2, 9, 4, 1, 8, 5, 3, 7, 0 };
                alg.Sort(source);

                bool allElementsAtSortedIndexes = source.All(item => item == Array.IndexOf(source, item));

                Assert.IsTrue(allElementsAtSortedIndexes);
            });
        }

        [TestMethod]
        public void Sort_Sorts_Unsorted_Array_Of_Custom_Comparable_Objects()
        {
            _algorithms.ForEach(alg =>
            {
                var source = new TestComparable[]
                {
                    new TestComparable(6),
                    new TestComparable(2),
                    new TestComparable(9),
                    new TestComparable(4),
                    new TestComparable(1),
                    new TestComparable(8),
                    new TestComparable(5),
                    new TestComparable(3),
                    new TestComparable(7),
                    new TestComparable(0)
                };

                alg.Sort(source);

                bool allElementsAtSortedIndexes = source.All(item => item.Number == Array.IndexOf(source, item));

                Assert.IsTrue(allElementsAtSortedIndexes);
            });
        }

        #endregion
    }
}
