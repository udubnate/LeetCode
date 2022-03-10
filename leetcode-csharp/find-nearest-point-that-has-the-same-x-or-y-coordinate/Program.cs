using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Threading;

namespace find_nearest_point_that_has_the_same_x_or_y_coordinate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(3, 4, getjagged( "[[1, 2],[3, 1],[2, 4],[2, 3],[4, 4]]"));
            Test(3, 4, getjagged("[[3,4]]"));
            Test(3, 4, getjagged("[[2, 3]]"));
        }

        private static int[][] getjagged(string s)
        {
            string pat = @"\d{1}, *\d{1}";
            Regex r = new Regex(pat);
            MatchCollection matches = r.Matches(s);
            //declare jagged array
            int[][] jagged = new int[matches.Count][];
            for (int i = 0; i < matches.Count; i++)
            {
                string[] point = matches[i].Value.Split(',');
                jagged[i] = new int[2];
                jagged[i][0] = Int32.Parse(point[0]);
                jagged[i][1] = Int32.Parse(point[1]);
            }

            return jagged;
        }
        private static void Test(int x, int y, int[][] points)
        {
            Solution s = new Solution();

            var xout = s.NearestValidPoint(x, y, points);
            Console.WriteLine("Input " + x + ", " + y + " : Answer is " + xout);
        }
    }

    public class Solution
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int count = 0;
            int manhattan = Int32.MaxValue;
            int idx = -1;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    int sum = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if (sum < manhattan)
                    {
                        manhattan = sum;
                        idx = i;
                    }
                    count++;
                }
          
            }
            return idx;
        }
    }
}
