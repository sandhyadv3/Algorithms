using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // CallFindSumOfEqualInteger();

            // CallTwoSum();

            CallAddTwoNumbers();

        }

        private static void CallAddTwoNumbers()
        {
            ListNode l1 = new ListNode(2, new ListNode(6, new ListNode(2, null)));

            ListNode l2 = new ListNode(3, new ListNode(4, new ListNode(1, null)));

            var addTwoNumbers = new AddTwoNumbers();

           ListNode listnode = addTwoNumbers.AddTwoNumbersSolution(l1, l2);

            Console.WriteLine(listnode.val);
            Console.ReadLine();
        }

        private static void CallTwoSum()
        {
            int[] testcase = new int[5] { -1, -2, -3, -4, -5 };
            int target = -8;

            var twoSum = new TwoSum();
            var result = twoSum.FindTwoSum(testcase, target);
            Console.WriteLine($"Array values are: {testcase[0]}, {testcase[1]}, {testcase[2]}, {testcase[3]}, {testcase[4]} and the target = {target}");
            Console.WriteLine($"The first index is {result[0]} and the second index is {result[1]}");
            Console.ReadLine();
        }

        private static void CallFindSumOfEqualInteger()
        {
            int[][] testcases = new int[4][];

            testcases[0] = new int[8] { 51, 71, 17, 42, 33, 44, 24, 62 };
            testcases[1] = new int[4] { 51, 71, 17, 42 };
            testcases[2] = new int[3] { 42, 33, 60 };
            testcases[3] = new int[3] { 51, 32, 43 };


            for (int counter = 0; counter < testcases.Length; counter++)
            {
                var findSum = new FindSumOfEqualInteger();

                int maxValue = findSum.Solution(testcases[counter]);

                Console.WriteLine($"max sum {maxValue} ");
            }
        }
    }
}
