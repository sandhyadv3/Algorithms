using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
   
 // Definition for singly-linked list.
 public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public ListNode(int x, ListNode node)
        {
            val = x;
            next = node;
        }
  }

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersSolution(ListNode l1, ListNode l2)
        {
            var carry = 0;
            int x, y, sum;

            ListNode dummy = new ListNode(0);

            ListNode p = l1, q = l2, current = dummy;


            while (p != null || q != null)
            {
                 x = (p != null) ? p.val : 0;
                 y = (q != null) ? q.val : 0;

                sum = x + y + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);

                if (p != null) p = p.next;
                if (q != null) q = q.next;

                current = current.next;
            }

            if(carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummy.next;

        }
    }
   
}
