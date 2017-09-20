using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Difficulty.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Difficulty.Easy.Tests
{
    [TestClass()]
    public class ArrayProblemsTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = { 3, 2, 2, 3 };
            int cnt = ArrayProblems.RemoveElement(nums, 3);
            Assert.IsTrue(cnt == 2);
        }
    }
}