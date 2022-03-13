using System;

namespace sign_of_the_product_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Test(-1, -2, -3, -4, 3, 2, 1);
            Test(1, 5, 0, 2, -3);
            Test(-1, 1, -1, 1, -1);
            Test(51, 38, 73, 21, 27, 55, 18, 15, 79, 29, 13, 45, 8, -73, -92, -20, -50, -60, -70); //Should return 1
        }

        private static void Test(params int[] n)
        {
            Solution s = new Solution();
            var xout = s.ArraySign(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public int ArraySign(int[] nums)
        {
            int ret = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) return 0;

                ret *= nums[i] / Math.Abs(nums[i]);
            }
            return ret;
        }
    }
}
