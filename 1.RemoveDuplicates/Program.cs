﻿using System;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                给你一个有序数组 nums ，请你 原地 删除重复出现的元素，使每个元素 只出现一次 ，返回删除后数组的新长度。
                
                不要使用额外的数组空间，你必须在 原地 修改输入数组 并在使用 O(1) 额外空间的条件下完成。
         
             
                示例 1：
                
                输入：nums = [1,1,2]
                输出：2, nums = [1,2]
                解释：函数应该返回新的长度 2 ，并且原数组 nums 的前两个元素被修改为 1, 2 。不需要考虑数组中超出新长度后面的元素。
                示例 2：
                
                输入：nums = [0,0,1,1,1,2,2,3,3,4]
                输出：5, nums = [0,1,2,3,4]
                解释：函数应该返回新的长度 5 ， 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4 。不需要考虑数组中超出新长度后面的元素。
                 
                
                提示：
                
                0 <= nums.length <= 3 * 104
                -104 <= nums[i] <= 104
                nums 已按升序排列
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/x2gy9m/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var nums = new int[] { 1, 1, 1, 2, 2, 3, 3, 4 };
            var lenght = removeDuplicates(nums);
            Console.WriteLine(lenght);
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(nums[i]);
            }
        }
        public static int removeDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int left = 0;
            for (int right = 1; right < nums.Length; right++)
            {
                if (nums[left]!= nums[right])
                {
                    nums[++left] = nums[right];
                }
            }
            return ++left;
        }
    }
}
