using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containers.Core;

namespace Containers.Test
{
    [TestClass]
    public class UnitTestArray
    {
        [TestMethod]
        public void CanCreateEmptyArray()
        {
            Array<int> arr = new Array<int>();
            Assert.IsInstanceOfType(arr, typeof(Array<int>));
        }

        [TestMethod]
        public void CanCreateArrayOfSize()
        {
            Array<int> arr = new Array<int>(10);
            Assert.IsInstanceOfType(arr, typeof(Array<int>));
        }

        [TestMethod]
        public void CanInsertValueAtTail()
        {
            Array<int> arr = new Array<int>();
            arr.Insert(10);
            Assert.AreEqual(10, arr[0]);
        }

        [TestMethod]
        public void CanInsertValueAtIndex()
        {
            Array<int> arr = new Array<int>(10);
            arr.Insert(0, 10);
            Assert.AreEqual(10, arr[0]);
        }

        [TestMethod]
        public void CanRemoveValueAtIndex()
        {
            Array<int> arr = new Array<int>(10);
            arr.Remove(0);
            Assert.AreEqual(9, arr.Size());
        }

        [TestMethod]
        public void CanAccessArrayMemberViaIndexer()
        {
            Array<int> arr = new Array<int>(10);
            Assert.IsInstanceOfType(arr[0], typeof(int));
        }

        [TestMethod]
        public void CanGetArraySize()
        {
            Array<int> arr = new Array<int>(10);
            Assert.AreEqual(10, arr.Size());
        }

        [TestMethod]
        public void CanGetArrayIterator()
        {
            Array<int> arr = new Array<int>();
            var iterator = arr.GetIterator();
            Assert.IsInstanceOfType(iterator, typeof(Core.Array<int>.Iterator));
        }
    }
}
