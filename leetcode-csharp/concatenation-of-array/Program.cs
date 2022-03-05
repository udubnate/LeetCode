using System;

namespace concatenation_of_array
{
    internal class Program
    {
        //Concatenation of Array
        /*
         *  Input: nums = [1,2,1]
         *  Output: [1,2,1,1,2,1]
         */

        static int[] ConcatenationofArray(int[] nums)
        {

            int[] outarr = new int[2 * nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                outarr[i] = nums[i];
                outarr[nums.Length + i] = nums[i];
            }
            return outarr;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1 };

            Console.WriteLine(String.Join(',', ConcatenationofArray(nums)));
        }
    }
}
