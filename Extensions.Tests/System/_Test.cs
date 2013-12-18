using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Extensions.Tests.System
{
    [TestClass]
    public class _Test
    {
        [TestMethod]
        public void RangeTest()
        {
            int a = 0;

            _.Range(2, 20, i =>
            {
                a++;
            });

            Assert.AreEqual(19, a);

            int b = 0;

            _.Range(2, 20, i =>
            {
                b++;
            }, false);

            Assert.AreEqual(18, b);
        }

        [TestMethod]
        public void ListTest()
        {
            var list = _.List<int>(1, 3, 5, 7, 9);

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(3, list[1]);
            Assert.AreEqual(5, list[2]);
            Assert.AreEqual(7, list[3]);
            Assert.AreEqual(9, list[4]);


            var l = _.AnonymousList(new[] { 
                new { Name = "abc" },
                new { Name = "def" }
            });

            Assert.AreEqual("abc", l[0].Name);
            Assert.AreEqual("def", l[1].Name);
        }

        [TestMethod]
        public void DictionaryTest()
        {
            var dic = _.Dictionary<string, int>(
                "hoge", 1,
                "foo", 1111,
                "bar", 2345);

            Assert.AreEqual(1, dic["hoge"]);
            Assert.AreEqual(1111, dic["foo"]);
            Assert.AreEqual(2345, dic["bar"]);
            
        }

    }
}
