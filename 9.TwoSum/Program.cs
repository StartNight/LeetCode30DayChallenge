﻿using System;
using System.Collections.Generic;

namespace _9.TwoSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                两数之和
                给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。

                你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。

                你可以按任意顺序返回答案。
                 

                示例 1：

                输入：nums = [2,7,11,15], target = 9
                输出：[0,1]
                解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
                示例 2：

                输入：nums = [3,2,4], target = 6
                输出：[1,2]
                示例 3：

                输入：nums = [3,3], target = 6
                输出：[0,1]
                 

                提示：

                2 <= nums.length <= 104
                -109 <= nums[i] <= 109
                -109 <= target <= 109
                只会存在一个有效答案
                进阶：你可以想出一个时间复杂度小于 O(n2) 的算法吗？

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/x2jrse/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var nums = new int[] { 1, 2, 3, 4, 6, 7 };
            var s = TwoSun(nums, 9);
            Console.WriteLine(s[0] + ";" + s[1]);
        }

        public static int[] TwoSun(int[] nums, int target)
        {
            Dictionary<int, int> map1 = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map1.ContainsKey(target - nums[i]))
                {
                    return new int[2] { map1[target - nums[i]], i };
                }
                map1.Add(nums[i], i);
            }
            return new int[0];
        }
    }
}