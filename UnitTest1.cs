using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProject0;
using System;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestAddFirst()
        {
            var list = new LinkedList();
            list.AddFirst("Joe Blow");
            list.AddFirst("Jane Doe");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("Jane Doe", list.GetValue(0));
        }

        [TestMethod]
        public void TestAddLast()
        {
            var list = new LinkedList();
            list.AddLast("John Smith");
            list.AddLast("Bob Bobberson");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("Bob Bobberson", list.GetValue(1));
        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            var list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Sam Sammerson");
            list.RemoveFirst();
            Assert.AreEqual("Sam Sammerson", list.GetValue(0));
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            var list = new LinkedList();
            list.AddLast("Dave Daverson");
            list.AddLast("Joe Schmoe");
            list.RemoveLast();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Dave Daverson", list.GetValue(0));
        }

        [TestMethod]
        public void TestGetValue()
        {
            var list = new LinkedList();
            list.AddLast("Sam Sammerson");
            Assert.AreEqual("Sam Sammerson", list.GetValue(0));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemoveFromEmpty()
        {
            var list = new LinkedList();
            list.RemoveFirst(); // Should throw
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetValueInvalidIndex()
        {
            var list = new LinkedList();
            list.AddLast("Jane Doe");
            list.GetValue(5); // Invalid index
        }
    }
}
