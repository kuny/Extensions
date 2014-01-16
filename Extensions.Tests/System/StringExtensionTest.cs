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

        [TestMethod]
        public void ToFirstDayTest()
        {
            var s1 = "201401";
            Assert.AreEqual(new DateTime(2014, 1, 1), s1.ToFirstDay());

            var s2 = "2014/01";
            Assert.AreEqual(new DateTime(2014, 1, 1), s2.ToFirstDay());

            var s3 = "2014/1";
            Assert.AreEqual(new DateTime(2014, 1, 1), s3.ToFirstDay());
        }

        [TestMethod]
        public void ToLastDayTest()
        {
            var s1 = "201401";
            Assert.AreEqual(new DateTime(2014, 1, 31), s1.ToLastDay());

            var s2 = "2014/01";
            Assert.AreEqual(new DateTime(2014, 1, 31), s2.ToLastDay());

            var s3 = "2014/1";
            Assert.AreEqual(new DateTime(2014, 1, 31), s3.ToLastDay());
        }
    }
}
