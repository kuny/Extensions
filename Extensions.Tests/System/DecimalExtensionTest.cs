using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests.System
{
    [TestClass]
    public class DecimalExtensionTest
    {
        [TestMethod]
        public void DivideTest()
        {
            decimal a = 100;

            Assert.AreEqual(0m, a.Divide(0m));
            Assert.AreEqual(50m, a.Divide(2m));
        }

        [TestMethod]
        public void GetPointIndexTest()
        {
            var d = 12345.6789m;

            Assert.AreEqual(5, d.PointIndex());
        }

        [TestMethod]
        public void RoundTest()
        {
            var d1 = 1234.56789m;
            var d2 = 123.4567m;
            var d3 = 123.1011m;

            Assert.AreEqual(1235m, d1.Round(0, RoundMode.RoundHalfUp));
            Assert.AreEqual(1234.6m, d1.Round(1, RoundMode.RoundHalfUp));
            Assert.AreEqual(1234.57m, d1.Round(2, RoundMode.RoundHalfUp));

            Assert.AreEqual(123m, d2.Round(0, RoundMode.RoundHalfUp));
            Assert.AreEqual(123.5m, d2.Round(1, RoundMode.RoundHalfUp));
            Assert.AreEqual(123.46m, d2.Round(2, RoundMode.RoundHalfUp));

            Assert.AreEqual(123.1m, d3.Round(1, RoundMode.RoundHalfUp));

            Assert.AreEqual(1234m, d1.Round(0, RoundMode.RoundDown));
            Assert.AreEqual(1234.5m, d1.Round(1, RoundMode.RoundDown));
            Assert.AreEqual(1234.56m, d1.Round(2, RoundMode.RoundDown));

            Assert.AreEqual(123m, d2.Round(0, RoundMode.RoundDown));
            Assert.AreEqual(123.4m, d2.Round(1, RoundMode.RoundDown));
            Assert.AreEqual(123.45m, d2.Round(2, RoundMode.RoundDown));

            Assert.AreEqual(123.1m, d3.Round(1, RoundMode.RoundDown));

            Assert.AreEqual(1235m, d1.Round(0, RoundMode.RoundUp));
            Assert.AreEqual(1234.6m, d1.Round(1, RoundMode.RoundUp));
            Assert.AreEqual(1234.57m, d1.Round(2, RoundMode.RoundUp));

            Assert.AreEqual(124m, d2.Round(0, RoundMode.RoundUp));
            Assert.AreEqual(123.5m, d2.Round(1, RoundMode.RoundUp));
            Assert.AreEqual(123.46m, d2.Round(2, RoundMode.RoundUp));

            Assert.AreEqual(123.1m, d3.Round(1, RoundMode.RoundUp));

        }
    }
}
