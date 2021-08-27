﻿using System;

namespace _36.MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                最大子序和
                给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
                
                示例 1：
                
                输入：nums = [-2,1,-3,4,-1,2,1,-5,4]
                输出：6
                解释：连续子数组 [4,-1,2,1] 的和最大，为 6 。
                示例 2：
                
                输入：nums = [1]
                输出：1
                示例 3：
                
                输入：nums = [0]
                输出：0
                示例 4：
                
                输入：nums = [-1]
                输出：-1
                示例 5：
                
                输入：nums = [-100000]
                输出：-100000
                 
                
                提示：
                
                1 <= nums.length <= 3 * 104
                -105 <= nums[i] <= 105
                 
                
                进阶：如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的 分治法 求解。
                
                相关标签
                数组
                分治
                动态规划
                
                C#
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xn3cg3/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }
        public int MaxSubArray(int[] nums)
        {
            int length = nums.Length;
            int[] dp = new int[length];
            //边界条件
            dp[0] = nums[0];
            int max = dp[0];
            for (int i = 1; i < length; i++)
            {
                //转移公式
                dp[i] = Math.Max(dp[i - 1], 0) + nums[i];
                //记录最大值
                max = Math.Max(max, dp[i]);
            }
            return max;
        }
    }
}
