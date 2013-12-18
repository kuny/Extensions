using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests.System
{
    [TestClass]
    public class IntExtensionTest
    {
        [TestMethod]
        public void TimesTest()
        {
            int i = 100;

            int c = 0;

            i.Times(a =>
            {
                Assert.AreEqual(c, a);
                c++;
            });
        }

        [TestMethod]
        public void DivideTest()
        {
            int a = 100;

            Assert.AreEqual(0, a.Divide(0));
            Assert.AreEqual(50, a.Divide(2));
        }
    }
}
