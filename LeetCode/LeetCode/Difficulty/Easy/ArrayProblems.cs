using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Difficulty.Easy
{
    public class ArrayProblems
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null)
            {
                return 0;
            }
            else if (nums.Length == 0)
            {
                return 0;
            }

            int head = 0, tail = nums.Length - 1;
            while(head <= tail)
            {
                if (tail == head)
                {
                    if (nums[head] == val)
                    {
                        head--;
                    }
                    break;
                }

                if (nums[head] == val)
                {
                    while (tail > head && nums[tail] == val)
                    {
                        tail--;
                    }

                    if (tail == head)
                    {
                        head--;
                        break;
                    }
                    else
                    {
                        nums[head] = nums[tail];
                        tail--;
                        if (head == tail)
                        {
                            break;
                        }
                        else
                        {
                            head++;
                        }
                    }
                }
                else
                {
                    head++;
                }
            }

            return head + 1;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
            {
                return -1;
            }
            else if (nums.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] < target)
                {
                    continue;
                }
                else if (nums[i] > target)
                {
                    return i;
                }
            }

            return nums.Length;
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            else if (nums.Length == 0)
            {
                return 0;
            }

            int sum = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = sum < 0 ? nums[i] : nums[i] + sum;
                max = Math.Max(max, sum);
            }

            return max;
        }

        public static int[] PlusOne(int[] digits)
        {
            int sum = digits[digits.Length -1] + 1;
            digits[digits.Length - 1] = sum % 10;
            int carry = sum / 10;
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                sum = digits[i] + carry;
                digits[i] = sum % 10;
                carry = sum / 10;
            }

            if (carry == 1)
            {
                int[] ret = new int[digits.Length + 1];
                for (int i = 0; i < digits.Length; i ++)
                {
                    ret[i + 1] = digits[i];
                }
                ret[0] = carry;
                return ret;
            }
            return digits;
        }
    }


}
