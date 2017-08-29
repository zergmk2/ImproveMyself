using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class TwoSum
    {
        public static int[] TwoSumFunc(int[] nums, int target)
        {
            int[] wyj = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        wyj[0] = i;
                        wyj[1] = j;
                        return wyj;
                    }
                }
            }
            return wyj;
        }
        public static int[] TwoSumFunc1(int[] nums, int target)
        {
            int[] wyj = new int[2];
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashmap.ContainsKey(complement))
                {
                    wyj[0] = i;
                    wyj[1] = hashmap[complement];
                    return wyj;
                }
                if (!hashmap.ContainsKey(nums[i]))
                {
                    hashmap.Add(nums[i], i);
                }
            }
            return wyj;
        }
    }
}
