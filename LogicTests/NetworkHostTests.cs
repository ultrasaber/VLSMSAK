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
    public class NetworkHostTests
    {
        [TestMethod()]
        public void NetworkHostTest()
        {
            NetworkHost target = new NetworkHost(new IPv4Address("192.168.1.100"), new IPv4Address("255.255.255.0"));

            Assert.AreEqual("192.168.1.1", target.FirstHostAddress.ToString());
            Assert.AreEqual(24, target.CIDRMaskLength);
            Assert.AreEqual("192.168.1.255", target.BroadcastAddress.ToString());
            Assert.AreEqual("192.168.1.254", target.LastHostAddress.ToString());
        }
    }
}