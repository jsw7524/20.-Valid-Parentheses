using System;
using _20.Valid_Parentheses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            var result = sln.IsValid("()");
            Assert.AreEqual(true,result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();
            var result = sln.IsValid("]");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Solution sln = new Solution();
            var result = sln.IsValid("");
            Assert.AreEqual(true, result);
        }
    }


}
