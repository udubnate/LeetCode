using System;
using System.Diagnostics.CodeAnalysis;

namespace average_salary_excluding_the_minimum_and_maximum_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test(1);
            Test(4000, 3000, 1000, 2000);
            Test(1000, 2000, 3000);
            Test(48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000);
        }

        private static void Test(params int[] n)
        {
            Solution s = new Solution();
            var xout = s.Average(n);
            Console.WriteLine("Input " + String.Join(',', n) + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public double Average(int[] salary)
        {
            int min = int.MaxValue;
            int max = 0;
            int sum = 0;
            foreach (int i in salary)
            {
                if (i < min) min = i;
                if (i > max) max = i;
                sum += i;
            }

            return (sum - min - max) / (salary.Length - 2.0);
        }
    }
}
