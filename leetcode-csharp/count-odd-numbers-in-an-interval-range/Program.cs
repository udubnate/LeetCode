using System;

namespace count_odd_numbers_in_an_interval_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(8, 10);
            Test(3, 7);
            Test(0, 3);
            Test(0, 10);
        }

        private static void Test(int low, int high)
        {
            Solution s = new Solution();
            var xout = s.CountOddsFast(low, high);
            Console.WriteLine("Input " + low + ',' + high + " , Answer is " + xout);
        }

        public class Solution
        {
            public int CountOdds(int low, int high)
            {
                int count = 0;

                for (int i = low; i <= high; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                return count;

            }

            public int CountOddsFast(int low, int high)
            {
                int diff = (high - low) / 2;

                if (low % 2 == 1 || high % 2 == 1)
                {
                    diff++;
                }

                return diff;
            }
        }
    }
}
