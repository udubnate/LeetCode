using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_leetcode
{
    //dynamic programming
    // https://leetcode.com/problems/climbing-stairs/
    // think of it as a decision tree
    // watching YT for some assistance : https://www.youtube.com/watch?v=Y0lT9Fck7qI
    // decision tree is basically recursion
    // Tree - Depth First Search
    // remove redundancy you can get to O(n)
    //bottom up dynamic programmign approach
    public class climbing_stairs
    {
        public int ClimbStairs(int n)
        {
            int two = 1;
            int one = 1;
            for (int i = 0; i < n-1; i++) 
            {
                int temp = one;
                one = one + two;
                two = temp;
            }
            return one;
        }
    }
}
