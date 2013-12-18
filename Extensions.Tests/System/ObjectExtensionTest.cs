using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests.System
{
    [TestClass]
    public class ObjectExtensionTest
    {
        [TestMethod]
        public void ToInt32Test()
        {
            object o = 12345;

            Assert.AreEqual(12345, o.ToInt32());
        }

        [TestMethod]
        public void ToDecimalTest()
        {
            object o = 1234.56m;

            Assert.AreEqual(1234.56m, o.ToDecimal());
        }

        [TestMethod]
        public void ToDateTimeTest()
        {
            object o = "2013/01/01";

            var d = o.ToDateTime();

            Assert.AreEqual(2013, d.Year);
            Assert.AreEqual(1, d.Month);
            Assert.AreEqual(1, d.Day);

            o = new DateTime(2001, 1, 1);

            d = o.ToDateTime();

            Assert.AreEqual(2001, d.Year);
            Assert.AreEqual(1, d.Month);
            Assert.AreEqual(1, d.Day);
        }
    }
}
