using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_leetcode.Helper;

namespace csharp_leetcode
{
    // LinkedList
    //Still in Progress
    public class Remove_duplicates_from_sorted_list
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            while(head != null)
            {
                if (head.val == head.next.val)
                {
                    head = head.next;
                }
            }
            return new ListNode(0);
        }
    }
}
