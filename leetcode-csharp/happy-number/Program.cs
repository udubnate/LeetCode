using System;

namespace happy_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(19);
            Test(2);
        }

        private static void Test(params int[] n)
        {
            Solution s = new Solution();
            var xout = s.IsHappy(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public bool IsHappy(int n)
        {
            return false;
        }
    }
}
