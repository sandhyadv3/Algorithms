using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algorithms
{
    public class PrimeNumber
    {
        public bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int n = 2; n <= number; n++)
            {
                if (number%n == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}