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
            MaximumNumber<int> maximumNumber = new MaximumNumber<int>(30, 12, 18);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(30, max);
        }
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber<int> maximumNumber = new MaximumNumber<int>(16, 50, 24);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(50, max);
        }
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber<int> maximumNumber = new MaximumNumber<int>(15, 20, 45);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(45, max);
        }
        [TestMethod]
        public void GivenDouble_MaxFirstNumber_Should_Return_FirstNumber()
        {
            MaximumNumber<double> maximumNumber = new MaximumNumber<double>(30.5, 12.9, 18.6);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(30.5, max);
        }
        [TestMethod]
        public void GivenDouble_MaxSecondNumber_Should_Return_SecondNumber()
        {
            MaximumNumber<double> maximumNumber = new MaximumNumber<double>(16.5, 50.8, 24.9);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(50.8, max);
        }
        [TestMethod]
        public void GivenDouble_MaxThirdNumber_Should_Return_ThirdNumber()
        {
            MaximumNumber<double> maximumNumber = new MaximumNumber<double>(15.9, 20.2, 45.5);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(45.5, max);
        }
        [TestMethod]
        public void GivenString_MaxFirstString_Should_Return_FirstString()
        {
            MaximumNumber<string> maximumNumber = new MaximumNumber<string>("888", "555", "111");

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("888", max);
        }
        [TestMethod]
        public void GivenString_MaxSecondString_Should_Return_SecondString()
        {
            MaximumNumber<string> maximumNumber = new MaximumNumber<string>("222", "777", "555");

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("777", max);
        }
        [TestMethod]
        public void GivenString_MaxThirdString_Should_Return_ThirdString()
        {
            MaximumNumber<string> maximumNumber = new MaximumNumber<string>("444", "333", "999");

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("999", max);
        }
    }
}
