using System;

namespace _7.PlusOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                加一
                给定一个由 整数 组成的 非空 数组所表示的非负整数，在该数的基础上加一。

                最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。

                你可以假设除了整数 0 之外，这个整数不会以零开头。

                示例 1：

                输入：digits = [1,2,3]
                输出：[1,2,4]
                解释：输入数组表示数字 123。
                示例 2：

                输入：digits = [4,3,2,1]
                输出：[4,3,2,2]
                解释：输入数组表示数字 4321。
                示例 3：

                输入：digits = [0]
                输出：[1]
                 

                提示：

                1 <= digits.length <= 100
                0 <= digits[i] <= 9

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/x2cv1c/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var dis = new int[] { 9, 9, 9, 9 };
            var nums = PlusOne(dis);
            foreach (var item in nums)
            {
                Console.Write(item);
            }
        }

        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                //余数不为0直接返回
                digits[i] = digits[i] % 10;
                if (digits[i] != 0)
                    return digits;
            }
            //输入999的时候 数组扩容  第一个改为1  便是1000
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }
    }
}