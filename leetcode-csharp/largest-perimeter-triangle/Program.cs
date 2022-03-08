using System;
using System.Collections.Immutable;

namespace largest_perimeter_triangle
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Test(2, 1, 2);
            Test(1, 2, 1);
            Test(3, 2, 3, 4);
        }

        private static void Test(params int[] n)
        {
            Solution s = new Solution();
            var xout = s.LargestPerimeter(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public int LargestPerimeter(int[] nums)
        {
            // in order to be a triangle sum of two greater than largest side
            Array.Sort(nums);
            
            for (int i = nums.Length -1; i > 1; i--)
            {
                if (nums[i-2] + nums[i-1] > nums[i])
                {
                    return nums[i] + nums[i - 1] + nums[i - 2];
                }
                else
                {
                    continue;
                }

            }
            return 0;
        }
    }
}
