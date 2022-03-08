using System;

namespace subtract_the_product_and_sum_of_digits_of_an_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(234);
            Test(4421);
        }

        private static void Test(int n)
        {
            Solution s = new Solution();
            var xout = s.SubtractProductAndSum(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int mult = 1;
            int sum = 0;

            while (n > 0)
            {
                int num = n % 10;
                mult *= num;
                sum += num;
                n /= 10;
            }
            return mult - sum;
        }
    }
}

