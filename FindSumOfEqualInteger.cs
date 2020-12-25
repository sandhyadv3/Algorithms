using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindSumOfEqualInteger
    {
        public int Solution(int[] input)
        {
            if (input.Length == 0)
            {
                return -1;
            }

            Dictionary<int,int> sumDictionary = new Dictionary<int, int>();
            int maxSum = -1;

            for (int counter = 0; counter < input.Length; counter++)
            {
                int sum = ComputeSumForInteger(input[counter]);
                Console.WriteLine($"sum of integer {input[counter]} is equal to {sum}");
                Console.ReadLine();

                int value;
                if (sumDictionary.TryGetValue(sum, out value))
                {
                    maxSum = Math.Max(maxSum, value + input[counter]);
                    sumDictionary[sum] = value + input[counter];
                }
                else
                {
                    sumDictionary.Add(sum, input[counter]);
                }
            }

            return maxSum;
        }

        private int ComputeSumForInteger(int integerToSum)
        {
            var absInteger = Math.Abs(integerToSum);

            int sum = 0;

            while (absInteger > 0)
            {
                sum += absInteger % 10;
                absInteger /= 10;
            }

            return sum;
        }
    }
}
