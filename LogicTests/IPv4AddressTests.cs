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
    public class IPv4AddressTests
    {
        [TestMethod()]
        public void IPv4AddressTest()
        {
            IPv4Address ipAddress = new IPv4Address("192.168.1.100");

            Assert.AreEqual(192, ipAddress.FirstOctet);
            Assert.AreEqual(168, ipAddress.SecondOctet);
            Assert.AreEqual(1, ipAddress.ThirdOctet);
            Assert.AreEqual(100, ipAddress.FourthOctet);
        }
    }
}