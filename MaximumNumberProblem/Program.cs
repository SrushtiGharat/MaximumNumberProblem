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
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            int maxNumer = maximumNumber.GetMaximumNumber(firstValue, secondValue, thirdValue);
        }
    }
}
