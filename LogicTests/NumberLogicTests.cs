using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    [TestClass()]
    public class NumberLogicTests
    {
        [TestMethod()]
        public void IntToBinaryTest()
        {
            Assert.AreEqual("00000000", NumberLogic.IntToBinary(0));
            Assert.AreEqual("11111111", NumberLogic.IntToBinary(255));
            Assert.AreEqual("11110000", NumberLogic.IntToBinary(240));
            Assert.AreEqual("00001111", NumberLogic.IntToBinary(15));
        }
    }
}