using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib.DataStruct;

namespace LeetCode.Tests
{
    [TestClass()]
    public class AddTwoNumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersFuncTest()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.next = new ListNode(9);
            var l3 = AddTwoNumbers.AddTwoNumbersFunc(l1, l2);
            Assert.IsNotNull(l3);
        }
    }
}