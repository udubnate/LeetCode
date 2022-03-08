using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace number_of_1_bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test(1);
            Test(Convert.ToUInt32("00000000000000000000000000001011", 2));
            Test(Convert.ToUInt32("00000000000000000000000010000000", 2));
            Test(Convert.ToUInt32("11111111111111111111111111111101", 2));
            //   Test(11111111111111111111111111111101);
        }

        private static void Test(uint n)
        {
            Solution s = new Solution();
            var xout = s.HammingWeight(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            
            while (n > 0)
            {
                uint lsd = n & 1; // get least sig digit
                if (lsd == 1) count++;
                n = n >> 1;
            }

            return count;
            
        }
    }
}
