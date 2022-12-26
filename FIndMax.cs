using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FIndMax
    {
        public int FindMaxInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 &&  firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) >= 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) > 0 &&  firstNumber.CompareTo(thirdNumber) >= 0)
            {
                return firstNumber;
            }
            if (thirdNumber.CompareTo(secondNumber) > 0 &&  thirdNumber.CompareTo(firstNumber) > 0 ||
                thirdNumber.CompareTo(secondNumber) >= 0 && thirdNumber.CompareTo(firstNumber) > 0 ||
                thirdNumber.CompareTo(secondNumber) > 0 &&  thirdNumber.CompareTo(firstNumber) >= 0)
            {
                return thirdNumber;
            }
            if (secondNumber.CompareTo(thirdNumber) > 0 &&  secondNumber.CompareTo(firstNumber) > 0 ||
                secondNumber.CompareTo(thirdNumber) >= 0 && secondNumber.CompareTo(firstNumber) > 0 ||
                secondNumber.CompareTo(thirdNumber) > 0 &&  secondNumber.CompareTo(firstNumber) >= 0)
            {
                return secondNumber;
            }
            return default;
        }
    }
}
