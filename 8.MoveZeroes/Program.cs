using System;

namespace _8.MoveZeroes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                移动零
                给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

                示例:

                输入: [0,1,0,3,12]
                输出: [1,3,12,0,0]
                说明:

                必须在原数组上操作，不能拷贝额外的数组。
                尽量减少操作次数。

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/x2ba4i/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var nums = new int[] { 1, 2, 0, 6, 3, 0, 0, 0, 2 };
            MoveZeroes(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
        }

        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            var t = nums[j];
                            nums[i] = t;
                            nums[j] = 0;
                            break;
                        }
                    }
                }
            }
        }

        public static void MoveZeroes1(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }
            while (index < nums.Length)
            {
                nums[index++] = 0;
            }
        }

        public static void MoveZeroes2(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i > j)
                    {
                        nums[j] = nums[i];
                        nums[i] = 0;
                    }
                    j++;
                }
            }
        }
    }
}