using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MaximumNumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values;
            int[] integerValues = new int[100];
            Console.WriteLine("Welcome To Maximum Number Problem");
            Console.WriteLine("Enter integers");
            values = Console.ReadLine().Split(" ");
            for(int i = 0; i < values.Length; i++)
            {
                integerValues[i] = Convert.ToInt32(values[i]);
            }
            MaximumNumber<int> maximumInt = new MaximumNumber<int>(integerValues);
            int maxIntNumber = maximumInt.GetMaximum();
            Console.WriteLine("Maximum :" + maxIntNumber);

            double[] doubleValues = new double[100];

            Console.WriteLine("Enter 3 float numbers");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            MaximumNumber<double> maximumDouble = new MaximumNumber<double>(doubleValues);
            double maxDoubleNumber = maximumDouble.GetMaximum();
            Console.WriteLine("Maximum :" + maxDoubleNumber);

            Console.WriteLine("Enter 3 Strings");
            values = Console.ReadLine().Split(" ");
            MaximumNumber<string> maximumString= new MaximumNumber<string>(values);
            string maxString = maximumString.GetMaximum();
            Console.WriteLine("Maximum :" + maxString);


        }
    }
}
