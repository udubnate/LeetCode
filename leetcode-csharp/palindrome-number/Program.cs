using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace palindrome_number
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Test(-121);
            Test(112211);
        }

        private static void Test (int x){
            Solution s = new Solution();
            bool xout = s.IsPalindrome(x);
            Console.WriteLine("Input " + x + " , Answer is " + xout);
        }

    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            //convert int to string so you can compare chars
            string xstr = x.ToString();
            int start = 0;
            int end = xstr.Length;

            for (int i = start; i < end / 2; i++)
            {
                // compare the first element to the last element until middle
                if (xstr[i] != xstr[end - i - 1])
                {
                    return false;
                }
                
            }
            
            return true;
        }
    }

}
