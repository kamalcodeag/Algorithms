using System;

namespace ConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 1, 0, 1, 0, 1, 1, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(numbers).ToString());
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxSum = 0;
            int tempSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    tempSum += nums[i];
                }

                if (nums[i] == 0)
                {
                    tempSum = 0;
                }

                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                }
            }

            return maxSum;
        }
    }
}
