using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Correct()
        {
            var egn = "6101057509";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IncorrectControlDigit()
        {
            var egn = "6101057508";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IncorrectDay()
        {
            var egn = "6101557509";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IncorrectMonth()
        {
            var egn = "6117057509";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DifferentLength()
        {
            var egn = "61170517509";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NonDigits()
        {
            var egn = "False";

            var result = Veselin_Dimitrov.Program.CheckEGN(egn);

            Assert.IsFalse(result);
        }
    }
}
