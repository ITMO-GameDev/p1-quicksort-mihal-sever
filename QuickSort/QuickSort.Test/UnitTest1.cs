using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort.Core;

namespace QuickSort.Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// General case for completely random integer values.
        /// </summary>
        [TestMethod]
        public void CanSortRandomIntArray()
        {
            int[] result = Utility.CreateRandomIntArray(100, 100, -100);
            int[] expected = Utility.CopyArray(result);

            Sort.QuickSortRecursive(result, 0, result.Length - 1);
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// General case for completely random floating point values.
        /// </summary>
        [TestMethod]
        public void CanSortRandomDoubleArray()
        {
            double[] result = Utility.CreateRandomDoubleArray(100, 100.0, -100.0);
            double[] expected = Utility.CopyArray(result);

            Sort.QuickSortRecursive(result, 0, result.Length - 1);
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);
        }

        // Following test cases are only introduced for integer values as an example.

        /// <summary>
        /// Test case for sorted integer values.
        /// </summary>
        [TestMethod]
        public void CanSortSortedIntArray()
        {
            int[] result = Utility.CreateRandomIntArray(100, 100, -100);
            Array.Sort(result);

            int[] expected = Utility.CopyArray(result);

            Sort.QuickSortRecursive(result, 0, result.Length - 1);

            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test case for reverse sorted integer values.
        /// </summary>
        [TestMethod]
        public void CanSortReverseSortedIntArray()
        {
            int[] result = Utility.CreateRandomIntArray(100, 100, -100);

            Array.Sort(result);
            int[] expected = Utility.CopyArray(result);

            Array.Reverse(result);
            Sort.QuickSortRecursive(result, 0, result.Length - 1);

            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test case for empty integer values.
        /// </summary>
        [TestMethod]
        public void CanSortEmptyIntArray()
        {
            int[] result = new int[100];
            int[] expected = Utility.CopyArray(result);
            
            Sort.QuickSortRecursive(result, 0, result.Length - 1);

            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test case for half empty/half random integer values.
        /// </summary>
        [TestMethod]
        public void CanSortHalfEmptyIntArray()
        {
            int[] result = Utility.CreateRandomIntArray(50, 100, -100);
            Array.Resize(ref result, 100);
            int[] expected = Utility.CopyArray(result);

            Sort.QuickSortRecursive(result, 0, result.Length - 1);
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
