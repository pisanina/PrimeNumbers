using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbers.Tests
{
    [TestClass()]
    public class PrimeNumbersTests
    {
        private PrimeNumbers Prime = new PrimeNumbers();

        [TestMethod()]
        public void IsThisPrimeTestFor_NegativeNumbers()
        {
            Assert.IsFalse(Prime.IsThisPrime(-5));
        }

        [TestMethod()]
        public void IsThisPrimeTestFor_Zero()
        {
            Assert.IsFalse(Prime.IsThisPrime(0));
        }

        [TestMethod()]
        public void IsThisPrimeTestFor_4()
        {
            Assert.IsFalse(Prime.IsThisPrime(4));
        }

        [TestMethod()]
        public void IsThisPrimeTestFor_197()
        {
            Assert.IsTrue(Prime.IsThisPrime(197));
        }
    }
}