using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TwoSum
    {
        public int[] FindTwoSum(int[] nums, int target)
        {
            for (int counter = 0; counter < nums.Length; counter++)
            {

                if (nums[counter] > target)
                    continue;
                for (int secCounter = counter + 1; secCounter < nums.Length; secCounter++)
                {
                    if (nums[counter] + nums[secCounter] == target)
                    {
                        int[] result = new int[2] { counter, secCounter };
                        Console.WriteLine($"First Value = {nums[counter]} and the second Value = {nums[secCounter]}");
                        return result;
                    }

                    var complement = target - nums[counter];
                }
            }
            return null;
        }

        //public int[] FindTwoSum(int[] nums, int target)
        //{
        //    Dictionary<int, int> numbersDic = new Dictionary<int, int>();

        //    for(int i=0; i<nums.Length; i++)
        //    {
        //        numbersDic.Add(nums[i], i);
        //    }

        //    for(int i=0; i<nums.Length; i++)
        //    {
        //        int complement = target - nums[i];
        //        int value;
        //        numbersDic.TryGetValue(complement, out value);

        //        if(value >0 && value != i)
        //        {
        //            return new int[2] { i, value };
        //        }
        //    }

        //    return null;
        //}
    }
}

