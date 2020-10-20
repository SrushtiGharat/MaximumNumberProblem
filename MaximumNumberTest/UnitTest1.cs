using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberProblem;

namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_MaxFirstNumber_Should_Return_FirstNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumNumber(30, 12, 18);

            Assert.AreEqual(30, max);
        }
        [TestMethod]
        public void Given_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumNumber(16, 50, 24);

            Assert.AreEqual(50, max);
        }
        [TestMethod]
        public void Given_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumNumber(15, 20, 45);

            Assert.AreEqual(45, max);
        }
    }
}
