using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PAY__ROLL
{
    [TestClass]
    public class UnitTest1
    {
        PAY__ROLL pay = new PAY__ROLL();

        [TestMethod]
        public void TestMethod1()
        {
            // prepare
            var expected = "98";

            // action
            var actual = fizzBuzz.RunFizzBuzz(98);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
