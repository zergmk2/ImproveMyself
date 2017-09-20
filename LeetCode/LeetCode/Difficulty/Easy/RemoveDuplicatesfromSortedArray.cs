using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Difficulty.Easy
{
    public class RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
                return 0;
            else if (nums.Length == 0)
                return 0;
            
            int cnt = 1;
            int tmp = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (tmp != nums[i])
                {
                    if (cnt != i)
                    {
                        nums[cnt] = nums[i];
                    }
                    cnt++;
                    tmp = nums[i]; 
                }
            }
            return cnt;
        }
    }
}
