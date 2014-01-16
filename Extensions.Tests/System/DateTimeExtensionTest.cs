using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests.System
{
    [TestClass]
    public class DateTimeExtensionTest
    {
        [TestMethod]
        public void ToJaCalTest()
        {
            var d = new DateTime(2013, 12, 1);
            Assert.AreEqual("平成25年12月1日", d.ToJaCal());
        }

        [TestMethod]
        public void ToFirstDayTest()
        {
            var s1 = new DateTime(2014, 1, 10);
            Assert.AreEqual(new DateTime(2014, 1, 1), s1.ToFirstDay());
        }

        [TestMethod]
        public void ToLastDayTest()
        {
            var s1 = new DateTime(2014, 1, 10);
            Assert.AreEqual(new DateTime(2014, 1, 31), s1.ToLastDay());
        }
    }
}
