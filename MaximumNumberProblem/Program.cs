using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MaximumNumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            
            Console.WriteLine("Welcome To Maximum Number Problem");
            Console.WriteLine("Enter 3 integers");
            int firstIntValue = Convert.ToInt32(Console.ReadLine());
            int secondIntValue = Convert.ToInt32(Console.ReadLine());
            int thirdIntValue = Convert.ToInt32(Console.ReadLine());
            int maxIntNumer = maximumNumber.GetMaximumIntNumber(firstIntValue, secondIntValue, thirdIntValue);
            Console.WriteLine("Maximum :" + maxIntNumer);

            Console.WriteLine("Enter 3 float numbers");
            double firstDoubleValue = Convert.ToDouble(Console.ReadLine());
            double secondDoubleValue = Convert.ToDouble(Console.ReadLine());
            double thirdDoubleValue = Convert.ToDouble(Console.ReadLine());
            double maxDoubleNumer = maximumNumber.GetMaximumDoubleNumber(firstDoubleValue, secondDoubleValue, thirdDoubleValue);
            Console.WriteLine("Maximum :" + maxDoubleNumer);

            Console.WriteLine("Enter 3 Strings");
            string firstStringValue = Console.ReadLine();
            string secondStringValue = Console.ReadLine();
            string thirdStringValue = Console.ReadLine();
            string maxStringNumer = maximumNumber.GetMaximumString(firstStringValue, secondStringValue, thirdStringValue);
            Console.WriteLine("Maximum :" + maxStringNumer);


        }
    }
}
