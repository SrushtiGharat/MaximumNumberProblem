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

            int max = maximumNumber.GetMaximum(30, 12, 18);

            Assert.AreEqual(30, max);
        }
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximum(16, 50, 24);

            Assert.AreEqual(50, max);
        }
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            int max = maximumNumber.GetMaximum(15, 20, 45);

            Assert.AreEqual(45, max);
        }
        [TestMethod]
        public void GivenDouble_MaxFirstNumber_Should_Return_FirstNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximum(30.5, 12.9, 18.6);

            Assert.AreEqual(30.5, max);
        }
        [TestMethod]
        public void GivenDouble_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximum(16.5, 50.8, 24.9);

            Assert.AreEqual(50.8, max);
        }
        [TestMethod]
        public void GivenDouble_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            double max = maximumNumber.GetMaximum(15.9, 20.2, 45.5);

            Assert.AreEqual(45.5, max);
        }
        [TestMethod]
        public void GivenString_MaxFirstString_Should_Return_FirstString()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            string max = maximumNumber.GetMaximum("888","555","111");

            Assert.AreEqual("888", max);
        }
        [TestMethod]
        public void GivenString_MaxSecondString_Should_Return_SecondString()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            string max = maximumNumber.GetMaximum("222","777","555");

            Assert.AreEqual("777", max);
        }
        [TestMethod]
        public void GivenString_MaxThirdString_Should_Return_ThirdString()
        {
            MaximumNumber maximumNumber = new MaximumNumber();

            string max = maximumNumber.GetMaximum("444","333","999");

            Assert.AreEqual("999", max);
        }
    }
}
