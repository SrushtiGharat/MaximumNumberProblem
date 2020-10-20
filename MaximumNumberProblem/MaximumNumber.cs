using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberProblem
{
    public class MaximumNumber<T> where T : IComparable
    {
        T[] values;
        public MaximumNumber(T[] values)
        {
            this.values = values;
        }
        public T GetMaximum()
        {
            Array.Sort(values);
            return values[values.Length - 1];
        }
        public void PrintMaxValue()
        {
            Console.WriteLine("Maximum Value :" + GetMaximum());
        }
    }
}
