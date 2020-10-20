using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberProblem;

namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenIntegerArray_Should_Return_LargestInteger()
        {
            int[] values = { 3, 6, 7, 10, 4, 8 };
            MaximumNumber<int> maximumNumber = new MaximumNumber<int>(values);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(10, max);
        }
       
        [TestMethod]
        public void GivenDoubleArray_Should_Return_LargestDouble()
        {
            double[] values = { 10.6, 25.9, 8.2, 9.56, 20.8, 6.9, 21.5 };
            MaximumNumber<double> maximumNumber = new MaximumNumber<double>(values);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(25.9, max);
        }
       
        [TestMethod]
        public void GivenStringArray_Should_Return_LargestString()
        {
            string[] values = { "222","498","999","333","777","888"};
            MaximumNumber<string> maximumNumber = new MaximumNumber<string>(values);

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("999", max);
        }
        
    }
}
