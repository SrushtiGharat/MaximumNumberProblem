using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MaximumNumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Maximum Number Problem");
            Console.WriteLine("Enter 3 integers");
            int firstIntValue = Convert.ToInt32(Console.ReadLine());
            int secondIntValue = Convert.ToInt32(Console.ReadLine());
            int thirdIntValue = Convert.ToInt32(Console.ReadLine());
            MaximumNumber<int> maximumInt = new MaximumNumber<int>(firstIntValue, secondIntValue, thirdIntValue);
            int maxIntNumber = maximumInt.GetMaximum();
            Console.WriteLine("Maximum :" + maxIntNumber);

            Console.WriteLine("Enter 3 float numbers");
            double firstDoubleValue = Convert.ToDouble(Console.ReadLine());
            double secondDoubleValue = Convert.ToDouble(Console.ReadLine());
            double thirdDoubleValue = Convert.ToDouble(Console.ReadLine());
            MaximumNumber<double> maximumDouble = new MaximumNumber<double>(firstDoubleValue, firstDoubleValue, thirdDoubleValue);
            double maxDoubleNumber = maximumDouble.GetMaximum();
            Console.WriteLine("Maximum :" + maxDoubleNumber);

            Console.WriteLine("Enter 3 Strings");
            string firstStringValue = Console.ReadLine();
            string secondStringValue = Console.ReadLine();
            string thirdStringValue = Console.ReadLine();
            MaximumNumber<string> maximumString= new MaximumNumber<string>(firstStringValue, secondStringValue, thirdStringValue);
            string maxString = maximumString.GetMaximum();
            Console.WriteLine("Maximum :" + maxString);


        }
    }
}
