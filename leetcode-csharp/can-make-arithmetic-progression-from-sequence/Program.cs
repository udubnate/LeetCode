using System;
using System.Transactions;

namespace can_make_arithmetic_progression_from_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(3, 5, 1);
            Test(1, 2, 4);
            Test(9, 5, 7, 3, 1);
        }

        private static void Test(params int[] n)
        {
            Solution s = new Solution();
            var xout = s.CanMakeArithmeticProgression(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int setdiff = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != setdiff) return false;
            }
            return true;
        }
    }
}
