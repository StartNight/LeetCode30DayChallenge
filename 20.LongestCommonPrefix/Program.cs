using System;

namespace _20.LongestCommonPrefix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                最长公共前缀
                编写一个函数来查找字符串数组中的最长公共前缀。

                如果不存在公共前缀，返回空字符串 ""。

                 

                示例 1：

                输入：strs = ["flower","flow","flight"]
                输出："fl"
                示例 2：

                输入：strs = ["dog","racecar","car"]
                输出：""
                解释：输入不存在公共前缀。
                 

                提示：

                1 <= strs.length <= 200
                0 <= strs[i].length <= 200
                strs[i] 仅由小写英文字母组成
                相关标签
                字符串

                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnmav1/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */
            var s = LongestCommonPrefix(new string[] { "hello", "h", "hess" });
            Console.WriteLine(s);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || strs[j][i] != strs[j - 1][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0];
        }
    }
}