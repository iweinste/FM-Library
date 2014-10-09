using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FM_Library;

namespace FMUtilLibrary_UnitTestProject
{
    [TestClass]
    public class FMUtilLibTest1
    {
        [TestMethod]
        public void testAddTwo()
        {
            Assert.AreEqual(2 + 2, new FMUtilLib().addTwo(2, 2));
        }
    }
}
