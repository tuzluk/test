﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(1, 1);
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Assert.AreEqual(1, 2);
        //}

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }
    }
}
