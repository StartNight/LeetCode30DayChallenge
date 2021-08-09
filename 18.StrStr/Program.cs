using System;

namespace _18.StrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                实现 strStr()
                实现 strStr() 函数。
                
                给你两个字符串 haystack 和 needle ，请你在 haystack 字符串中找出 needle 字符串出现的第一个位置（下标从 0 开始）。如果不存在，则返回  -1 。
                
                 
                
                说明：
                
                当 needle 是空字符串时，我们应当返回什么值呢？这是一个在面试中很好的问题。
                
                对于本题而言，当 needle 是空字符串时我们应当返回 0 。这与 C 语言的 strstr() 以及 Java 的 indexOf() 定义相符。
                
                 
                
                示例 1：
                
                输入：haystack = "hello", needle = "ll"
                输出：2
                示例 2：
                
                输入：haystack = "aaaaa", needle = "bba"
                输出：-1
                示例 3：
                
                输入：haystack = "", needle = ""
                输出：0
                 
                
                提示：
                
                0 <= haystack.length, needle.length <= 5 * 104
                haystack 和 needle 仅由小写英文字符组成
                相关标签
                双指针
                字符串
                字符串匹配
                
                C#
                
                
                
                作者：力扣 (LeetCode)
                链接：https://leetcode-cn.com/leetbook/read/top-interview-questions-easy/xnr003/
                来源：力扣（LeetCode）
                著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
             */

            var num = StrStr("hello","ll");

        }
        public static int StrStr(string haystack, string needle)
        {
            int len_H = haystack.Length;
            int len_N = needle.Length;
            if (len_N == 0) return 0;
            int i = 0;
            int j = 0;
            while (i < len_H && j < len_N)
            {
                if (haystack[i] == needle[j]) { i++; j++; }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }

            }
            if (j == len_N) return (i - j);
            return -1;

        }
    }
}
