using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algorithms
{
    public class AddDigits
    {
        public int AddTillOneDigit(int inputNumber)
        {
            if (inputNumber < 10)
                return inputNumber;           

           return AddTillOneDigit((inputNumber % 10) + (inputNumber / 10));
        }
    }   
}