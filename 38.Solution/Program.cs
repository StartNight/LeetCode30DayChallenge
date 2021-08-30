using System;

namespace _38.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                打乱数组
                给你一个整数数组 nums ，设计算法来打乱一个没有重复元素的数组。
                
                实现 Solution class:
                
                Solution(int[] nums) 使用整数数组 nums 初始化对象
                int[] reset() 重设数组到它的初始状态并返回
                int[] shuffle() 返回数组随机打乱后的结果
                 
                
                示例：
                
                输入
                ["Solution", "shuffle", "reset", "shuffle"]
                [[[1, 2, 3]], [], [], []]
                输出
                [null, [3, 1, 2], [1, 2, 3], [1, 3, 2]]
                
                解释
                Solution solution = new Solution([1, 2, 3]);
                solution.shuffle();    // 打乱数组 [1,2,3] 并返回结果。任何 [1,2,3]的排列返 回的   概率 应该   相同。例如，返回 [3, 1, 2]
                solution.reset();      // 重设数组到它的初始状态 [1, 2, 3] 。返回 [1, 2,  3]
                solution.shuffle();    // 随机返回数组 [1, 2, 3] 打乱后的结果。例如，返回     [1,     3, 2]
                 
                
                提示：
                
                1 <= nums.length <= 200
                -106 <= nums[i] <= 106
                nums 中的所有元素都是 唯一的
                最多可以调用 5 * 104 次 reset 和 shuffle
                相关标签
                数组
                数学
                随机化
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-   easy/  xn6gq1/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

    }
    public class Solution
    {
        int[] nums;
        public Solution(int[] nums)
        {
            this.nums = nums;
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return nums;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            int[] a = (int[])nums.Clone();
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                int j = random.Next(i + 1);
                if (i != j)
                {
                    a[i] ^= a[j];
                    a[j] ^= a[i];
                    a[i] ^= a[j];
                }
            }
            return a;

        }
    }
}
