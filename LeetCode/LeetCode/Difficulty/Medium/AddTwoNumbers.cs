using CommonLib.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersFunc(ListNode l1, ListNode l2)
        {
            int carry = 0;
            if (l1 == null || l2 == null)
            {
                return new ListNode(0);
            }
            ListNode sumList = null, head = null;
            while(l1 != null && l2 != null)
            {
                int sumval = l1.val + l2.val + carry;
                int val = sumval % 10;
                carry = sumval / 10;
                if (sumList == null)
                {
                    head = sumList = new ListNode(val);
                }
                else
                {
                    sumList.next = new ListNode(val);
                    sumList = sumList.next;
                }
                l1 = l1.next;
                l2 = l2.next;
            }

            if (l1 != null)
            {
                while(l1 != null)
                {
                    int sumval = l1.val + carry;
                    int val = sumval % 10;
                    carry = sumval / 10;
                    sumList.next = new ListNode(val);
                    sumList = sumList.next;
                    l1 = l1.next;
                }
            }

            if (l2 != null)
            {
                while(l2 != null)
                {
                    int sumval = l2.val + carry;
                    int val = sumval % 10;
                    carry = sumval / 10;
                    sumList.next = new ListNode(val);
                    sumList = sumList.next;
                    l2 = l2.next;
                }
            }

            if (carry != 0)
            {
                sumList.next = new ListNode(carry);
            }
            return head;
        }
    }
}
