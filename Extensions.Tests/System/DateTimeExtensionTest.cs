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
    }
}
