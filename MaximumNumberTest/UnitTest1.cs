using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberProblem;

namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenInteger_MaxFirstNumber_Should_Return_FirstNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumIntNumber(30, 12, 18);

            Assert.AreEqual(30, max);
        }
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumIntNumber(16, 50, 24);

            Assert.AreEqual(50, max);
        }
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximumIntNumber(15, 20, 45);

            Assert.AreEqual(45, max);
        }
        [TestMethod]
        public void GivenDouble_MaxFirstNumber_Should_Return_FirstNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximumDoubleNumber(30.5, 12.9, 18.6);

            Assert.AreEqual(30.5, max);
        }
        [TestMethod]
        public void GivenDouble_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximumDoubleNumber(16.5, 50.8, 24.9);

            Assert.AreEqual(50.8, max);
        }
        [TestMethod]
        public void GivenDouble_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximumDoubleNumber(15.9, 20.2, 45.5);

            Assert.AreEqual(45.5, max);
        }
    }
}
