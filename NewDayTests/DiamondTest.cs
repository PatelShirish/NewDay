using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewDay;
using System;
using System.Collections.Generic;

namespace NewDayTests
{
    [TestClass]
    public class DiamondTest
    {

        readonly Diamond diamond = new Diamond();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Print_Throw_Error_On_Invalid_Args()
        {
            diamond.Print('1');
        }

        [TestMethod]
        public void Print_Single_Char_If_A()
        {
            List<string> result = diamond.Print('A');

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("A", result[0]);
        }

        [TestMethod]
        public void Print_Diamond_If_E()
        {
            List<string> result = diamond.Print('E');

            Assert.AreEqual(9, result.Count);

            Assert.AreEqual("    A    ", result[0]);
            Assert.AreEqual("   B B   ", result[1]);
            Assert.AreEqual("  C   C  ", result[2]);
            Assert.AreEqual(" D     D ", result[3]);
            Assert.AreEqual("E       E", result[4]);
            Assert.AreEqual(" D     D ", result[5]);
            Assert.AreEqual("  C   C  ", result[6]);
            Assert.AreEqual("   B B   ", result[7]);
            Assert.AreEqual("    A    ", result[8]);
        }
    }
}
