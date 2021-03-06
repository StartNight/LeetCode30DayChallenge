using System;

namespace _37.Rob
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                打家劫舍
                你是一个专业的小偷，计划偷窃沿街的房屋。每间房内都藏有一定的现金，影响你偷窃的唯一制约因素就是相邻的房屋装有相互连通的防盗系统，如果两间相邻的房屋在同一晚上被小偷闯入，系统会自动报警。

                给定一个代表每个房屋存放金额的非负整数数组，计算你 不触动警报装置的情况下 ，一夜之内能够偷窃到的最高金额。

                 

                示例 1：

                输入：[1,2,3,1]
                输出：4
                解释：偷窃 1 号房屋 (金额 = 1) ，然后偷窃 3 号房屋 (金额 = 3)。
                     偷窃到的最高金额 = 1 + 3 = 4 。
                示例 2：

                输入：[2,7,9,3,1]
                输出：12
                解释：偷窃 1 号房屋 (金额 = 2), 偷窃 3 号房屋 (金额 = 9)，接着偷窃 5 号房屋 (金额 = 1)。
                     偷窃到的最高金额 = 2 + 9 + 1 = 12 。
                 

                提示：

                1 <= nums.length <= 100
                0 <= nums[i] <= 400
                相关标签
                数组
                动态规划

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnq4km/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
        }

        /*
            核心思想是，到了第i个房间时，要决定偷还是不偷
            偷的话 就是 nums[i] + dp[i-2]
            不偷的话就是 dp[i-1]
            取两者最大收益即可
         */

        public int Rob(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int[] dp = new int[nums.Length];
            int max = dp[0];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
            }
            for (int i = 0; i < dp.Length; i++)
            {
                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }
            return max;
        }
    }
}