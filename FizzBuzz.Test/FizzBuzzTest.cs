using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Test03()
        {
            Assert.AreEqual("fizz", FizzBuzz.GetResult(3));
        }

        [TestMethod]
        public void Test05()
        {
            Assert.AreEqual("buzz", FizzBuzz.GetResult(5));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("fizz", FizzBuzz.GetResult(13));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual("fizzbuzz", FizzBuzz.GetResult(15));
        }

        [TestMethod]
        public void Test30()
        {
            Assert.AreEqual("fizzbuzz", FizzBuzz.GetResult(30));
        }

    }
}
