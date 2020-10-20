using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberProblem
{
    public class MaximumNumber
    {
        public int GetMaximumNumber(int firstNumber,int secondNumber,int thirdNumber)
        {
            if(firstNumber.CompareTo(secondNumber)>0 && firstNumber.CompareTo(thirdNumber)>0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(secondNumber) > 0 && thirdNumber.CompareTo(firstNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("Numbers are same. Please Enter Different Numbers");
        }
    }
}
