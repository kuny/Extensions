using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests.System
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void KillTest()
        {
            var s = "abcdefghijklmn";
            Assert.AreEqual("abcdefg", s.Kill(7));
        }
    }
}
